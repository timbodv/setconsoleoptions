namespace SetConsoleOptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using CommandLine;

    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var options = new Options();
            if (Parser.Default.ParseArguments(args, options))
            {
                ConsoleColorHelpers.SetColor(options.Color, options.Red, options.Green, options.Blue);
            }
        }
    }
}
