using System;
using System.Collections;

namespace ArrayLIST
{
    class Program
    {
        static void Main(string[] args)
        {
            // Supports any type of data type
            ArrayList arr = new ArrayList()
            {
                123, "ieieiei", 56, 'A'
            };
            arr.Add("ff");

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
