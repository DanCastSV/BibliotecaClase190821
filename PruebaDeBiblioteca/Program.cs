using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClase190821;

namespace PruebaDeBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que acción desea realizar");
            Console.WriteLine("1- SortedList");
            Console.WriteLine("2- List");
            var ask = Console.ReadLine();

            if (ask == "1")
            {

                Colection.SortedListCollection();
            
            }
            else
            {

                Colection.ListCollection();
            }




        }
    }
}
