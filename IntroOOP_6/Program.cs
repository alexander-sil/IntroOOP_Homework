using System;

namespace IntroOOP_6
{
    class Program
    {

        static void Main(string[] args)
        {

            // Тестовый пример

            #region example

            BankAccount acc1 = new BankAccount();
            BankAccount acc2 = new BankAccount();
            BankAccount acc3 = acc2;

            Console.WriteLine(acc1.GetHashCode());
            Console.WriteLine(acc2.GetHashCode());
            Console.WriteLine(acc3 == acc2);
            Console.WriteLine(acc1.ToString());

            Console.WriteLine("---------");

            Figure fig1 = new Figure(Figure.Colors.GRN);
            Figure fig2 = fig1;

            Console.WriteLine(fig1.GetHashCode());
            Console.WriteLine(fig2.GetHashCode());
            Console.WriteLine(fig1.ToString());

            Console.WriteLine("---------");

            Point pnt1 = new Point(Figure.Colors.BLU, true);
            Point pnt2 = new Point(Figure.Colors.BLU, false);

            Console.WriteLine(pnt1.Equals(pnt2));

            pnt1.Move(-50.0, -50.0);
            pnt2.MoveX(100.0);
            pnt2.MoveY(200.0);

            Console.WriteLine(pnt1.ToString());
            Console.WriteLine(pnt2.ToString());

            Circle crc1 = new Circle(16.0, Figure.Colors.RED, true, 250.0, 300.0);
            Circle crc2 = new Circle(16.0, Figure.Colors.RED, true, 250.0, 250.0);

            Console.WriteLine("---------");

            Console.WriteLine(crc1.Equals(crc2));
            Console.WriteLine(crc1.ToString());
            Console.WriteLine(crc2.ToString());

            crc1.Move(-100, -200);

            Console.WriteLine("---------");

            Console.WriteLine(crc1.ToString());


            Rectangle rct1 = new Rectangle(100, 50, Figure.Colors.PRP, true, -600, -500);
            Rectangle rct2 = new Rectangle(100, 50, Figure.Colors.PRP, true, -600, -600);

            Console.WriteLine("---------");

            Console.WriteLine(rct1.Equals(rct2));
            Console.WriteLine(rct1.ToString());

            #endregion

        }
    }
}
