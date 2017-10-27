// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

namespace UITester.Model.Writers
{
    public interface IWriter
    {
        void Write(IWriterMessage message);
    }
}
