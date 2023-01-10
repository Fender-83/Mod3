using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анкета
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t   Анкета   ");
            Console.WriteLine();
            Console.WriteLine("Здравствуйте, как вас зовут?");
            string name = (Console.ReadLine());
            Console.WriteLine("Сколько вам лет?");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваша дата рождения?");
            var birthday = Console.ReadLine();
            Console.WriteLine("Вас зовут {0}, вам {1} лет и вы родились {2},", name, age, birthday);

            Console.ReadKey();

        }
    }
}
