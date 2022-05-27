using System;

namespace _3_Z
{
    class Program
    {
        public delegate string Dels(string a);
        public static string kolich(string a)
        {
            string[] textArray = a.Split(new char[] { ' ', '.', ',' });          
            Console.WriteLine("Кол-во слов в строке= {0}",textArray.Length);
            return a;
        }
        public static string lower(string a)
        {
            a = a.ToLower();
            Console.WriteLine("Результат метода lower - {0}",a);
            return a;
        }
        public static string replaces(string a)
        {
            a = a.Replace("o", "A");
            Console.WriteLine("Результат метода replaces - {0}",a);
            return a;
        }
        static void Main(string[] args)
        {
            Dels CF = new Dels(lower);
            Console.WriteLine("Введите строку");
            string a = Console.ReadLine();
            CF += replaces;
            CF += kolich;
            CF(a); 
        }
    }
}
