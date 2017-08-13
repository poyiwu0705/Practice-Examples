using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int nationalNo = Console.ReadLine(); 左邊的是不成立的，因為輸入的是數字，所以不能將 nationalNo定義成數字
            //dynamic nationalNo = Console.ReadLine(); 這句可以，但是這個型態不好做運算，很容易出錯
            Console.WriteLine("請輸入整數數字(沒有防呆)");
            int nationalNo = int.Parse(Console.ReadLine());

            string s = "100.3";
            float a = float.Parse(s);
            Console.WriteLine(a);

            //string text = 1000;   左邊的程式也不行，數字是不能變成文字的，所以要用int
            int b = 1000;
            string text = b.ToString();//重要，很常用到，尤其是在視窗上面，因為視窗顯示的是文字，可是我們又需要它可以運算
            Console.WriteLine(b);

            Console.Write("請輸入National No1:(沒有防呆)");
            int nationalNo1 = int.Parse(Console.ReadLine());   //第一種寫法這行有風險，如果輸入非數字，程式會當掉  下面兩個就是抓漏
            Console.WriteLine("National No1: {0}", nationalNo1);

            Console.Write("請輸入National No2:(有防呆，用Try.Parse)");
            int nationalNo2 = -1;
            int.TryParse(Console.ReadLine(), out nationalNo2);  //第二種寫法輸入正確就會回傳代替掉nationalNo2,輸入錯誤就會用int的設數字0代替
            Console.WriteLine("National No2: {0}", nationalNo2);

            Console.Write("請輸入National No3:(有防呆，完整Try Catch)");
            int nationalNo3 = -1;
            //int.TryParse(Console.ReadLine(), out nationalNo2);
            try                                                //試著
            {
                nationalNo2 = int.Parse(Console.ReadLine());   //試著轉換成數字，轉成功就沒問題
            }
            catch                                              //假如沒成功被Catch到Error
            {
                Console.WriteLine("輸入錯誤");
                return;                                        //執行到return，return代表終止
            }
            Console.WriteLine("National No3: {0}", nationalNo3);

            Console.Write("請輸入National No4:(有防呆，完整Try Catch)");
            int nationalNo4 = -1;
            try                                                //試著
            {
                nationalNo4 = int.Parse(Console.ReadLine());   //試著轉換成數字，轉成功就沒問題
            }
            catch                                              //假如沒成功被Catch到Error
            {
                Console.WriteLine("輸入錯誤");
                return;                                        //執行到return，return代表終止
            }

            Console.Write("請輸入Hight(有防呆，完整Try Catch)");
            float hight = 0.0f;
            try                                                //試著
            {
                hight = int.Parse(Console.ReadLine());         //試著轉換成數字，轉成功就沒問題
            }
            catch                                              //假如沒成功被Catch到Error
            {
                Console.WriteLine("輸入錯誤");
                return;                                        //執行到return，return代表終止
            }
            Console.WriteLine("National No4: {0}", nationalNo3);
            Console.WriteLine("Hight: {0}", hight);
        }
    }
}