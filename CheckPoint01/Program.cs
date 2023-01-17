using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

// ============================================================================================
// CheckPoint01 - 숫자 달리기 게임
//      숫자들이 경주를 하는 경마 게임
//      기본 1칸씩 움직이고 확률에 따라 2칸씩 움직임.
//  - TRACKLENGTH : 경주하는 트랙의 길이
//  - USERCOUNT : 경주하는 숫자의 갯수
//  - RND_NUM : 경주할 때 숫자가 2칸 이동할 확률의 역수. (ex. 3일경우 2칸 이동할 확률은 1/3)
//  - DELAY_TIME : 경주가 진행되는 속도 -> Sleep(DELAY_TIME);
// ============================================================================================


namespace CheckPoint01
{
    internal class Program
    {
        const int RND_NUM = 3;

        const int TRACK_LENGTH = 50;
        const int USER_COUNT = 5;
        const int DELAY_TIME = 100;

        static int[] locations = new int[USER_COUNT];

        static void PrintTrack()
        {
            Console.WriteLine(new string('-', TRACK_LENGTH + 1));
            for (int i = 0; i < USER_COUNT; i++)
            {
                string track = new string(' ', locations[i]);
                track += (i + 1).ToString();
                if (locations[i] < TRACK_LENGTH)
                    track += new string(' ', TRACK_LENGTH - locations[i] - 1);
                track += '|';
                Console.WriteLine(track);
            }
            Console.WriteLine(new string('-', TRACK_LENGTH + 1));
        }
        static void RandomRun()
        {
            Random rnd = new Random();

            for (int i = 0; i < USER_COUNT; i++)
            {
                if (rnd.Next(0, RND_NUM) == 0)
                    locations[i] += 2;
                else
                    locations[i]++;
            }
        }
        static bool ProcessResult()
        {
            if (locations.Max() >= TRACK_LENGTH)
            {
                int maxLength = locations.Max();
                for (int i = 0; i < USER_COUNT; i++)
                {
                    if (locations[i] == maxLength)
                        Console.WriteLine("결과 : !!{0}번 선수 우승!!", i + 1);
                }

                Console.Write("다시 하려면 0번, 끝내려면 아무키나 누르세요.");
                if (Console.ReadLine() == "0")
                {
                    locations = new int[USER_COUNT];
                    System.Console.Clear();
                    return true;
                }
                else
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            while(true)
            {
                PrintTrack();

                if (locations.Sum() == 0)
                {
                    Console.WriteLine("준비! (시작하려면 엔터를 입력하세요.)");
                    Console.ReadLine();
                }

                if (!ProcessResult())
                    break;

                RandomRun();

                Thread.Sleep(DELAY_TIME);
                System.Console.Clear();
            }
        }
    }
}
