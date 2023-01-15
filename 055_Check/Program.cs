using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int count = 5;
            int score = 0;
            Random rnd = new Random();

            for(int i = 1; i <= count; i++)
            {
                Console.WriteLine("{0}: 다음 두 수의 합은 몇?(총 {1}문제)",i, count);
                int firstNum = rnd.Next(1, 100);
                int secondNum = rnd.Next(1, 100);
                int answer = firstNum + secondNum;
                Console.WriteLine("{0} + {1} = ??",firstNum, secondNum);
                string userAnswer = Console.ReadLine();
                if(userAnswer == answer.ToString())
                {
                    Console.WriteLine("== 정답 ==");
                    score++;
                }
                else
                {
                    Console.WriteLine($"오답(정답은: {answer})");
                }
            }
            Console.WriteLine($"{score}문제 맞춤!");
        }
    }
}
