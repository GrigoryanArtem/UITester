// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System.Collections.Generic;
using UITester.Model.UITests;

namespace UITester.Model.Executors
{
    public class DefaultTestsExecutor : ITestsExecutor
    {
        private ITestExecutor mTestExecutor;

        public DefaultTestsExecutor()
        {
            mTestExecutor = Kernel.Instance.Get<ITestExecutor>();
        }

        public int NumberOfSuccessTest => mTestExecutor.NumberOfSuccessTest;

        public int NumberOfTest => mTestExecutor.NumberOfTest;

        public void Execute(List<IUITest> tests)
        {
            foreach (var test in tests)
                mTestExecutor.Execute(test);
        }
    }
}
