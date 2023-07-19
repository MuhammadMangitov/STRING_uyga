using System;
using System.Text;

namespace method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KattaSoz = "";
            Console.Write("Satr kiritng -> ");
            string str = Console.ReadLine();
            string[] str1 = str.Split(' ', '`');
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i].Length > KattaSoz.Length)
                {
                    KattaSoz = str1[i];
                }
                else
                {
                    str1[i] = KattaSoz;
                }
            }
            Console.WriteLine($"Satrda eng katta soz -> {KattaSoz}");
        }
    }
}
