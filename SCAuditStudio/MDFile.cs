namespace SCAuditStudio
{
    internal class MDFile
    {
        public string path;
        public string rawContent;

        public string author;
        public string severity;
        public string title;
        public string summary;
        public string detail;
        public string impact;
        public CodeSnippet[] code;
        public string tools;
        public string recommendation;

        /* CONSTRUCTORS */
        public MDFile()
        {
            path = "";
            rawContent = "";

            author = "";
            severity = "";
            title = "";
            summary = "";
            detail = "";
            impact = "";
            code = Array.Empty<CodeSnippet>();
            tools = "";
            recommendation = "";
        }
        public MDFile(string path, string rawContent)
        {
            this.path = path;
            this.rawContent = rawContent;

            author = "";
            severity = "";
            title = "";
            summary = "";
            detail = "";
            impact = "";
            code = Array.Empty<CodeSnippet>();
            tools = "";
            recommendation = "";
        }

        /* STATIC PROPERTIES */
        public static MDFile Invalid
        {
            get { return new MDFile("invalid", "invalid"); }
        }
    }
}
