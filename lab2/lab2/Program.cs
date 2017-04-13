using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new DynamicArray(1);
            var arraySizeService = new ArraySizeService();

            arr.SizeChanged += arraySizeService.OnSizeChanged;



            Console.WriteLine("Inital state: ");
            Console.WriteLine("---------------");
            arr.display();
            Console.WriteLine("Default value: -1");
            Console.WriteLine("---------------");


            Console.WriteLine("");

            Console.WriteLine("Add(5): ");
            Console.WriteLine("---------------");
            arr.add(5);
            arr.display();
            Console.WriteLine("---------------");

            Console.WriteLine("");

            Console.WriteLine("arr[2] (index out of bounds): ");
            Console.WriteLine("---------------");
            int test = arr[2];
            Console.WriteLine("---------------");

            Console.WriteLine("");

            Console.WriteLine("Add(7): ");
            Console.WriteLine("---------------");
            arr.add(7);
            arr.display();
            Console.WriteLine("---------------");

            Console.WriteLine("");


            Console.WriteLine("arr[2] = 6: ");
            Console.WriteLine("---------------");
            arr[2] = 6;
            arr.display();
            Console.WriteLine("---------------");

            Console.WriteLine("");

            Console.WriteLine("arr[9] = 16: ");
            Console.WriteLine("---------------");
            arr[9] = 16;
            arr.display();
            Console.WriteLine("---------------");


        

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
