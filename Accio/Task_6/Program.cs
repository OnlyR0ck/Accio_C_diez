using System;


using System.Text.RegularExpressions;
using HelperLibrary;

namespace Task_6
{
    class Program
    {
        
        static void Main()
        {
            //Explicitly initialize your function in an array.
            var delegates = new Menu.MenuDelegate[] {FindUniqueWords, Client};
           
            Menu.StartMenu(delegates);
        }
        
        static void FindUniqueWords()

        {
            // List<string> notUnique;
            Console.Write("Enter string: ");
            var yourStr = Console.ReadLine();
            var newStr = Regex.Replace(yourStr, "[-.?!)(,:]", "");
            var strArr = newStr.Split(" ");
            Console.Write("Unique words: ");
            for (int i = 0; i < strArr.Length; i++)
            {
                var flag = true;
                for (int j = 0; j < strArr.Length; j++)
                {
                    if (i == j && j != strArr.Length - 1) j++;
                    if (strArr[i].Equals(strArr[j]))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag) Console.Write($"{strArr[i]}, ");
            }
        }
         static int sum = 1000;
        static void Client()
        {
            
            int money;
            int kode = 0;
            Bank bank = new Bank();
            bank.Client += SendSms;
            bank.Client += MyInfo;
            Console.WriteLine($"Cash {sum} Card balance {bank.Info()}");
            while (kode != 1)
            {
               Console.WriteLine("Exit: 1\nAdd money: 2\nTake money: 3");
               kode = Convert.ToInt32(Console.ReadLine());
               switch (kode)
               {
                   case 2:
                       Console.WriteLine("How much money do you want to put on the card?");
                       money = Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine();
                       if (money <= sum)
                       {
                           sum -= money;
                           bank.Add(money);
                       }

                       break;
                   case 3:
                       Console.WriteLine("How much money do you want to withdraw from the card?");
                       money = Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine();
                       bank.Take(money);
                       break;
               }
               Console.WriteLine();
            }
        }

        static void SendSms(string message)
        {
            if (message != null)
            {
                long number = 375297777777;
                Console.WriteLine($"SMS arrive to {number:+###-##-###-##-##}");
                //Proshodit otravka :D
            }
        }

        
        static void MyInfo(string massge)
        {
            if(massge!= null) Console.WriteLine($"Your balance {Convert.ToInt32(massge):C}\nYour cash {sum:C}");
        }


    }


    class Bank
    {
         public int Sum;
         public delegate void BankOperation(string massage);
         public event BankOperation Client;

         public int Info()
         {
             return Sum;
         }

         public void Add(int sum)
         {
             Sum += sum;
             Client?.Invoke($"{sum}");
         }

         public void Take(int sum)
        {
            if (sum <= Sum)
            {
                Sum -= sum;
                Client?.Invoke($"{sum}");
            }
            else
            {
                Console.WriteLine("You haven't money");
            }
        }
    }
}

