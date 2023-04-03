namespace SCAuditStudio
{
    static class AutoDirectorySort
    {
        public static async Task<int> GetScore(MDFile issue, string criteria, string context, int avgIssueTextLength)
        {
            //Perform Static Checks
            int staticScore = GetStaticScore(issue, avgIssueTextLength);

            //Perform AI Checks
            string[] userMessage = new string[6];
            userMessage[0] = "Check if this Smart Contract Vurnability is an valid issue, only return: 'Invalid1' (if the issue is Invalid), 'Invalid2' (if there is a small chance the issue is Invalid), 'Valid' (if you are sure the issue is valid). Use following criteria and context:";
            userMessage[1] = "Criteria: \n" + criteria;
            userMessage[2] = "Context: \n" + context;
            userMessage[3] = "Vurnability Detail: \n" + issue.detail;
            userMessage[4] = "Vurnability Impact: \n" + issue.summary;
            userMessage[5] = "Vurnability Impact: \n" + issue.impact;

            var userMessageS = userMessage.ToSingle();
            string response = await AISort.AskGPT(userMessageS);

            if (response.Contains("Invalid1"))
            {
                staticScore *= 0;
            }
            if (response.Contains("Invalid2"))
            {
                staticScore *= 1;
            }
            if (response.Contains("Valid"))
            {
                staticScore *= 2;
            }
            return staticScore;
        }

        static async Task<bool> CompareIssues(string title1, string title2, string content1, string content2, string context)
        {
            float staticDistance = CompareIssuesStatic(title1, title2, content1, content2);
            if (staticDistance < 0.5)
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
                string response = await AISort.AskGPT(userMessageS);

                if (response.Contains("Same") || response.Contains("Similar"))
                {
                    return true;
                }
                if (response.Contains("Different"))
                {      
                    return false;
                }
                return false;
            }
        }

        static int GetStaticScore(MDFile issue,int avgIssueTextLength)
        {
            int totallength = issue.impact.Length + issue.detail.Length + issue.summary.Length;
            int blackListScore = StaticStringOperations.CheckForBlackList(issue, File.ReadAllText(Application.StartupPath + "./blacklist.txt"));
            int totalscore = Convert.ToInt16((totallength / avgIssueTextLength) + issue.impact.Length + blackListScore);
            return totalscore;
        }
        static float CompareIssuesStatic(string title1, string title2, string content1, string content2)
        {
            //Static compare title
            float staticDistanceTitle = StaticStringOperations.StaticCompareString(title1, title2);

            //Static compare content
            float staticDistanceContent = StaticStringOperations.StaticCompareString(content1, content2);
            return staticDistanceTitle + staticDistanceContent;
        }
    }
}
