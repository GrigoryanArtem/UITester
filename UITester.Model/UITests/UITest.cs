// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System;
using System.Collections.Generic;
using UITester.Model.UIElements;
using Winium.Cruciatus.Elements;

namespace UITester.Model.UITests
{
    [Equals]
    public class UITest : IUITest
    {
        private Dictionary<string, object> mParameters = new Dictionary<string, object>();

        #region Properties

        public CruciatusElement Element { get; private set; }
        public TestEvent TestEvent { get; private set; }

        public string Comment { get; private set; }

        #endregion

        public UITest(CruciatusElement element, TestEvent testEvent, string comment, TestParameter[] parameters)
        {
            Element = element;
            TestEvent = testEvent;
            Comment = comment;

            foreach (var parameter in parameters)
                mParameters.Add(parameter.Name, parameter.Value);
        }

        public static UITest Create(CruciatusElement element, TestEvent testEvent, TestParameter[] parameters)
        {
            return new UITest(element, testEvent, String.Empty, parameters);
        }

        public static UITest Create(CruciatusElement element, TestEvent testEvent, string comment, TestParameter[] parameters)
        {
            return new UITest(element, testEvent, comment, parameters);
        }

        public object GetParameter(string name)
        {
            return mParameters[name];
        }
    }
}
