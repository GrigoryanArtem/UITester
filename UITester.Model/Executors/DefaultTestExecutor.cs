// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System;
using System.Collections.Generic;
using UITester.Model.UIElements;
using UITester.Model.UITests;
using UITester.Model.Writers;

namespace UITester.Model.Executors
{
    public class DefaultTestExecutor : ITestExecutor
    {
        private Dictionary<TestEvent, Action<IUITest>> mFunctions;
        private IWriter mWriter;

        #region Properties

        public int NumberOfSuccessTest { get; private set; } = 0;
        public int NumberOfTest { get; private set; } = 0;

        #endregion

        public DefaultTestExecutor()
        {
            mWriter = Kernel.Instance.Get<IWriter>(); ;
            InitFunctions();
        }

        #region Public methods

        public void Execute(IUITest test)
        {
            mFunctions[test.TestEvent](test);
        }

        private void InitFunctions()
        {
            mFunctions = new Dictionary<TestEvent, Action<IUITest>> {
                { TestEvent.Click, Click },
                { TestEvent.GetText, GetText }
            };
        }

        public void ResetCounters()
        {
            NumberOfTest = NumberOfSuccessTest = 0;
        }

        #endregion

        #region Functions

        private void Click(IUITest test)
        {
            test.Element.Click();
        }

        private void DClick(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void KClick(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void CtrlClick(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void SetFocus(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void SetText(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void Check(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void Uncheck(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void Collapse(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void Expand(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void ScrollTo(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void Item(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void SelectCell(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void SelectItem(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void GetText(IUITest test)
        {

            string text = test.Element.Text();

            CheckTest(test, ("text", text));
        }

        private void IsToggleOn(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void IsExpanded(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void SelectedItem(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void voidColumnCount(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void RowCount(IUITest test)
        {
            throw new NotImplementedException();
        }

        private void GetItem(IUITest test)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private methods

        private void CheckTest(IUITest test, params (string paramName, string actualValue)[] paramPairs)
        {
            NumberOfTest++;
            bool testResult = true;

            foreach (var paramPair in paramPairs)
                if ((string)test.GetParameter(paramPair.paramName) != paramPair.actualValue)
                    testResult = false;

            if (testResult)
                SuccessTest(test);
            else
            {
                FailureTest(test);

                foreach (var paramPair in paramPairs)
                {
                    mWriter.Write(new InfoMessage(String.Format(
                        TestExecutorStringResources.ActualFormat, paramPair.actualValue)));
                    mWriter.Write(new InfoMessage(String.Format(
                        TestExecutorStringResources.ExpectantFormat, (string)test.GetParameter(paramPair.paramName))));
                }
            }
        }

        private void SuccessTest(IUITest test)
        {
            NumberOfSuccessTest++;
            mWriter.Write(new SuccessMessage(String.Format(
                TestExecutorStringResources.SuccessTestFormat, GetTesttName(test))));
        }

        private void FailureTest(IUITest test)
        {
            mWriter.Write(new FailureMessage(String.Format(
                TestExecutorStringResources.FailureTestFormat, GetTesttName(test))));
        }

        private string GetTesttName(IUITest test)
        {
            return String.IsNullOrEmpty(test.Comment) ? 
                String.Format(TestExecutorStringResources.UnnamedTestFormat, NumberOfTest) : 
                test.Comment;
        }

        #endregion
    }
}
