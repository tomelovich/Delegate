using System;

namespace _4_Z
{
    public delegate int Number();
    public delegate int MediumCalc(Number[] arrayX);
    class Program
    {
        private static readonly Random rnd = new Random();

        public static int Randomizer()
        {
            return rnd.Next(1, 10);
        }
        static void Main(string[] args)
        {
            Number[] numArr = new Number[5];
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = Randomizer;
                Console.Write(numArr[i].Invoke() + " ");
            }
            Console.WriteLine();


            MediumCalc mediumCalc = delegate (Number[] arrayX)
            {
                int sum = 0;
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sum += arrayX[i]();
                }
                return ((sum) / (arrayX.Length));
            };
            Console.WriteLine(mediumCalc(numArr));
            Console.ReadKey();
        }
    }
}