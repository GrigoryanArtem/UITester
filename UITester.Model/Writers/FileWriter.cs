// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System;
using System.IO;

namespace UITester.Model.Writers
{
    public class FileWriter : IWriter
    {
        private string mFilePath;
        public static string FilePath { get; set; }

        public FileWriter() : this(FilePath) { }

        public FileWriter(string path)
        {
            mFilePath = path;
            File.Delete(path);
        }

        public void Write(IWriterMessage message)
        {
            File.AppendAllText(mFilePath, message.Content + Environment.NewLine);
        }
    }
}
