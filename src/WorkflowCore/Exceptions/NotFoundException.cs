using System;

namespace WorkflowCore.Exceptions
{
    public class NotFoundException : Exception
    {

        public NotFoundException() : base()
        {

        }

        public NotFoundException(string message) : base(message)
        {
            //
        }
    }
}