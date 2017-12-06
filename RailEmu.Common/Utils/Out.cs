using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailEmu.Common.Utils
{
    public static class Out
    {
        public static bool DebugMode = false;


        public static void Header()
        {
            #region
            string Logo = $@"
                        __________        .__.__  ___________              
                        \______   \_____  |__|  | \_   _____/ _____  __ __ 
                         |       _/\__  \ |  |  |  |    __)_ /     \|  |  \
                         |    |   \ / __ \|  |  |__|        \  Y Y  \  |  /
                         |____|_  /(____  /__|____/_______  /__|_|  /____/ 
                                \/      \/                \/      \/       
                                                       
                                                        Emulator V {ConfigManager.Version}";
            #endregion
            WriteLine(Logo, ConsoleColor.Green);
        }

        public static void Debug(string msg)
        {
            if (DebugMode)
                WriteLine($"[DEBUG] {msg}", ConsoleColor.DarkGreen);
        }
        public static void Warn(string msg) =>
            WriteLine($"[WARN] {msg}", ConsoleColor.Yellow);
        public static void Error(string msg) =>
            WriteLine($"[ERROR] {msg}", ConsoleColor.Red);
        public static void Info(string msg) =>
            WriteLine($"> {msg}", ConsoleColor.Green);


        public static void WriteLine(string msg, ConsoleColor color = ConsoleColor.Gray)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ForegroundColor = old;
        }
        public static void Write(string msg, ConsoleColor color = ConsoleColor.Gray)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(msg);
            Console.ForegroundColor = old;
        }
    }
}
