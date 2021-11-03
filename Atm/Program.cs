using System;
using System.Collections.Generic;

namespace Atm
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of money: ");
            int cash = 0;
            try
            {
                cash = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not an integer!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("You entered too many numbers!");
            }

            if (cash < 0)
            {
                throw new Exception("Type a positive number!");
            }

            Console.WriteLine("Enter array length: ");
            int size = 0;
            try
            {
                size = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not an integer!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("You entered too many numbers!");
            }

            if (size < 0)
            {
                throw new Exception("Type a positive number!");
            }
            
            int[] banknote = new int[size];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < size; i++)
            {
                banknote[i] = 0;
                try
                {
                    banknote[i] = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not an integer!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You entered too many numbers!");
                }
                if (banknote[i] < 0)
                {
                    throw new Exception("Type a positive number!");
                }
            }

            Array.Sort(banknote);
            Atm atm = new Atm();
            List<string> ans = new List<string>();
            string str = "";
            atm.getAnswer(cash, banknote, size - 1, str, ans);
            for (int i = 0; i < ans.Count; i++)
            {
                Console.Write(ans[i]);
                Console.WriteLine("\n");
            }

            Console.Write("{0} -- total number of options!", ans.Count);
            Console.ReadKey();
        }
    }
}