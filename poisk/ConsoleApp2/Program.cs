using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SearchSymbol
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Введите строку: ");
            string a = Console.ReadLine();
            Console.Write("Введите символ: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int k = poisk(a, c);
            Console.WriteLine("Количество повторений заданного символа: " + k);

            Console.ReadKey();
        }

        public static int poisk(string a, char c)
        {
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == c)
                {

                    k++;
                }
            }

            return k;
        }
     
    }

}
