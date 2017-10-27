// Copyright 2017 Grigoryan Artem
// Licensed under the Apache License, Version 2.0

using System;

namespace UITester.Model.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(IWriterMessage message)
        {
            if (message is SuccessMessage)
                WriteSucssesMessage(message);
            else if (message is FailureMessage)
                WriteFailureMessage(message);
            else if (message is InfoMessage)
                WriteInfoMessage(message);
            else
                WriteMessage(message as Message);
        }

        #region Private methods

        private void WriteMessage(IWriterMessage message)
        {
            Console.WriteLine(message.Content);
        }

        private void WriteSucssesMessage(IWriterMessage message)
        {
            WriteColorMessage(message, ConsoleColor.DarkGreen);
        }

        private void WriteInfoMessage(IWriterMessage message)
        {
            WriteColorMessage(message, ConsoleColor.DarkRed);
        }

        private void WriteFailureMessage(IWriterMessage message)
        {
            WriteColorMessage(message, ConsoleColor.Red);
        }

        private void WriteColorMessage(IWriterMessage message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message.Content);
            Console.ResetColor();
        }

        #endregion
    }
}
