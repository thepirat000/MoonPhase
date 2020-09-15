using System;
using System.Reflection;
using Microsoft.Win32.TaskScheduler;

namespace MoonPhase
{
    //https://dahall.github.io/TaskScheduler/
    public static class TaskSchedule
    {

        public static void CreateSchedule(int minutesInterval, int minutesFirstStart, string imageType = "LOCAL", string style = "ResizeToFit")
        {
            imageType = imageType?.ToUpper() ?? "LOCAL";
            var taskName = $"MoonPhase_{imageType}";
            var exePath = Assembly.GetExecutingAssembly().Location;
            using (TaskService ts = new TaskService())
            {
                // Create a new task definition and assign properties
                TaskDefinition td = ts.NewTask();
                td.Principal.RunLevel = TaskRunLevel.Highest;
                td.Settings.Hidden = true;
                td.RegistrationInfo.Description = "Moon phase wallpaper changer";
                td.RegistrationInfo.Author = "Federico Colombo";

                var fistDate = minutesFirstStart == 0 ? DateTime.Now.AddSeconds(10) : DateTime.Now.AddMinutes(minutesFirstStart);

                // Create a trigger that will fire now and each x mins
                td.Triggers.Add(new TimeTrigger(fistDate)
                {
                    Repetition = new RepetitionPattern(TimeSpan.FromMinutes(minutesInterval), TimeSpan.Zero),
                    EndBoundary = fistDate.AddYears(2),
                    Enabled = true
                });

                td.Actions.Add(new ExecAction(exePath, $"-wallpaper {imageType} {style}", null));

                // Register the task in the root folder
                ts.RootFolder.RegisterTaskDefinition(taskName, td);
            }
        }

        public static void DeleteSchedule(string imageType = "LOCAL")
        {
            imageType = imageType?.ToUpper() ?? "LOCAL";
            using (TaskService ts = new TaskService())
            {
                ts.RootFolder.DeleteTask($"MoonPhase_{imageType}");
            }
        }
    }
}
