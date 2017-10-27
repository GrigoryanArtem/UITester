// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using UITester.Model.UIElements;
using Winium.Cruciatus.Elements;

namespace UITester.Model.UITests
{
    public interface IUITest
    {
        CruciatusElement Element { get; }
        TestEvent TestEvent { get; }
        string Comment { get; }

        object GetParameter(string name);
    }
}