using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*==============================================================
 * 로아 품질 업그레이드 시뮬레이션
 * 
 ==============================================================*/

namespace QualityUpgrade
{
    internal class Program
    {
        // 품질 업그레이드 메뉴창
        static void QualityUpgradeMenu()
        {
            Random rand = new Random();
            int[] prob = new int[101];
            InitProb(prob);
            
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("--------------품질 업그레이드---------------");
                Console.WriteLine("(1) 장비 생성");
                Console.WriteLine("(2) 장비 품질 입력");
                Console.WriteLine("(0) 돌아가기");
                Console.WriteLine("-------------입력 하세요--------------");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        loop = false;
                        Console.Clear();
                        break;
                    case "1":
                        Console.Clear();
                        QualityUpgrade(GetRandomQuality(prob, rand), 0, prob, rand);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("--------------품질 업그레이드---------------");
                        Console.WriteLine("초기 품질을 입력하세요. (0 ~ 100)");
                        string strQuality = Console.ReadLine();
                        int firstQuality = 0;
                        if (int.TryParse(strQuality, out firstQuality))
                            QualityUpgrade(firstQuality, 0, prob, rand);
                        else
                        {
                            Console.WriteLine("입력 오류");
                        }
                        Console.Clear();
                        break;
                }
                Console.Clear();
            }
        }
        // 확률표 초기화
        static void InitProb(int[] prob)
        {
            prob[0] = 2300;
            for (int i = 1; i <= 10; i++)
            {
                prob[i] = 2290;
                prob[i + 10] = 2140;
                prob[i + 20] = 1765;
                prob[i + 30] = 1385;
                prob[i + 40] = 1005;
                prob[i + 50] = 630;
                prob[i + 60] = 255;
                prob[i + 70] = 125;
                prob[i + 80] = 100;
                prob[i + 90] = 75;
            }
        }
        // 품질 업그레이드 창
        static void QualityUpgrade(int quality, int upgradeCount, int[] prob, Random rand)
        {
            if(quality == 100)
            {
                bool loop = true;
                Console.WriteLine("-------------품질 업그레이드 성공--------------");
                Console.WriteLine("장비 품질 : {0}", quality);
                Console.WriteLine("업그레이드 횟수 : {0}", upgradeCount);
                Console.WriteLine("(0) 돌아가기");

                while (loop)
                {
                    if(Console.ReadLine() == "0")
                        loop = false;
                }
            }
            else
            {
                int successPercent = 0;
                for (int i = quality + 1; i <= 100; i++)
                    successPercent += prob[i];
                Console.WriteLine("--------------품질 업그레이드---------------");
                Console.WriteLine("장비 품질 : {0}", quality);
                Console.WriteLine("성공 확률 : {0}%", (float)successPercent / 1000);
                Console.WriteLine("업그레이드 횟수 : {0}", upgradeCount);
                Console.WriteLine("(Enter) 업그레이드");
                Console.WriteLine("(0) 돌아가기");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        int nextQuality = GetRandomQuality(prob, rand);
                        if (nextQuality > quality)
                            Console.WriteLine("성공!!!!!");
                        QualityUpgrade(Math.Max(nextQuality, quality), upgradeCount + 1, prob, rand);
                        break;
                }

            }
        }
        // 랜덤 품질 수치 생성
        static int GetRandomQuality(int[] prob, Random rand)
        {
            int randNum = rand.Next(0, 100000);
            for(int i = 0; i < prob.Length; i++)
            {
                if (prob[i] > randNum)
                    return i;
                else
                    randNum -= prob[i];
            }
            return -1;
        }
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("----------------메 뉴-----------------");
                Console.WriteLine("(1) 품질 업그레이드");
                Console.WriteLine("(0) 나가기");
                Console.WriteLine("-------------입력 하세요--------------");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        loop = false;
                        break;
                    case "1":
                        Console.Clear();
                        QualityUpgradeMenu();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
