// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System.Windows.Automation;
using UITester.Model.UIElements;
using UITester.Model.UITests;

namespace UITester.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.UITester tester = new Model.UITester("TestProject.exe", "CALC");

            tester
                .AddIdentificator("b1", new UIElement("1", null, ControlType.Button))
                .AddIdentificator("b2", new UIElement("2", null, ControlType.Button))
                .AddIdentificator("b3", new UIElement("3", null, ControlType.Button))
                .AddIdentificator("b4", new UIElement("4", null, ControlType.Button))
                .AddIdentificator("b5", new UIElement("5", null, ControlType.Button))
                .AddIdentificator("b6", new UIElement("6", null, ControlType.Button))
                .AddIdentificator("b7", new UIElement("7", null, ControlType.Button))
                .AddIdentificator("b8", new UIElement("8", null, ControlType.Button))
                .AddIdentificator("b9", new UIElement("9", null, ControlType.Button))
                .AddIdentificator("b0", new UIElement("0", null, ControlType.Button))
                .AddIdentificator("bp", new UIElement("+", null, ControlType.Button))
                .AddIdentificator("be", new UIElement("=", null, ControlType.Button))
                .AddIdentificator("c", new UIElement("C", null, ControlType.Button))
                .AddIdentificator("textBox", new UIElement("", null, ControlType.Edit))
                .AddTest("b1", TestEvent.Click)
                .AddTest("bp", TestEvent.Click)
                .AddTest("b1", TestEvent.Click)
                .AddTest("be", TestEvent.Click)
                .AddTest("textBox", TestEvent.GetText, "1 + 1 = 2 ?", TestParameter.Create("text", "2"))
                .AddTest("c", TestEvent.Click)
                .AddTest("b2", TestEvent.Click)
                .AddTest("bp", TestEvent.Click)
                .AddTest("b2", TestEvent.Click)
                .AddTest("be", TestEvent.Click)
                .AddTest("textBox", TestEvent.GetText, "2 + 2 = 5 ?", TestParameter.Create("text", "5"))
                .AddTest("c", TestEvent.Click)
                .AddTest("b2", TestEvent.Click)
                .AddTest("bp", TestEvent.Click)
                .AddTest("b2", TestEvent.Click)
                .AddTest("be", TestEvent.Click)
                .AddTest("textBox", TestEvent.GetText, "2 + 2 = 4 ?", TestParameter.Create("text", "4"));

            tester.StartTesting();
            tester.Close();
        }
    }
}
