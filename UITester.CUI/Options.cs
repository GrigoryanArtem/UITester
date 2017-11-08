// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using CommandLine;
using CommandLine.Text;

namespace UITester.CUI
{
    public class Options
    {

        [Option('r', "run", HelpText = "Run File", Required = true)]
        public string RunFilePath { get; set; }

        [Option('t', "test", HelpText = "Test File", Required = true)]
        public string TestFilePath { get; set; }

        [Option('f', "file", HelpText = "File Path.")]
        public string FilePath { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
