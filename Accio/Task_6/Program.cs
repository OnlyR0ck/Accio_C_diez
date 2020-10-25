using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HelperLibrary;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicitly initialize your function in an array.
            var delegates = new Menu.MenuDelegate[]{FindUniqueWords};

            Menu.StartMenu(delegates);
        }

        static void FindUniqueWords()
        {
            List<string> notUnique;
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
    }
}
