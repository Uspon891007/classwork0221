using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> cardinalitys = new List<int>();
            List<int> evens = new List<int>();
            //string cardinality = "";
            //string even = "";
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串");
            string input = Console.ReadLine();
            string[] inputs = input.Split(',');
            int[] output = inputs.Select(int.Parse).ToArray();
            for(int i = 0; i < output.Length; i++)
            {
                if (output[i]%2!=0)
                {
                    cardinalitys.Add(output[i]);
                }
                else if (output[i]%2==0)
                {
                    evens.Add(output[i]);
                }
            }
            
            var order1 = cardinalitys.OrderBy(x => x);
            var order2 = evens.OrderBy(x => x);
            Console.WriteLine("基數:");
            foreach(var item in order1)
            {
                if(item != order1.Last()) 
                { 
                    Console.Write(item+",");
                }
                else if(item == order1.Last())
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("偶數:");
            foreach (var item in order2)
            {
                if (item != order2.Last())
                {
                    Console.Write(item + ",");
                }
                else if (item == order2.Last())
                {
                    Console.WriteLine(item);
                }
            }




        }
    }
}
