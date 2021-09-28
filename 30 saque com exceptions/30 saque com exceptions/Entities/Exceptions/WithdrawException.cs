using System;

namespace _30_saque_com_exceptions.Entities.Exceptions
{
    class WithdrawException : ApplicationException
    {
        public WithdrawException(string message) : base(message)
        {
        }
    }
}
