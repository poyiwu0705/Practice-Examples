using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int age = null;  左邊是不行的，他會說無法將null 轉換成'int'，因為她是不可以為null的實質類型
            int? age = null;
        }
    }
}