using System;
using System.Collections.Generic;
using System.Linq;


namespace Atm
{
    internal class Program
    {
        private static int TryParseInt32(string text)
        {
            int value;
            return int.TryParse(text, out value) ? value : 0;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of money: ");
            var cash = 0;
            try
            {
                cash = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("This is not an integer!");
                return;
            }
            catch (OverflowException overflowException)
            {
                Console.WriteLine("You entered too many digits!");
                return;
            }

            if (cash < 0)
            {
                Console.WriteLine("Type a positive number!");
                return;
            }
            var array = new[] {2, 3, 4};
            Console.WriteLine("Enter array elements: ");
            var banknote = Console.ReadLine()
                ?.Split(new[] {' '})
                .Select(TryParseInt32)
                .Where(x => x > 0)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();

            /*foreach (var item in banknote)
            {
                Console.WriteLine(item);
            }*/
            
            var atm = new Atm();
            var ans = new List<string>();
            var str = "";
            atm.getAnswer(cash, banknote, banknote.Length - 1, str, ans);
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