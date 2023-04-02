namespace SCAuditStudio
{
    class AutoDirectorySort
    {
        public static async Task<int> GetScore(MDFile issue, string criteria, string context)
        {
            int qualtityScore = 1;
            float blackListScore = 0;
            double blacklistpenalty = 0.2f;
            double AIpenalty = 0.5f;
            StaticStringOperations staticStringOperations = new StaticStringOperations();
            AISort aISort = new AISort();
            //Perform Static Checks
            if (issue.impact.Length < 10 || issue.detail.Length < 10 || issue.code.Length < 1)
            {
                qualtityScore = 0;
                return qualtityScore;
            }
            else
            {
                qualtityScore = qualtityScore + issue.impact.Length + issue.detail.Length + issue.code.Length;
            }
            
            blackListScore = staticStringOperations.CheckForBlackList(issue, File.ReadAllText(Application.StartupPath + "./blacklist.txt"));
            if (blackListScore == 0.1)
            {
                qualtityScore -= Convert.ToInt16(qualtityScore * blacklistpenalty);
            }
            if (blackListScore > 0.1)
            {
                qualtityScore = 0;
                return qualtityScore;
            }
            string[] userMessage = new string[6];
            userMessage[0] = "Check if this Smart Contract Vurnability is an valid issue, only return: 'Invalid1' (if the issue is Invalid), 'Invalid2' (if there is a small chance the issue is Invalid), 'Valid' (if you are sure the issue is valid). Use following criteria and context:";
            userMessage[1] = "Criteria: \n" + criteria;
            userMessage[2] = "Context: \n" + context;
            userMessage[3] = "Vurnability Detail: \n" + issue.detail;
            userMessage[4] = "Vurnability Impact: \n" + issue.summary;
            userMessage[5] = "Vurnability Impact: \n" + issue.impact;

            var userMessageS = userMessage.ToSingle();
            string response = await aISort.AskGPT(userMessageS);

            if (response.Contains("Invalid1"))
            {
                qualtityScore = 0;
            }
            if (response.Contains("Invalid2"))
            {
                if (qualtityScore > 30)
                {
                    qualtityScore -= Convert.ToInt16(qualtityScore * AIpenalty);
                }
            }
            if (response.Contains("Valid"))
            {
                qualtityScore += Convert.ToInt16(qualtityScore * AIpenalty);
            }
            return qualtityScore;
        }

        static async Task<bool> CompareIssues(string title1, string title2, string content1, string content2, string context)
        {
            float titleweight = 0.3f;
            float titlescore = 0;
            float contentweight = 0.7f;
            StaticStringOperations staticStringOperations = new StaticStringOperations();
            AISort aISort = new AISort();

            //Static compare title
            float staticDistanceTitle = staticStringOperations.StaticCompareString(title1, title2);
            if (staticDistanceTitle < 0.2)
            {
                titleweight = 0.6f;
                titlescore = 1 - staticDistanceTitle;
            }
            else
            {
                string[] userMessage = new string[4];
                userMessage[0] = "Compare these two Smart Contract Vurnabilitys Titles, only return one of these categorys: Same (if they are identical),Similar (if they they have something in common), Different(if they have nothing in common) use following context:";
                userMessage[1] = "Context: \n" + context;
                userMessage[2] = "Title 1: \n" + title1;
                userMessage[3] = "Title 2: \n" + title2;

                var userMessageS = userMessage.ToSingle();
                string response = await aISort.AskGPT(userMessageS);

                if (response.Contains("Same") || response.Contains("Similar"))
                {
                    titleweight = 0.6f;
                    titlescore = 1;
                }
                if (response.Contains("Different"))
                {
                    titlescore = 0.1f;
                }
            }
            //Static compare content
            float staticDistanceContent = staticStringOperations.StaticCompareString(content1, content2);
            if (staticDistanceContent < 0.3)
            {
                return true;
            }
            else
            {
                string[] userMessage = new string[4];
                userMessage[0] = "Compare these two Smart Contract Vurnabilitys, only return one of these categorys: Same (if they are identical),Similar (if they they have something in common), Different(if they have nothing in common) use following context:";
                userMessage[1] = "Context: \n" + context;
                userMessage[2] = "Vulnability1: \n" + content1;
                userMessage[3] = "Vulnability2: \n" + content2;

                var userMessageS = userMessage.ToSingle();
                string response = await aISort.AskGPT(userMessageS);

                if (response.Contains("Same") || response.Contains("Similar"))
                {
                    return true;
                }
                if (response.Contains("Different"))
                {
                    float totalscore = 0;
                    totalscore = (titleweight * titlescore) + (contentweight * 0.3f);
                    if (totalscore > 0.5f)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
        }

        static async Task<int> GetStaticScore()
        {
            return 0;
        }
        static async Task<bool> CompareIssuesStatic()
        {
            return false;
        }
    }
}
