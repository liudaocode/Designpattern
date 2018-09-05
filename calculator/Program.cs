using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入第一个数");
                double numA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入操作符");
                string operate = Console.ReadLine();
                Console.WriteLine("请输入第二个数");
                double numB = Convert.ToDouble(Console.ReadLine());
                Operation oper = OperationFactory.CreateOperate(operate);
                oper.NumberA = numA;
                oper.NumberB = numB;
                Console.WriteLine(oper.GetResult());
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }
    }
}
