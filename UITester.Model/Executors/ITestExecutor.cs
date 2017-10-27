// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using UITester.Model.UITests;

namespace UITester.Model.Executors
{
    public interface ITestExecutor : IExecutor
    {
        void Execute(IUITest test);
    }
}
