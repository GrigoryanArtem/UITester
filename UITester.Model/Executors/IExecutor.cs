// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

namespace UITester.Model.Executors
{
    public interface IExecutor
    {
        int NumberOfSuccessTest { get; }
        int NumberOfTest { get; }
    }
}
