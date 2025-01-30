using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pokergame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int [] card = new int[4];
            int count;
            int a;

            for (; ; )
            {
                count = 0;
                a = 0;

                for(int i = 0; i < 4; i++)
                {
                    card[i] = rnd.Next(1,13); // 1～13までの整数をランダムで代入
                }

                foreach (int i in card)
                {
                    
                    a++;
                    Console.Write($"{a}枚目 :");
                    
                    Console.WriteLine($"[{i}]");
                    Thread.Sleep(1000);


                }

                Console.WriteLine();

                //役判定
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (card[i] == card[j])
                        {
                            count++;
                        }
                    }
                }

                //Console.WriteLine("{0}",count);

                switch (count)
                {
                    case 4:
                        Console.WriteLine("----------\nノーペア\n----------");
                        break;
                    case 6:
                        Console.WriteLine("----------\nワンペア\n----------");
                        break;
                    case 8:
                        Console.WriteLine("----------\nツーペア\n----------");
                        break;
                    case 10:
                        Console.WriteLine("----------\nスリーカード\n----------");
                        break;
                    case 16:
                        Console.WriteLine("----------\nフォーカード\n----------");
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
                        Console.Clear();
                        break;
                    }
                }

            }

        }
    }
}
