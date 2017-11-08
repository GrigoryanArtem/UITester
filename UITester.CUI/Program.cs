// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System;
using UITester.Model;
using UITester.Model.Writers;
using UITester.Scanners;

namespace UITester.CUI
{
    class Program
    {
        private static Options mOptions = new Options();

        static void Main(string[] args)
        {

            if (!CommandLine.Parser.Default.ParseArguments(args, mOptions))
                Environment.Exit(1);

            if (!String.IsNullOrEmpty(mOptions.FilePath))
            {
                FileWriter.FilePath = mOptions.FilePath;
                Kernel.Instance.ResetModule(new FileNinjectBindings());
            }

            try
            {
                Model.UITester tester = new Model.UITester(mOptions.RunFilePath);

                tester.ParseFile(mOptions.TestFilePath);
                tester.StartTesting();
                tester.Close();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
