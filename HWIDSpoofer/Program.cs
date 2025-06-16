using System;

namespace HWIDSpoofer
{
    class Program
    {
        public static string textLogo = @" _______       _   _       _    ___          _______ _____     _____                    __ " + Environment.NewLine +
            @"|___  / |     | | | |     | |  | \ \        / /_   _|  __ \   / ____|                  / _|" + Environment.NewLine +
            @"   / /| | ___ | |_| |__   | |__| |\ \  /\  / /  | | | |  | | | (___  _ __   ___   ___ | |_ " + Environment.NewLine +
            @"  / / | |/ _ \| __| '_ \  |  __  | \ \/  \/ /   | | | |  | |  \___ \| '_ \ / _ \ / _ \|  _|" + Environment.NewLine +
            @" / /__| | (_) | |_| | | | | |  | |  \  /\  /   _| |_| |__| |  ____) | |_) | (_) | (_) | |  " + Environment.NewLine +
            @"/_____|_|\___/ \__|_| |_| |_|  |_|   \/  \/   |_____|_____/  |_____/| .__/ \___/ \___/|_|  " + Environment.NewLine +
            @"                                                                    | |                    " + Environment.NewLine +
            @"                                                                    |_|                    " + Environment.NewLine; // for create ascii text signature https://www.kammerl.de/ascii/AsciiSignature.php

        static void Main(string[] args)
        {
        begin:
            Console.Title = "Simple Hwid Spoofer - https://discord.gg/w3QWnktcWX";
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine(textLogo);
            Console.WriteLine("  ┌─────────────────────────────────────────┐");
            Console.WriteLine("  │ [!hwid] Spoof HWID (for ban evading)    │");
            Console.WriteLine("  │ [!guid] Spoof Guid                      │");
            Console.WriteLine("  │ [!pcName] Spoof your Computer Name      │");
            Console.WriteLine("  │ [!productId] Spoof ProductId            │");
            Console.WriteLine("  └─────────────────────────────────────────┘");

            string input = Console.ReadLine();
            if(input == "!hwid")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.HWID.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.HWID.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.HWID.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "!guid")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.PCGuid.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.PCGuid.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.PCGuid.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "!pcName")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.PCName.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.PCName.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.PCName.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "!productId")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.ProductId.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.ProductId.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.ProductId.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else
            {
                goto begin;
            }
        }
    }
}
