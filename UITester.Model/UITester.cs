// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System;
using System.Collections.Generic;
using System.Windows.Automation;
using UITester.Model.Executors;
using UITester.Model.UIElements;
using UITester.Model.UITests;
using UITester.Model.Writers;
using Winium.Cruciatus;
using Winium.Cruciatus.Core;
using Winium.Cruciatus.Elements;

namespace UITester.Model
{
    public class UITester
    {
        #region Members

        private IWriter mWriter;
        private Application mApplication;
        private ITestExecutor mTestsExecutor;
        private DateTime mStartTime;
        private Stack<CruciatusElement> mWindowStack =
            new Stack<CruciatusElement>();
        private Dictionary<string, CruciatusElement> mIdentificators = 
            new Dictionary<string, CruciatusElement>();

        #endregion

        public UITester(string applicationPath)
        {
            mWriter = Kernel.Instance.Get<IWriter>();
            mTestsExecutor = Kernel.Instance.Get< ITestExecutor>();
            mApplication = new Application(applicationPath);
            mApplication.Start();

            mWriter.Write(new Message(TesterStringResources.StartTesting));
            mStartTime = DateTime.Now;
        }

        #region Public methods

        public bool IsIdentificatorExist(string id)
        {
            return mIdentificators.ContainsKey(id);
        }

        public UITester AddIdentificator(string name, UIElement element)
        {
            mIdentificators.Add(name, GetCruciatusElement(element));
            
            return this;
        }

        public UITester AddTest(string id, TestEvent testEvent, params TestParameter[] parameters)
        {
            return AddTest(UITest.Create(mIdentificators[id], testEvent, parameters));
        }

        public UITester AddTest(string id, TestEvent testEvent, string comment, params TestParameter[] parameters)
        {
            return AddTest(UITest.Create(mIdentificators[id], testEvent, comment, parameters));
        }

        public UITester AddTest(IUITest test)
        {
            

            mTestsExecutor.Execute(test);
            return this;
        }

        public UITester Become(string windowName)
        {
            var winFinder = By.Name(windowName).AndType(ControlType.Window);
            mWindowStack.Push(CruciatusFactory.Root.FindElement(winFinder));

            return this;
        }

        public UITester Unbecome()
        {
            mWindowStack.Pop();
            return this;
        }

        public void Close()
        {
            mApplication.Close();

            var interval = DateTime.Now - mStartTime;
            double passedTests = (double)mTestsExecutor.NumberOfSuccessTest
                / (double)mTestsExecutor.NumberOfTest * 100.0;

            mWriter.Write(new Message(TesterStringResources.EndTesting));
            mWriter.Write(new Message(String.Format(TesterStringResources.TestingTimeFormat, interval.TotalSeconds)));
            mWriter.Write(new Message(String.Format(TesterStringResources.TestPassedReportFormat,
                mTestsExecutor.NumberOfSuccessTest, mTestsExecutor.NumberOfTest, passedTests)));
        }

        #endregion

        #region Private mehods

        private CruciatusElement GetCruciatusElement(UIElement element)
        {
            if (!String.IsNullOrEmpty(element.UID))
                return mWindowStack.Peek().FindElementByUid(element.UID);

            if (element.Name != null)
                return mWindowStack.Peek().FindElement(By.Name(element.Name).AndType(element.Type));

            throw new ArgumentException();
        }

        #endregion
    }
}
