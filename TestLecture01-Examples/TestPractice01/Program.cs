using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = "Bulbasaur";
            int nationalNo = 1;
            string type = "Grass,Poison";
            string species = "Seed Pokémon";
            float height = 0.71f;
            float weight = 6.9f;
            string abilities1 = "Overgrow";
            string abilities2 = "Chlorophyll (hidden ability)";
            string localNo1 = "001(Red/Blue/Yellow/FireRed/LeafGreen)";
            string localNo2 = "226(Gold/Silver/Crystal)";
            string localNo3 = "231(HeartGold/SoulSilver)";
            string localNo4 = "080(X/Y)";
            string japanese = "Fushigidane";
            Console.WriteLine("Pokemon Name : {0}", name);
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