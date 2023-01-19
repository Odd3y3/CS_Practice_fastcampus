using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _075_Check
{
    internal class Program
    {
        static void InputID(int[] ID, int index)
        {
            Console.Write("학생 ID를 입력하세요?  ");
            ID[index] = int.Parse(Console.ReadLine());
        }
        static void InputKor(int[] kor, int index)
        {
            Console.Write("국어 점수를 입력하세요?  ");
            kor[index] = int.Parse(Console.ReadLine());
        }
        static void InputMath(int[] math, int index)
        {
            Console.Write("수학 점수를 입력하세요?  ");
            math[index] = int.Parse(Console.ReadLine());
        }
        static void InputEng(int[] eng, int index)
        {
            Console.Write("영어 점수를 입력하세요?  ");
            eng[index] = int.Parse(Console.ReadLine());
        }
        static void PrintID(int max, int[] ID)
        {
            for(int i = 0; i < max; i++)
            {
                Console.WriteLine("학생 ID: {0}", ID[i]);
            }
        }
        static int CheckID(int id, int max, int[] ID)
        {
            if (id == 0)
                return -2;
            else
            {
                for(int i = 0; i < max; i++)
                {
                    if (ID[i] == id)
                        return i;
                }
                return -1;
            }
        }
        static void PrintResult(int index, int[] kor, int[] mat, int[] eng)
        {
            int scoreKor = kor[index];
            int scoreMat = mat[index];
            int scoreEng = eng[index];
            Console.WriteLine($"국어 점수: {scoreKor}");
            Console.WriteLine($"수학 점수: {scoreMat}");
            Console.WriteLine($"영어 점수: {scoreEng}");
            int total = scoreKor + scoreEng + scoreMat;
            Console.WriteLine("총점: {0}", total);
            Console.WriteLine("평균: {0}", total / 3.0f);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            const int STUDENT_COUNT = 3;

            int[] studentID = new int[STUDENT_COUNT];
            int[] studentKor = new int[STUDENT_COUNT];
            int[] studentMat = new int[STUDENT_COUNT];
            int[] studentEng = new int[STUDENT_COUNT];
            for(int i = 0; i < STUDENT_COUNT; i++)
            {
                InputID(studentID, i);
                InputKor(studentKor, i);
                InputMath(studentMat, i);
                InputEng(studentEng, i);
                Console.WriteLine();
            }

            while (true)
            {
                PrintID(STUDENT_COUNT, studentID);

                Console.Write("학생 아이디를 입력하세요? (0) 나가기 ");
                int input = int.Parse(Console.ReadLine());
                int index = CheckID(input, STUDENT_COUNT, studentID);
                if (index == -2)
                    break;
                else if(index == -1)
                {
                    Console.WriteLine("학생 아이디가 없어요. 다시 입력하세요");
                }
                else
                {
                    PrintResult(index, studentKor, studentMat, studentEng);
                }

            }

        }
    }
}
