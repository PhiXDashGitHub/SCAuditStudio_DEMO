namespace SCAuditStudio
{
    internal class CodeSnippet
    {
        public string language;
        public string code;

        public CodeSnippet()
        {
            language = "undefined";
            code = "";
        }

        public CodeSnippet(string code, string language = "undefined")
        {
            this.code = code;
            this.language = language;
        }

        public static async Task<CodeSnippet> ParseAsync(string githubLink)
        {
            //replace link with raw github source link
            string[] rawLink = githubLink.Replace("github.com", "raw.githubusercontent.com").Replace("blob/", "").Split("#");
            string link = rawLink[0];
            string[] lineInfo = rawLink[^1].Split("-");

            HttpClient client = new();
            string response = await client.GetStringAsync(link);
            string[] page = response.Split("\n");

            int lineStart = rawLink.Length > 1 ? int.Parse(lineInfo[0].Replace("L", "")) - 1 : 0;
            int lineEnd = lineInfo.Length > 1 ? int.Parse(lineInfo[^1].Replace("L", "")) : page.Length;

            string language = page.Where(l => l.StartsWith("pragma"))?.First().Split(" ")[1] ?? "undefined";
            string code = "";
            for (int l = lineStart; l < lineEnd; l++)
            {
                code += page[l];
            }

            return new CodeSnippet(code, language);
        }
    }
}
