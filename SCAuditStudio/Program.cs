using System.Media;

namespace SCAuditStudio
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainView());

            //MDReader mdReader = new(@"C:\Users\Phillip\Downloads\2023-02-gmx-judging-Oot2k\2023-02-gmx-judging-Oot2k");
            //MDFile mdFile = await mdReader.ReadFileAsync("001.md");
            //InfoMessage("MD File", mdFile.author);
        }

        public static void InfoMessage(string header, string text)
        {
            TaskDialogPage page = new()
            {
                Caption = header,
                Text = text,
                Icon = TaskDialogIcon.Information,
                Buttons = new TaskDialogButtonCollection(),
            };

            page.Buttons.Add(TaskDialogButton.OK);

            SystemSounds.Asterisk.Play();

            TaskDialog.ShowDialog(page);
        }

        public static string[] Between(this string[] array, string a, string b)
        {
            return array.SkipWhile(l => !l.StartsWith(a)).Skip(1).TakeWhile(l => !l.StartsWith(b)).ToArray();
        }

        public static string[] After(this string[] array, string a)
        {
            return array.SkipWhile(l => !l.StartsWith(a)).Skip(1).ToArray();
        }

        public static string ToSingle(this string[] array)
        {
            string result = array[0];

            for (int l = 1; l < array.Length; l++)
            {
                result += array[l];
            }

            return result;
        }

        public static string[] GetOddIndexedElements(this string[] array)
        {
            List<string> result = new();

            for (int l = 0; l < array.Length; l++)
            {
                if (l % 2 != 0)
                {
                    result.Add(array[l]);
                }
            }

            return result.ToArray();
        }
    }
}