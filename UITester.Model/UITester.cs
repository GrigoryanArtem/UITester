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
        private CruciatusElement mMainWindow;
        private ITestsExecutor mTestsExecutor;
        private List<IUITest> mTestList = new List<IUITest>();
        private Dictionary<string, UIElement> mIdentificators 
            = new Dictionary<string, UIElement>();

        #endregion

        public UITester(string applicationPath, string windowName)
        {
            mWriter = Kernel.Instance.Get<IWriter>();
            mTestsExecutor = Kernel.Instance.Get< ITestsExecutor>();
            mApplication = new Application(applicationPath);

            InitializeTestWindow(windowName);
        }

        #region Public methods

        public UITester AddIdentificator(string name, UIElement element)
        {
            mIdentificators.Add(name, element);

            return this;
        }

        public UITester AddTest(string id, TestEvent testEvent, params TestParameter[] parameters)
        {
            return AddTest(UITest.Create(GetElementById(id), testEvent, parameters));
        }

        public UITester AddTest(string id, TestEvent testEvent, string comment, params TestParameter[] parameters)
        {
            return AddTest(UITest.Create(GetElementById(id), testEvent, comment, parameters));
        }

        public UITester AddTest(IUITest test)
        {
            mTestList.Add(test);
            return this;
        }

        public void Close()
        {
            mApplication.Close();
        }

        public void StartTesting()
        {
            mWriter.Write(new Message(TesterStringResources.StartTesting));
            var start = DateTime.Now;

            mTestsExecutor.Execute(mTestList);

            var interval = DateTime.Now - start;
            double passedTests = (double)mTestsExecutor.NumberOfSuccessTest 
                / (double)mTestsExecutor.NumberOfTest * 100.0;

            mWriter.Write(new Message(TesterStringResources.EndTesting));
            mWriter.Write(new Message(String.Format(TesterStringResources.TestingTimeFormat, interval.TotalSeconds)));
            mWriter.Write(new Message(String.Format(TesterStringResources.TestPassedReportFormat,
                mTestsExecutor.NumberOfSuccessTest, mTestsExecutor.NumberOfTest, passedTests)));
        }

        #endregion

        #region Private mehods

        private void InitializeTestWindow(string windowName)
        {
            mApplication.Start();
            var winFinder = By.Name(windowName).AndType(ControlType.Window);
            mMainWindow = CruciatusFactory.Root.FindElement(winFinder);
        }

        private CruciatusElement GetElementById(string id)
        {
            var uiElement = mIdentificators[id];

            if (!String.IsNullOrEmpty(uiElement.UID))
                return mMainWindow.FindElementByUid(uiElement.UID);

            if (uiElement.Name != null)
                return mMainWindow.FindElement(By.Name(uiElement.Name).AndType(uiElement.Type));

            throw new ArgumentException();
        }

        #endregion
    }
}
