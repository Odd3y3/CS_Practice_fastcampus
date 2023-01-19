using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _076_Check
{
    internal class Program
    {
        const int MAX_SIZE = 10;
        static int[] firstNum = new int[MAX_SIZE];
        static int[] secondNum = new int[MAX_SIZE];
        static int[] resultNum = new int[MAX_SIZE];

        static int InputNumber(int count)
        {
            Console.Write("첫번째 수를 입력 해 주세요 ");
            int first = int.Parse(Console.ReadLine());
            firstNum[count] = first;
            Console.Write("두번째 수를 입력 해 주세요 ");
            int second = int.Parse(Console.ReadLine());
            secondNum[count] = second;
            return first + second;
        }
        static void PrintResult(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        static bool CheckEnd()
        {
            Console.Write("추가로 계산할까요?(1: OK, 0: NO, 단 총 10번까지 가능)");
            string input = Console.ReadLine();
            if (input == "1")
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 0; i < MAX_SIZE; i++)
            {
                resultNum[i] = InputNumber(i);
                PrintResult(firstNum[i], secondNum[i]);
                count++;
                if (CheckEnd())
                    break;
            }
            for(int i = 0; i < count; i++)
            {
                PrintResult(firstNum[i], secondNum[i]);
            }
        }
    }
}
