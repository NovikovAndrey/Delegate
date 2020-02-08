using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }
        public int OperationCode { get; }
        public AccountEventArgs(string mess, int sum, int v)
        {
            Message = mess;
            Sum = sum;
            OperationCode = v;

        }
    }
}
