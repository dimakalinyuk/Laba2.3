using System;

namespace Laba2._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть n:\t");
            int n = int.Parse(Console.ReadLine());
            int[] myArr = new int[n];
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = int.Parse(Console.ReadLine());
            }
            int D = Dobutok(myArr);
            int S = Suma(myArr);
            Console.Read();
        }
        static public int Dobutok(int[] myArr)
        {
            int d = 1;
            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] != 0)
                {
                    d *= myArr[i];
                }
            }
            Console.WriteLine("добуток ненульових елементiв масиву:" + d);
            return d;
        }
        static public int Suma(int[] myArr)
        {
            int temp = 0, s = 0;
            for (int i = 0; i < myArr.Length; i++)
                if (myArr[i] < 0)
                {
                    temp = i;
                    break;
                }
            for (int i = temp + 1; i < myArr.Length; i++)
                s += Math.Abs(myArr[i]);
            Console.WriteLine("суму модулiв елементiв масиву,  пiсля першого вiд’ємного елемента:" + s);
            return s;
        }
    }

}
