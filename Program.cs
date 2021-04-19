using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();
            library.LName = "Полоцкая городская";
            library.LAddress = "ул. Пушкина, д. Колотушкина";
            library.LYear = 1982;

            Console.WriteLine($"{library.LName}  {library.LAddress}  {library.LYear}");
            Console.ReadKey();
        }
    }
}
