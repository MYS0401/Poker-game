using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokergame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            for (int i = 0; i < 4; i++)
            {
                for (; ; )
                {
                    Console.Write($"{i + 1}枚目のカードの数値を入力 > ");
                    bool result = int.TryParse(Console.ReadLine(), out num);

                    if(result == false || num >4 || num <1)
                    {
                        Console.WriteLine("使用できない値です");
                    }
                    else
                    {
                        break;
                    }

                }

               
            }


            Console.ReadLine();
        }
    }
}
