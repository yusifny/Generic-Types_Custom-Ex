using System;
namespace Custom_Exceptions.Exceptions
{
    class ProductCountIsZeroException : Exception
    {
        public ProductCountIsZeroException(string message) : base(message)
        {
        }
    }
}
