using System;
using System.Data;
using System.IO;
using System.Linq;

namespace AdventOfCodeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Chris\source\repos\AdventOfCodeDay1\AdventOfCodeDay1\Day1Input.csv";
            var list = File.ReadAllLines(path);
            var intList = list.Select(i => int.Parse(i)).ToList();
            int larger = 0;
            int larger2 = 0;
           
            for (var i = 1; i < intList.Count(); i++)
            {
                if(intList[i-1] < intList[i])
                {
                    larger++;
                }
            }

            Console.WriteLine(larger);

            for(var i = 0; i < intList.Count()-3; i++)
            {
                if((intList[i] + intList[i+1] + intList[i+2]) < (intList[i+1] +intList[i+2] + intList[i + 3]))
                {
                    larger2++;
                }
            }

            Console.WriteLine(larger2);
        }
    }
}
