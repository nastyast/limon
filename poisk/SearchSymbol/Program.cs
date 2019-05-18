using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchSymbol
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            {
                int k = 0;
                Console.Write("Введите строку: ");
                string a = Console.ReadLine();
                Console.Write("Введите символ: ");
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                for (int i = 0; i < a.Length; i++)
                {
                    //if (a[i] == c)
                    {
                        //Console.Write(i + " ");
                        k++;
                    }
                }
                Console.WriteLine("Количество повторений заданного символа: " + k);
                Console.ReadKey();
            }


        }
    }
}
 
