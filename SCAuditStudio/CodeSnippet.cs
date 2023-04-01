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

        public static CodeSnippet Empty
        {
            get { return new CodeSnippet(); }
        }

        public static async Task<CodeSnippet> ParseAsync(string githubLink)
        {
            //replace link with raw github source link
            string[] rawLink = githubLink.Replace("github.com", "raw.githubusercontent.com").Replace("blob/", "").Split("#");
            string link = rawLink[0];
            string[] lineInfo = rawLink[^1].Split("-");

            HttpClient client = new();
            string language = "undefined";
            string code = "";

            try
            {
                string response = await client.GetStringAsync(link);
                string[] page = response.Split("\n");

                int lineStart = rawLink.Length > 1 ? int.Parse(lineInfo[0].Replace("L", "")) - 1 : 0;
                int lineEnd = lineInfo.Length > 1 ? int.Parse(lineInfo[^1].Replace("L", "")) : page.Length;

                language = page.Where(l => l.StartsWith("pragma"))?.First().Split(" ")[1] ?? "undefined";
                code = "";

                for (int l = lineStart; l < lineEnd; l++)
                {
                    code += page[l];
                }
            }
            catch
            {
                return Empty;
            }

            return new CodeSnippet(code, language);
        }
    }
}
