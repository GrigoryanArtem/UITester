// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System;
using System.IO;
using UITestScannerLexicalScanner;
using UITestScannerSyntaxScanner;

namespace UITester.Scanners
{
    public static class UITestScanner
    {
        public static Model.UITester ParseFile(this Model.UITester tester, string path)
        {
            var script = File.ReadAllText(path);
            return Parse(tester, script);
        }

        public static Model.UITester Parse(this Model.UITester tester, string script)
        {
            Scanner scanner = new Scanner();
            scanner.SetSource(script.Replace('\t', ' '), 0);

            Parser parser = new Parser(scanner);
            parser.Tester = tester;

            if (!parser.Parse())
                throw new Exception();

            return parser.Tester;
        }
    }
}
