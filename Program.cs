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
            int [] num = new int[4];
            int count;

            for(; ; )
            {
                count = 0;

                for (int i = 0; i < 4; i++)
                {
                    for (; ; )
                    {
                        Console.Write($"{i + 1}枚目のカードの数値を入力 > ");
                        bool result = int.TryParse(Console.ReadLine(), out num[i]);

                        if (result == false || num[i] > 13 || num[i] < 1)
                        {
                            Console.WriteLine("使用できない値です");
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                foreach (int i in num)
                {
                    Console.Write("{");
                    Console.Write($"{i}");
                    Console.Write("}");
                }

                //役判定
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (num[i] == num[j])
                        {
                            count++;
                        }
                    }
                }

                //Console.WriteLine("{0}",count);

                switch (count)
                {
                    case 4:
                        Console.WriteLine("ノーペア");
                        break;
                    case 6:
                        Console.WriteLine("ワンペア");
                        break;
                    case 8:
                        Console.WriteLine("ツーペア");
                        break;
                    case 10:
                        Console.WriteLine("スリーカード");
                        break;
                    case 16:
                        Console.WriteLine("フォーカード");
                        break;
                }

                for (; ; )
                {
                    Console.WriteLine("ゲームを終了しますか 終了: 0 もう一度 :1");
                    bool result = int.TryParse(Console.ReadLine(), out int date);

                    if (result == false || date != 1 && date != 0)
                    {
                        Console.WriteLine("使用できない値です");
                    }
                    else if(date == 0)
                    {
                        return;
                    }
                    else
                    {
                        break;
                    }
                }

            }

        }
    }
}
