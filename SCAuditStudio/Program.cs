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
            ConfigFile.Init();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainView());
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
        public static bool UserSelectOk(string header, string text)
        {
            TaskDialogPage page = new()
            {
                Caption = header,
                Text = text,
                Icon = TaskDialogIcon.Warning,
                Buttons = new TaskDialogButtonCollection(),
            };

            page.Buttons.Add(TaskDialogButton.Yes);
            page.Buttons.Add(TaskDialogButton.No);
            SystemSounds.Question.Play();
            return TaskDialog.ShowDialog(page) == TaskDialogButton.Yes;

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