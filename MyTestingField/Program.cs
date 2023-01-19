using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string my_string = "1a2b3c4d123Z";
            int answer = 0;
            int numCount = 0;
            for(int i = my_string.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(my_string[i]))
                {
                    answer += (my_string[i] - 48) * (int)Math.Pow(10, numCount);
                    numCount++;
                }
                else
                    numCount = 0;
            }
            Console.WriteLine(answer);
        }
    }
}
