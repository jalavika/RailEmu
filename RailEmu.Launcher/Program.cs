using RailEmu.Auth.Network;
using RailEmu.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailEmu.Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Out.Header();
            AuthServer server = new AuthServer();
            server.Initialize("127.0.0.1", 443);
            ExecuteCommand();
        }

        static void HandleCommand(string[] cmd)
        {
            switch (cmd[0])
            {
                case "test":
                    Out.WriteLine("TEST !!!", ConsoleColor.Red);
                    break;
                default:
                    Out.WriteLine($"Unknown command {cmd[0]}");
                    break;
            }
        }

        static void ExecuteCommand()
        {
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(' ');
                HandleCommand(cmd);
            }
        }
    }
}
