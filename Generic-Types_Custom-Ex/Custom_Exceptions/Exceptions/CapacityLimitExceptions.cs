using System;
namespace Custom_Exceptions.Exceptions
{
    class CapacityLimitexception : Exception
    {
        public CapacityLimitexception(string message) : base(message)
        {

        }
    }
}
