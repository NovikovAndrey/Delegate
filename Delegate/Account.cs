using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class Account
    {
        public delegate void AccountHandler(object sender, AccountEventArgs accountEventArgs);
        public event AccountHandler Notify;
        //public delegate void AccountStateHandler(string mess);
        //AccountStateHandler accountState;
        public int Sum { get; private set; }
        public Account(int sum1)
        {
            Sum = sum1;
            
        }
        public int CurrentSum
        {
            get { return Sum; }
        }
        public void Put(int sum1)
        {
            Sum += sum1;
            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum1}", sum1, 1));
        }
        public void Withdraw(int sum1)
        {
            if (sum1<=Sum)
            {
                Sum -= sum1;
                Notify?.Invoke(this, new AccountEventArgs($"Со счета сняли {sum1}", sum1, 0));
                //accountState?.Invoke($"Сумма {sum1} снята со счета");
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs($"Попытка снятия суммы {sum1}, на счету {CurrentSum}, в операции отказанно", 0, -1));
                //accountState?.Invoke($"Недостаточно денег");
            }
        }
        //public void RegisterHandler(AccountStateHandler accountState1)
        //{
        //    accountState = accountState1;
        //}
    }
}
