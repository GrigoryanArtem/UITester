// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using UITester.Scanners;

namespace UITester.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.UITester tester = new Model.UITester("TestProject.exe");

            tester.ParseFile("UITest.uit");
            tester.StartTesting();
            tester.Close();
        }
    }
}
