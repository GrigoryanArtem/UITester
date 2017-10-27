// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

namespace UITester.Model.Writers
{
    public class Message : IWriterMessage
    {
        public Message(string content)
        {
            Content = content;
        }

        public string Content { get; private set; }
    }
}
