using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Account
    {
        public delegate void AccountStateHandler(string mess);
        AccountStateHandler accountState;
        int sum;
        public Account(int sum1)
        {
            sum = sum1;
        }
        public int CurrentSum
        {
            get { return sum; }
        }
        public void Put(int sum1)
        {
            sum += sum1;
        }
        public void Withdraw(int sum1)
        {
            if (sum1<=sum)
            {
                sum -= sum1;
                accountState?.Invoke($"Сумма {sum1} снята со счета");
            }
            else
            {
                accountState?.Invoke($"Недостаточно денег");
            }
        }
        public void RegisterHandler(AccountStateHandler accountState1)
        {
            accountState = accountState1;
        }
    }
}
