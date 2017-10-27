// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using Ninject.Modules;
using UITester.Model.Executors;
using UITester.Model.Writers;

namespace UITester.Model
{
    class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IWriter>().To<ConsoleWriter>();
            Bind<ITestExecutor>().To<DefaultTestExecutor>();
            Bind<ITestsExecutor>().To<DefaultTestsExecutor>();
        }
    }
}
