// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UITester.Model.UITests
{
    public static class ParametersParser
    {
        public static TestParameter[] Parse(string parameters)
        {
            List<TestParameter> parametersList = new List<TestParameter>();
            string pattern = @"(?<name>\S+?)\((?<value>.*?)\)";

            foreach (Match match in Regex.Matches(parameters, pattern))
                parametersList.Add(TestParameter.Create(match.Groups["name"].Value,
                    match.Groups["value"].Value));

            return parametersList.ToArray();
        }
    }
}
