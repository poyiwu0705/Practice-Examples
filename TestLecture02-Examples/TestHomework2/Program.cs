using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHomework2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon();

            Console.Write("請輸入Pokemon Name: ");
            pokemon1.Name = Console.ReadLine();

            Console.Write("請輸入National No: ");
            pokemon1.NationalNo = int.Parse(Console.ReadLine()); //要做防呆

            Console.Write("請輸入Type: ");
            pokemon1.Type = Console.ReadLine();

            Console.Write("請輸入Species: ");
            pokemon1.Species = Console.ReadLine();

            Console.Write("請輸入Height: ");
            pokemon1.Height = float.Parse(Console.ReadLine());  //要做防呆

            Console.Write("請輸入Weight: ");
            pokemon1.Weight = float.Parse(Console.ReadLine());  //要做防呆

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

            Console.WriteLine("您輸入的資料如下: ");
            Console.WriteLine("Pokemon Name : {0}", pokemon1.Name);
            Console.WriteLine(" National No : {0}", pokemon1.NationalNo);
            Console.WriteLine("        Type : {0}", pokemon1.Type);
            Console.WriteLine("     Species : {0}", pokemon1.Species);
            Console.WriteLine("      Height : {0}", pokemon1.Height);
            Console.WriteLine("      Weight : {0}", pokemon1.Weight);
            Console.WriteLine("  Abilities1 : {0}", pokemon1.Abilities1);
            Console.WriteLine("  Abilities2 : {0}", pokemon1.Abilities2);
            Console.WriteLine("    LocalNo1 : {0}", pokemon1.LocalNo1);
            Console.WriteLine("    LocalNo2 : {0}", pokemon1.LocalNo2);
            Console.WriteLine("    LocalNo3 : {0}", pokemon1.LocalNo3);
            Console.WriteLine("    LocalNo4 : {0}", pokemon1.LocalNo4);
            Console.WriteLine("    Japanese : {0}", pokemon1.Japanese);
        }
    }
}