using System;
using System.Text;

namespace method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int kop = 1;
            char qaysiHarf = ' ';
            // aaacccccaavd --> c 5 marta;
            Console.Write("Satr kiriting -> ");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    count++;
                    if (count > kop)
                    {
                        kop = count;
                        qaysiHarf = str[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(qaysiHarf + " --> " + kop);
        }
    }
}