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
            //以下為SQL查詢語言  在字串前面打@，字串可以換行
            string sql =
            @"
            select*FormatException table
            where id > 10
            ";
            Console.WriteLine(sql);

            //以下為SQL查詢語言  在字串前面打@，字串可以換行(但是字串也是會依照位置不會自行前移)
            string sql2 =
            @"
select*FormatException table
where id > 10
            ";
            Console.WriteLine(sql2);

            //"\" 反斜線(跳脫字元)是有別的意義的，不能直接打反斜線
            string pathFirst = "C:\\";
            Console.WriteLine(pathFirst);

            string pathSecond = @"D:\C# 程式設計基礎-20170807T014732Z-001";
            Console.WriteLine(pathSecond);
        }
    }
}