using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int studentsCount = 5;
            int[] scores = new int[studentsCount];
            for(int i = 0; i < studentsCount; i++)
            {
                Console.Write("학생의 성적을 입력하세요: ");
                string strScore = Console.ReadLine();
                if(!int.TryParse(strScore, out scores[i]))
                {
                    Console.WriteLine("입력 에러. 다시 입력해주세요.");
                    i--;
                    continue;
                }
            }
            Console.WriteLine("최대값: {0}     최소값:  {1}",scores.Max(), scores.Min());
        }
    }
}
