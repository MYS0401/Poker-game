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
            Random rnd = new Random();
            int [] card = new int[4];
            int count;

            for(; ; )
            {
                count = 0;

                for(int i = 0; i < 4; i++)
                {
                    card[i] = rnd.Next(1,13); // 1～13までの整数をランダムで代入
                }

                foreach (int i in card)
                {
                    Console.Write("{");
                    Console.Write($"{i}");
                    Console.Write("}");
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
