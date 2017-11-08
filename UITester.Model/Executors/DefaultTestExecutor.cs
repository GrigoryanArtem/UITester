// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UITester.Model.UIElements;
using UITester.Model.UITests;
using UITester.Model.Writers;
using Winium.Cruciatus.Core;
using Winium.Cruciatus.Extensions;

namespace UITester.Model.Executors
{
    public class DefaultTestExecutor : ITestExecutor
    {
        private Dictionary<TestEvent, MethodInfo> mFunctions = new Dictionary<TestEvent, MethodInfo>();
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
            test.Element.SetFocus();
            InvokeMethod(test.TestEvent, (object)test);
        }

        private void InitFunctions()
        {
            var functions = GetType()
                .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(m => m.GetCustomAttributes<FunctionAttribute>().Any())
                .Select(m => new KeyValuePair<TestEvent, MethodInfo>(m.GetCustomAttribute<FunctionAttribute>().TestEvent, m));

            foreach (var function in functions)
                mFunctions.Add(function.Key, function.Value);           
        }

        public void ResetCounters()
        {
            NumberOfTest = NumberOfSuccessTest = 0;
        }

        #endregion

        #region Functions

        [Function(TestEvent.Click)]
        private void Click(IUITest test)
        {
            test.Element.Click();
        }

        [Function(TestEvent.DClick)]
        private void DClick(IUITest test)
        {
            test.Element.DoubleClick();
        }

        [Function(TestEvent.CtrlClick)]
        private void CtrlClick(IUITest test)
        {
            test.Element.ClickWithPressedCtrl();
        }

        [Function(TestEvent.SetFocus)]
        private void SetFocus(IUITest test) { }

        [Function(TestEvent.SetText)]
        private void SetText(IUITest test)
        {
            test.Element.SetText((string)test.GetParameter("text"));
        }

        [Function(TestEvent.Check)]
        private void Check(IUITest test)
        {
            test.Element.ToCheckBox().Check();
        }

        [Function(TestEvent.Uncheck)]
        private void Uncheck(IUITest test)
        {
            test.Element.ToCheckBox().Uncheck();
            
        }

        [Function(TestEvent.Collapse)]
        private void Collapse(IUITest test)
        {
            test.Element.ToComboBox().Collapse();
        }

        [Function(TestEvent.Expand)]
        private void Expand(IUITest test)
        {
            test.Element.ToComboBox().Expand();
        }

        [Function(TestEvent.ScrollTo)]
        private void ScrollTo(IUITest test)
        {
            test.Element.ToComboBox().ScrollTo(By.Name((string)test.GetParameter("element_name")));
        }

        [Function(TestEvent.Item)]
        private void Item(IUITest test)
        {
            string name = test.Element.ToDataGrid().Item(Convert.ToInt32(test.GetParameter("row")),
                Convert.ToInt32(test.GetParameter("column"))).Text();

            CheckTest(test, ("name", name));
        }

        [Function(TestEvent.SelectCell)]
        private void SelectCell(IUITest test)
        {
            test.Element.ToDataGrid().SelectCell(Convert.ToInt32(test.GetParameter("row")),
                Convert.ToInt32(test.GetParameter("column")));
        }

        [Function(TestEvent.SelectItem)]
        private void SelectItem(IUITest test)
        {
            test.Element.ToMenu().SelectItem((string)test.GetParameter("path"));
        }

        [Function(TestEvent.GetText)]
        private void GetText(IUITest test)
        {
            string text = test.Element.Text();

            CheckTest(test, ("text", text));
        }

        [Function(TestEvent.IsToggleOn)]
        private void IsToggleOn(IUITest test)
        {
            string isToggle = test.Element.ToCheckBox().IsToggleOn.ToString();

            CheckTest(test, ("isToggleOn", isToggle));

        }

        [Function(TestEvent.IsExpanded)]
        private void IsExpanded(IUITest test)
        {
            string isExpanded = test.Element.ToComboBox().IsExpanded.ToString();

            CheckTest(test, ("isExpanded", isExpanded));
        }

        [Function(TestEvent.SelectedItem)]
        private void SelectedItem(IUITest test)
        {
            string name = test.Element.ToComboBox().SelectedItem().ToString();

            CheckTest(test, ("name", name));
        }

        [Function(TestEvent.ColumnCount)]
        private void ColumnCount(IUITest test)
        {
            string columnCount = test.Element.ToDataGrid().ColumnCount.ToString();

            CheckTest(test, ("columnCount", columnCount));
        }

        [Function(TestEvent.RowCount)]
        private void RowCount(IUITest test)
        {
            string rowCount = test.Element.ToDataGrid().RowCount.ToString();

            CheckTest(test, ("rowCount", rowCount));
        }


        [Function(TestEvent.GetItem)]
        private void GetItem(IUITest test)
        {
            string name = test.Element.ToMenu().GetItem((string)test.GetParameter("path")).ToString();

            CheckTest(test, ("name", name));
        }

        #endregion

        #region Private methods

        private void InvokeMethod(TestEvent testEvent, params object[] @params)
        {
            mFunctions[testEvent].Invoke(this, @params);
        }

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
