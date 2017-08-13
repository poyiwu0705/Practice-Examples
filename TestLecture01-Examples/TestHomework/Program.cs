using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHomework
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.Write("請輸入帳號:");
            //string userName = Console.ReadLine();
            //Console.Write("請輸入密碼");
            //string userPassword = Console.ReadLine();
            //Console.WriteLine("{0}, 登入成功!", userName);

            Console.Write("請輸入Pokemon Name: ");
            string pokemonName = Console.ReadLine();

            Console.Write("請輸入National No: ");
            string nationalNo = Console.ReadLine();

            Console.Write("請輸入Type: ");
            string type = Console.ReadLine();

            Console.Write("請輸入Species: ");
            string species = Console.ReadLine();

            Console.Write("請輸入Height: ");
            string height = Console.ReadLine();

            Console.Write("請輸入Weight: ");
            string weight = Console.ReadLine();

            Console.Write("請輸入Abilities1: ");
            string abilities1 = Console.ReadLine();

            Console.Write("請輸入Abilities2: ");
            string abilities2 = Console.ReadLine();

            Console.Write("請輸入Local No1: ");
            string localNo1 = Console.ReadLine();

            Console.Write("請輸入Local No2: ");
            string localNo2 = Console.ReadLine();

            Console.Write("請輸入Local No3: ");
            string localNo3 = Console.ReadLine();

            Console.Write("請輸入Local No4: ");
            string localNo4 = Console.ReadLine();

            Console.Write("請輸入Japanese: ");
            string japanese = Console.ReadLine();

            Console.WriteLine("您輸入的資料如下: ");
            Console.WriteLine("Pokemon Name : {0}", pokemonName);
            Console.WriteLine(" National No : {0}", nationalNo);
            Console.WriteLine("        Type : {0}", type);
            Console.WriteLine("     Species : {0}", species);
            Console.WriteLine("      Height : {0}", height);
            Console.WriteLine("      Weight : {0}", weight);
            Console.WriteLine("  Abilities1 : {0}", abilities1);
            Console.WriteLine("  Abilities2 : {0}", abilities2);
            Console.WriteLine("    LocalNo1 : {0}", localNo1);
            Console.WriteLine("    LocalNo2 : {0}", localNo2);
            Console.WriteLine("    LocalNo3 : {0}", localNo3);
            Console.WriteLine("    LocalNo4 : {0}", localNo4);
            Console.WriteLine("    Japanese : {0}", japanese);
        }
    }
}