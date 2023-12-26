using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Utils
    {
        public int GetNumber()
        {
            int number;
            string? word = Console.ReadLine();

            while (int.TryParse(word, out number) == false)
            {
                Console.WriteLine("Ошибка, введите число:  ");
                word = Console.ReadLine();
            }

            return number;
        }
    }
}
