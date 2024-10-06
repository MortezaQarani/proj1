using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public static void Add(int input1, int input2)
        {
            Console.WriteLine(input1 + input2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter num1:");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("please enter num2:");
            int num2=int.Parse(Console.ReadLine());
            Add(input1: num1, input2: num2);

        }
    }
}
