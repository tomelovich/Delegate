using System;

namespace _2_Z
{
    class Program
    {
        public delegate int MyDelegat(int a, int b);
        static void Main()
        {
            Console.WriteLine("Введите действие--> +,-,*,/");
            string a = Console.ReadLine();
            Console.WriteLine("Первое число -->");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число -->");
            int y = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (a)
                {
                    case "+":
                        MyDelegat add = (c, b) => c + b;
                        int del = add(x, y);
                        Console.WriteLine("Ответ:{0}", del);
                        break;
                    case "-":
                        MyDelegat sub = (c, b) => c - b;
                        int del1 = sub(x, y);
                        Console.WriteLine("Ответ:{0}", del1);
                        break;
                    case "*":
                        MyDelegat mul = (c, b) => c * b;
                        int del2 = mul(x, y);
                        Console.WriteLine("Ответ:{0}", del2);
                        break;
                    case "/":
                        MyDelegat div = (c, b) => b == 0 ? 0 : c / b;
                        int del3 = div(x, y);
                        if (del3 == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        else
                            Console.WriteLine("Ответ:{0}", del3);
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
            }             
        }
    }
}
