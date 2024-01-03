using System;

namespace UsefulTool
{
    public sealed class InputException : Exception
    {
        public InputException(string message) : base(message)
        {
        }
    }
}
