// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System.Windows.Automation;

namespace UITester.Model.UIElements
{
    [Equals]
    public class UIElement
    {
        public UIElement(string name, string uID, ControlType type)
        {
            Name = name;
            UID = uID;
            Type = type;
        }

        public string Name{ get; set; }
        public string UID { get; set; }
        public  ControlType Type { get; set; }
    }
}
