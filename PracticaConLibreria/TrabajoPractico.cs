using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConLibreria
{
    public class TrabajoPractico
    {
        public static void SortedListCollection()
        {
            /*
             * ejercicio hacer una lista que permita agregar 
             * datos del tipo string  y despues los 
             * muestre
             * 
             */
            //definimos la cantidad de elemntos a ingr
            Console.Write("Cuantos datos desea ingresar");
            var elementos = Convert.ToInt32(Console.ReadLine());

            //definimos los arrays vacios 
            string[] key = new string[elementos];
            string[] value = new string[elementos];

            SortedList<string, string> srtList = new SortedList<string, string>();
            int i = 0;
            while (i < elementos)
            {
                Console.WriteLine("Escriba los a datos a ingresar {0}: ", i);

                Console.Write("ingrese el nombre de la persona: ");
                key[i] = Console.ReadLine();
                Console.Write("ingrese el apellido de la persona: ");
                value[i] = Console.ReadLine();

                srtList.Add(key[i], value[i]);

                i++;
            }
            Console.WriteLine("************************Nombres ingresados************************");
            foreach (KeyValuePair<string, string> element in srtList)
            {
                Console.WriteLine("{0} {1}", element.Key, element.Value);


            }
        }




    }
}
