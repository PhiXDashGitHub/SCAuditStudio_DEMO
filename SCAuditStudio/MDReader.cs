namespace SCAuditStudio
{
    internal class MDReader
    {
        readonly string workDir = @"C:\";

        public MDReader(string directory)
        {
            workDir = directory;
        }

        string? SearchFile(string fileName)
        {
            string[] files = Directory.GetFiles(workDir, fileName, SearchOption.AllDirectories);

            if (files.Length == 0)
            {
                //throw error, no file found
                return null;
            }

            if (files.Length > 1)
            {
                //throw error, multiple files found
                return null;
            }

            return files[0];
        }

        public async Task<MDFile> ReadFileAsync(string fileName)
        {
            MDFile file = new();

            //search file, return invalid if not found
            string? path = SearchFile(fileName);
            if (path == null) { return MDFile.Invalid; }

            file.path = path;
            file.rawContent = File.ReadAllText(path);

            //check for minimum length
            if (file.rawContent.Length < 10) { return MDFile.Invalid; }

            string[] content = file.rawContent.Split("\n");
            file.author = content[0].Replace("\r", "");
            file.severity = content[2].Replace("\r", "");
            file.title = content[4].Split("# ")[^1].Replace("\r", "");
            file.summary = content.Between("## Summary", "## Vulnerability Detail").ToSingle();
            file.detail = content.Between("## Vulnerability Detail", "## Impact").ToSingle();
            file.impact = content.Between("## Impact", "## Code Snippet").ToSingle();

            List<CodeSnippet> snippets = new();
            string[] codeLinks = content.Where(l => l.Contains("https://github.com/")).ToArray();
            for (int l = 0; l < codeLinks.Length; l++)
            {
                if (codeLinks[l].Contains('(') && codeLinks[l].Contains(')'))
                {
                    codeLinks[l] = codeLinks[l].Split('(', ')')[1];
                }

                snippets.Add(await CodeSnippet.ParseAsync(codeLinks[l]));
            }
            string[] codeSnippets = file.rawContent.Split("```").GetOddIndexedElements();
            for (int s = 0; s < codeSnippets.Length; s++)
            {
                string language = codeSnippets[s].Split("\n")[0].Replace("\r", "");
                codeSnippets[s] = codeSnippets[s].Split(language)[^1];

                snippets.Add(new(codeSnippets[s], language));
            }
            file.code = snippets.ToArray();

            file.tools = content.Between("## Tool used", "## Recommendation").ToSingle();
            file.recommendation = content.After("## Recommendation").ToSingle();

            return file;
        }
    }
}
