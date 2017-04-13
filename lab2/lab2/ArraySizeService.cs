using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class ArraySizeService
    {
        public void OnSizeChanged(object source, DynamicArrayArgs e)
        {
            Console.WriteLine("EVENT => New array size is : " + e.size);
        }
    }
}
