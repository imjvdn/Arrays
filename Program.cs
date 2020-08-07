using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];


            //friends[0] = "Jim";
            //friends[1] = "Kelly";

            //updating interger
            luckyNumbers[1] = 900;
            luckyNumbers[2] = 3;

            Console.WriteLine(luckyNumbers[2]);

            Console.ReadLine();


        }
    }
}
