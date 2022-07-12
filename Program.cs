using System;

namespace IntroOOP_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();

            Console.WriteLine("Выполнение завершено");            
            Console.ReadKey(true);
        }

        static void Run()
        {
            // 1/1
            Fract add = new Fract(1, 2) + new Fract(1, 2);
            Console.WriteLine(add.ToString());

            // 1/2
            Fract sub = new Fract(1, 1) - new Fract(1, 2);
            Console.WriteLine(sub.ToString());

            // 1/1
            Fract mul = new Fract(1, 2) * new Fract(2, 1);
            Console.WriteLine(mul.ToString());

            // 2/1
            Fract div = new Fract(4, 1) / new Fract(2/1);
            Console.WriteLine(div.ToString());

            // 2/2
            Fract inc = new Fract(1, 1);
            inc++;
            Console.WriteLine(inc.ToString());

            // 1/1
            Fract dec = new Fract(2, 2);
            dec--;
            Console.WriteLine(dec.ToString());

            // 1/1
            Fract mod = new Fract(5, 1) % new Fract(2, 1);
            Console.WriteLine(mod.ToString());

            // True
            bool equ = new Fract(42, 21) == new Fract(84, 42);
            Console.WriteLine(equ);

            // False
            bool inq = new Fract(24, 12) != new Fract(12, 6);
            Console.WriteLine(inq);

            // True
            bool lth = new Fract(2, 4) < new Fract(4, 1);
            Console.WriteLine(lth);

            // False
            bool gth = new Fract(2, 4) > new Fract(4, 1);
            Console.WriteLine(gth);

            // False
            bool ltq = new Fract(5, 6) <= new Fract(4, 5);
            Console.WriteLine(ltq);

            // True
            bool gtq = new Fract(5, 6) >= new Fract(4, 5);
            Console.WriteLine(gtq);

            // 2
            Console.WriteLine((int)(new Fract(2, 1)));

            // 5
            Console.WriteLine((float)(new Fract(5, 1)));

            // 5/2
            Console.WriteLine(((Fract)2.5f).ToString());




        }
    }
}
