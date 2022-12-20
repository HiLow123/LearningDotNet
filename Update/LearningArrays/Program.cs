using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bikes = {"Connondale", "Colnago", "Bianchi", "Cervelo", "Orbea"};
            foreach  (string i in bikes)
            {
                Console.WriteLine(i);
            }

            int[] Numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Array.Reverse(Numbers);
            foreach (int value in Numbers)
            {
                Console.Write(value + " ");

            }
        }      
        
    }
}