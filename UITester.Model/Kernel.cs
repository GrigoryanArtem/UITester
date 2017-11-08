// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using Ninject;
using Ninject.Modules;
using Ninject.Parameters;
using System;

namespace UITester.Model
{
    public class Kernel
    {
        #region Members

        private StandardKernel mKernel;
        private static readonly Lazy<Kernel> mLazy =
            new Lazy<Kernel>(() => new Kernel());

        #endregion

        #region Properties

        public static Kernel Instance
        {
            get
            {
                return mLazy.Value;
            }
        }

        #endregion

        private Kernel()
        {
            mKernel = new StandardKernel(new NinjectBindings());
        }

        public void ResetModule(NinjectModule ninjectModule)
        {
            mKernel = new StandardKernel(ninjectModule);
        }

        public T Get<T>(params IParameter[] parameters)
        {
            return mKernel.Get<T>(parameters);
        }
    }
}
