using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account(300);
            account.RegisterHandler(new Account.AccountStateHandler(Show_Message));
            //account.RegisterHandler(Show_Message);
            account.Withdraw(100);
            account.Withdraw(150);
            Console.ReadKey();
        }

        private static void Show_Message(string mess)
        {
            Console.WriteLine(mess);
        }
    }
}
