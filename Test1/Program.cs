
int[] array = { 3, 10, 28 };
int n = 20;
int result = 100;
int answerIndex = -1;
//

for (int i = 0; i < array.Length; i++)
{
    int diff = Math.Abs(array[i] - n);
    if(diff < result)
    {
        result = diff;
        answerIndex = i;
    }
}

Console.WriteLine(result);
Console.WriteLine(answerIndex);

string str = "asdf";
foreach(var v in str)
{
    Console.WriteLine(v);
}
char aaaa = 'a';
aaaa.ToString();
Console.WriteLine(Convert.ToInt32('2'));
str.Replace("a", "b");
Console.WriteLine(str);