namespace SetConsoleOptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using CommandLine;
    using CommandLine.Text;

    public class Options
    {
        [Option('c', "colour", Required = true,
        HelpText = "The console colour to change")]
        public ConsoleColor Color { get; set; }

        [Option('r', "red", Required = true,
        HelpText = "The decimal value to assign to the red value")]
        public uint Red { get; set; }

        [Option('g', "green", Required = true,
        HelpText = "The decimal value to assign to the green value")]
        public uint Green { get; set; }

        [Option('b', "blue", Required = true,
        HelpText = "The decimal value to assign to the blue value")]
        public uint Blue { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}