using System;
using System.IO;
using System.Windows;

namespace SaveFileAs
{
    internal static class ArgumentManager
    {
        public static string[] Args { get; set; }

        public static bool Validate()
        {
            if (Args.Length < 3 || !File.Exists(Args[0]))
            {
                MessageBox.Show("One or more arguments to run this application are missing or invalid.");
                return false;
            }

            return true;
        }

        public static void Print()
        {
            int argumentIndex = 0;

            foreach (string argument in Args)
            {
                Console.WriteLine("Arg {0}: {1}", argumentIndex, argument);
                argumentIndex++;
            }
        }
    }
}