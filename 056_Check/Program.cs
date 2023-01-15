using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer = rnd.Next(1, 100);
            int tryNum = 1;
            while (true)
            {
                Console.Write("1~99사이 어떤 숫자일까용(단, 0은 나가기)");
                string strUserInput = Console.ReadLine();
                if(int.TryParse(strUserInput, out int userInput))
                {
                    if (userInput == 0)
                        break;
                    else if(userInput > answer)
                    {
                        Console.WriteLine("그거보다 작아요");
                        tryNum++;
                    }
                    else if(userInput < answer)
                    {
                        Console.WriteLine("그거보다 커요");
                        tryNum++;
                    }
                    else if(userInput == answer)
                    {
                        Console.WriteLine("=== 정답 입니다. ==");
                        Console.WriteLine($"총 {tryNum}번 시도");
                        break;
                    }    
                }
                else
                {
                    Console.WriteLine("정수를 입력해주세요.");
                }

            }
        }
    }
}
