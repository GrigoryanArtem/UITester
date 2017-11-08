// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using Ninject.Modules;
using UITester.Model.Executors;
using UITester.Model.Writers;

namespace UITester.Model
{
    public class FileNinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IWriter>().To<FileWriter>();
            Bind<ITestExecutor>().To<DefaultTestExecutor>();
            Bind<ITestsExecutor>().To<DefaultTestsExecutor>();
        }
    }
}
