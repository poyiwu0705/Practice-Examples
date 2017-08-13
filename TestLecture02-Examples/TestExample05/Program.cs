using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int pokemon1NationalNo = 1;                   原本假如要寫兩隻的寫法
            //string pokemonName = "妙蛙種子";

            //int pokemon2NationalNo = 2;
            //string pokemon2Name = "妙蛙草";

            //pokemon1.NationNo = 1;
            //pokemon1.Name = "妙蛙種子";

            //pokemon2.NationalNo = 2;
            //pokemon2.Name = "妙蛙草";

            //int ntionalNo = 1;
            //string name = "妙蛙種子";

            Pokemon 妙蛙種子 = new Pokemon(); //Pokemon 是類別名稱 妙蛙種子是變數名稱?應該也不是變數，或許算是一個物件 //我有一隻寶可夢叫妙蛙種子=一隻新的寶可夢             //應該是寶可夢是一個類別，妙蛙種子是這個類別裡面的新類別(名稱)

            妙蛙種子.NationalNo = 1;           //NationalNo 變數
            妙蛙種子.Name = "Bulbasaur";       //Name       變數

            Console.WriteLine("建立第一隻寶可夢");

            Pokemon pokemon1 = new Pokemon();
            pokemon1.NationalNo = int.Parse(Console.ReadLine());
            pokemon1.Name = Console.ReadLine();

            Console.WriteLine("建立第二隻寶可夢");

            Pokemon pokemon2 = new Pokemon();
            pokemon2.NationalNo = int.Parse(Console.ReadLine());
            pokemon2.Name = Console.ReadLine();
        }
    }
}