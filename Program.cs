using System;
using System.Text;

namespace method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "";
            string s2 = "";
            Console.Write("Ism familya otangizni ismini kiritng -> ");
            string satr = Console.ReadLine();
            string[] strings = satr.Split();
            s1 += strings[0].Substring(0, 1);
            s2 += strings[1].Substring(0, 1);
            Console.WriteLine($"{s1}.{s2}.{strings[2]} {strings[3]}");
        }
    }
}