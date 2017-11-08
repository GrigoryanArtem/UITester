// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System;
using UITester.Model.UIElements;

namespace UITester.Model.Executors
{
    [AttributeUsage(AttributeTargets.Method)]
    public class FunctionAttribute : Attribute
    {
        public FunctionAttribute(TestEvent testEvent)
        {
            TestEvent = testEvent;
        }

        public TestEvent TestEvent { get; set; }
    }
}
