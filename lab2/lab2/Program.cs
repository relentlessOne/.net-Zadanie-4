using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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


            Thread blockAdd = new Thread(() => {

                
                while (true)
                {
                    Thread.Sleep(500);
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    arr.CreateAddBlock(2);
                    sw.Stop();
                    Console.WriteLine("Blocking thread successfully added an element ");
                    Console.WriteLine( "Blocking thread has been waiting for " + sw.ElapsedMilliseconds + "ms");
                }
            });

            Thread nonBlockAdd = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(500);
                    if (arr.CreateAddNonBlock(3))
                    {
                        Console.WriteLine("Non-blocking thread successfully added an element ");
                    }
                    else
                    {
                        Console.WriteLine("Non-blocking thread cannot add an element ");
                    }
                }
            });


            blockAdd.Start();
            nonBlockAdd.Start();


            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
