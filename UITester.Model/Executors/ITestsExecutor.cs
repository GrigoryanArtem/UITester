// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System.Collections.Generic;
using UITester.Model.UITests;

namespace UITester.Model.Executors
{
    public interface ITestsExecutor : IExecutor
    {
        void Execute(List<IUITest> tests);
    }
}
