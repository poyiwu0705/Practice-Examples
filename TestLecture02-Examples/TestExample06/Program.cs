using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.Write("請輸入要幾個數字");                           //左邊程式都沒有加上防呆，記得加上去
            //int count = int.Parse(Console.ReadLine());                //沒辦法在C語言或是C++上跑，因為陣列的個數是你輸入後才確定的
            //int[] numbers = new int[count];                           //這個叫做動態產生長度的陣列，因為我們還沒學迴圈所以沒辦法動態

            //int[] numbers = new int[100];
            //numbers[0] = int.Parse(Console.ReadLine());                //這個雖然爛，可是還可以手KEY
            //numbers[1] = int.Parse(Console.ReadLine());
            //numbers[2] = int.Parse(Console.ReadLine());
            //numbers[3] = int.Parse(Console.ReadLine());
            //numbers[4] = int.Parse(Console.ReadLine());
            //numbers[5] = int.Parse(Console.ReadLine());
            //numbers[6] = int.Parse(Console.ReadLine());
            //numbers[7] = int.Parse(Console.ReadLine());
            //numbers[8] = int.Parse(Console.ReadLine());
            //numbers[9] = int.Parse(Console.ReadLine());
            //.....
            //numbers[99] = int.Parse(Console.ReadLine());

            int[] numbers;                                             //這個更爛，因為數字還是寫死的，上面還可以用手KEY

            numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(numbers[10]);

            //for (int index = 0; index < numbers.Length; index++)     //上面那一部分不正常，正常應該像左邊那樣寫
            //    numbers[index] = int.Parse(Console.ReadLine());
        }
    }
}