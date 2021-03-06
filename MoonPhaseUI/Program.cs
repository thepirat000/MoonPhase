﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonPhase
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern int FreeConsole();

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern bool AttachConsole(int processId);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                FreeConsole();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                // Console
                MainConsole(args);
            }
        }

        private static void MainConsole(string[] args)
        {
            var date = DateTime.Now;
            
            if (args[0].ToLower() == "-w"  || args[0].ToLower() == "/w" || args[0].ToLower() == "-wallpaper" || args[0].ToLower() == "/wallpaper")
            {
                FreeConsole();
                string imgUrl = null;
                if (args.Length < 2 || args[1].ToUpper() == "RANDOM")
                {
                    imgUrl = MoonNasaImageHelper.GetRandomMoonImageUrl(date);
                }
                else
                {
                    int id;
                    if (int.TryParse(args[1], out id))
                    {
                        imgUrl = MoonNasaImageHelper.GetMoonImageUrl(id, date);
                    }
                    else if (args[1].ToUpper().StartsWith("NASA") && args[1].Length > 4)
                    {
                        id = int.Parse(args[1].Substring(3, 1));
                        imgUrl = MoonNasaImageHelper.GetMoonImageUrl(id, date);
                    }
                    else
                    {
                        imgUrl = MoonNasaImageHelper.GetMoonImageUrl(args[1], date);
                    }
                }
                if (imgUrl != null)
                {
                    var style = args.Length < 3 ? Wallpaper.Style.Fit : (Wallpaper.Style)Enum.Parse(typeof(Wallpaper.Style), args[2], true);
                    Wallpaper.Set(ImageDownload.FromUrl(imgUrl), style);
                }
            }
            else if (args[0].ToLower() == "-i" || args[0].ToLower() == "/i" || args[0].ToLower() == "-install" || args[0].ToLower() == "/install")
            {
                // install 
                int mins = args.Length < 3 ? 15 : int.Parse(args[2]);
                int start_mins = args.Length < 4 ? 0 : int.Parse(args[3]);
                var imgType = args.Length < 2 ? "NASA1" : args[1];
                var style = args.Length < 5 ? "Fit" : args[4];
                TaskSchedule.CreateSchedule(mins, start_mins, imgType, style);
            }
            else if (args[0].ToLower() == "-u" || args[0].ToLower() == "/u" || args[0].ToLower() == "-uninstall" || args[0].ToLower() == "/uninstall")
            {
                TaskSchedule.DeleteSchedule(args[1]);
            }
            else
            {
                AttachToParentConsole();
                ShowHelp();
            }
        }

        private static void AttachToParentConsole()
        {
            if (!AttachConsole(-1)) 
                AllocConsole();
            Console.WriteLine();
        }

        private static void ShowHelp()
        {
            Console.WriteLine("MoonPhase");
            Console.WriteLine();
            Console.WriteLine("Commands:");
            Console.WriteLine("-wallpaper IMAGE [TYPE]: Sets the wallpaper");
            Console.WriteLine();
            Console.WriteLine("-install IMAGE MINUTES [START_MINUTES] [TYPE]: Installs the scheduler");
            Console.WriteLine();
            Console.WriteLine("-uninstall IMAGE: Uninstalls the scheduler");
            Console.WriteLine();
            Console.WriteLine("Parameters:");
            Console.WriteLine("    MINUTES: Minutes until next run");
            Console.WriteLine("    START_MINUTES: (optional, default 0) Minutes until the first run");
            Console.WriteLine("    IMAGE: 'Random', 'Moon', 'Fancy', 'Plain', 'Globe', 'Orbit', 'FancyMini', 'MoonMini'");
            Console.WriteLine("    TYPE: (optional, default Fit) 'Fit', 'Fill', 'Span', 'Centered', 'Tiled' or 'Stretched'");
            SendKeys.SendWait("{ENTER}");
        }
    }
}
