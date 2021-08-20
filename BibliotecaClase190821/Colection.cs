using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClase190821
{
    public class Colection
    {
        public static void ListCollection()
        {
            List<object> lst = new List<object>();

            var rs = "s";
            while (rs == "s")
            {
                Console.Write("escriba el elemento a agregar: ");
                var element = Console.ReadLine();

                Console.Write("Desea agregar otro elemento a la lista: s/n");
                rs = Console.ReadLine();

            }
            Console.WriteLine("Elementos de la lista");
            for(int i = 0; i< lst.Count; i++ )
            {

                Console.WriteLine("Elemento {0}: {1}", 1, lst[i]);
            
            
            }

        }
        public static void SortedListCollection()
        {

            Console.Write("Cuantos elementos desea ingresar: ");
            var elements = Convert.ToInt32(Console.ReadLine());

            object[] key = new object[elements];
            object[] value = new object[elements];

            SortedList<object, object> srtList = new SortedList<object, object>();
            int i = 0;

            while (i < elements)
            {
                Console.WriteLine("escriba el elemento a agregar {0}", i);

                Console.Write("key: ");
                key[i] = Console.ReadLine();
                Console.Write("value: ");
                value[i] = Console.ReadLine();
                srtList.Add(key[i], value[i]);

                i++;
            }

            Console.WriteLine("*************Elementos en la lista************");
            foreach (KeyValuePair<object, object> element in srtList)
            {
                Console.WriteLine("{0}: {1}", element.Key, element.Value);
            }
        }


    }
}
