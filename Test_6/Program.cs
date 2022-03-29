using System;

namespace Test_6
{
    class Program
    {
        // 6. 반복문을 이용하여 아래 별을 출력하세요
        // *   *   (별ㅁㅁㅁ별)
        //  * *    (ㅁ별ㅁ별)
        //   *      (ㅁㅁ별)
        //  * *    (ㅁ별ㅁ별)
        // *   *   (별ㅁㅁㅁ별)

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j || (i + j == 4))
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }            
        }
    }
}
