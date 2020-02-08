using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account(200);
            account.Notify += Account_Notify;
            //account.RegisterHandler(new Account.AccountStateHandler(Show_Message));
            //account.RegisterHandler(Show_Message);
            account.Put(100);
            account.Withdraw(100);
            account.Withdraw(150);
            account.Withdraw(150);
            Console.ReadKey();
        }

        private static void Account_Notify(object sender, AccountEventArgs accountEventArgs)
        {
            switch (accountEventArgs.OperationCode)
            {
                case 0:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Транзакция на сумму {accountEventArgs.Sum}");
                        Console.WriteLine(accountEventArgs.Message);
                        break;
                    }
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Транзакция на сумму {accountEventArgs.Sum}");
                        Console.WriteLine(accountEventArgs.Message);
                        break;
                    }
                case -1:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Транзакция на сумму {accountEventArgs.Sum}");
                        Console.WriteLine(accountEventArgs.Message);
                        break;
                    }
            }
                
           
        }

        //private static void Show_Message(string mess)
        //{
        //    Console.WriteLine(mess);
        //}
    }
}
