using System;
namespace Custom_Exceptions.Exceptions
{
    class NotFoundException : Exception
    { 
        public NotFoundException(string message) : base(message)
        {
        }
    }
}