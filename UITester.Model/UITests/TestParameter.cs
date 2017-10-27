// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

namespace UITester.Model.UITests
{
    [Equals]
    public class TestParameter
    {
        public string Name { get; private set; }
        public object Value { get; private set; }

        public static TestParameter Create(string name, object value)
        {
            return new TestParameter()
            {
                Name = name,
                Value = value
            };
        }
    }
}
