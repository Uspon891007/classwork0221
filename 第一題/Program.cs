using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputs = "";
            Console.WriteLine("請輸入一串以逗號分隔的字串，並將其反向顯示");
            string input = Console.ReadLine();
            Console.WriteLine($"輸入:{input}");
            List<string> output = input.Split(',').ToList();
            output.Reverse();

            for(int i = 0; i < output.Count; i++)
            {
                outputs+= output[i]+',';
            }
            outputs = outputs.Substring(0, outputs.Length - 1);
            Console.WriteLine($"輸出:{outputs}");
            

        }
    }
}
