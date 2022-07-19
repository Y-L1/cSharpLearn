using System;

namespace _004_字符类型
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'c';
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //String str = Console.ReadLine();
            //Console.WriteLine(str + "-");
            //1、类型一致 2、右边的值所需的容器大小小于等于左边的容器
            //int a = Console.ReadLine();



            String str = Console.ReadLine();
            int strInt = Convert.ToInt32(str);
            Console.WriteLine(strInt + "_");

        }
    }
}
