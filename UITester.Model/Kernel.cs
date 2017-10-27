// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using Ninject;
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

        public T Get<T>()
        {
            return mKernel.Get<T>();
        }
    }
}
