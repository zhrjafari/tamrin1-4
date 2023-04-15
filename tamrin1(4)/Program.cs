using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace project
{
    class test1
    {
        public static void Main()
        {
            Console.WriteLine("enter the box numbers");
            int l = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());
            int v = Calc(l, h, w);
            Console.WriteLine("v = "+v);
        }//end main

        private static int Calc(int l, int h, int w)
        {
            return l * h * w;
        }
    }
}