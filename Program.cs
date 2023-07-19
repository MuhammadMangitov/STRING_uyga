using System;
using System.Text;

namespace method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countUnli = 0;
            int countUndosh = 0;
            int countUmumiy = 0;
            Console.Write("Satr kiritng -> ");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122))
                {
                    countUmumiy++;
                    if (str[i] == 'a' || str[i] == 'A' ||
                        str[i] == 'o' || str[i] == 'O' ||
                        str[i] == 'i' || str[i] == 'I' ||
                        str[i] == 'u' || str[i] == 'U' ||
                        str[i] == 'e' || str[i] == 'E')
                    {
                        countUnli++;
                    }
                    else
                    {
                        countUndosh++;
                    }
                }
                else
                {
                    countUmumiy = 0;
                }
            }
            Console.WriteLine($"\"{str}\" so`zida {countUndosh} ta undow va {countUnli} ta unli bor");
        }
    }
}
