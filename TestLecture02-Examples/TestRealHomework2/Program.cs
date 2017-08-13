using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRealHomework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon();

            Console.Write("請輸入Pokemon Name: ");
            pokemon1.Name = Console.ReadLine();

            Console.Write("請輸入Pokemon National NO: ");
            try
            {
                pokemon1.NationalNo = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("National No: 輸入錯誤");
                return;
            }

            Console.Write("請輸入Type: ");
            pokemon1.Type = Console.ReadLine();

            Console.Write("請輸入Species: ");
            pokemon1.Species = Console.ReadLine();

            Console.Write("請輸入Height: ");
            try
            {
                pokemon1.Height = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Height: 輸入錯誤");
                return;
            }

            Console.Write("請輸入Weight: ");
            try
            {
                pokemon1.Weight = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Weight: 輸入錯誤");
                return;
            }

            Console.Write("請輸入Abilities1: ");
            pokemon1.Abilities1 = Console.ReadLine();

            Console.Write("請輸入Abilities2: ");
            pokemon1.Abilities2 = Console.ReadLine();

            Console.Write("請輸入Local No1: ");
            pokemon1.LocalNo1 = Console.ReadLine();

            Console.Write("請輸入Local No2: ");
            pokemon1.LocalNo2 = Console.ReadLine();

            Console.Write("請輸入Local No3: ");
            pokemon1.LocalNo3 = Console.ReadLine();

            Console.Write("請輸入Local No4: ");
            pokemon1.LocalNo4 = Console.ReadLine();

            Console.Write("請輸入Japanese: ");
            pokemon1.Japanese = Console.ReadLine();

            Console.WriteLine("您輸入的Pokemon資料如下:");

            Console.WriteLine(" Pokemon Name: {0}", pokemon1.Name);
            Console.WriteLine("  National NO: {0}", pokemon1.NationalNo);
            Console.WriteLine("         Type: {0}", pokemon1.Type);
            Console.WriteLine("       Height: {0}", pokemon1.Height);
            Console.WriteLine("       Weight: {0}", pokemon1.Weight);
            Console.WriteLine("Abilities No1: {0}", pokemon1.Abilities1);
            Console.WriteLine("Abilities No2: {0}", pokemon1.Abilities2);
            Console.WriteLine("    Local No1: {0}", pokemon1.LocalNo1);
            Console.WriteLine("    local No2: {0}", pokemon1.LocalNo2);
            Console.WriteLine("    Local No3: {0}", pokemon1.LocalNo3);
            Console.WriteLine("    Local No4: {0}", pokemon1.LocalNo4);
            Console.WriteLine("     Japanese: {0}", pokemon1.Japanese);
        }
    }
}