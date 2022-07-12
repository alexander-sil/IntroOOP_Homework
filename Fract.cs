using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntroOOP_5
{
    public sealed class Fract
    {

        
        private int _Num;
        private int _Den;

        // Свойства. Для использования только за пределами класса
        public int Num { get { return _Num; } }
        public int Den { get { return _Den; } }

        
        public Fract(int num, int den)
        {
            if (den == 0) { throw new DivideByZeroException(); }
            _Num = num; _Den = den;
        }

        public Fract(int num)
        {
            _Num = num;
            _Den = 1;
        }

        // Сделал short чтобы не было ошибки
        public Fract(short den)
        {
            if (den == 0) { throw new DivideByZeroException(); }
            _Num = 1;
            _Den = (int)den;
        }

        public Fract()
        {
            Random random = new Random();
            _Num = random.Next(1, int.MaxValue);
            Thread.Sleep(100);
            _Den = random.Next(1, int.MaxValue);
        }



       
        public Fract ReduceFraction()
        {
            Fract f = this;
            int m = 0;
            if (f._Num > f._Den)
            {
                m = f._Den;
            }
            else
            {
                m = f._Num;
            }
            int i = m;
            while (i >= 2)
            {
                if (f._Num % i == 0)
                {
                    if (f._Den % i == 0)
                        f._Num /= i;
                        f._Den /= i;
                }
                i--;

            }

            return f;
        }

        
        private static void Denominator(Fract f1, Fract f2)
        {

            f1._Num *= f2._Den; f2._Num *= f1._Den;
            f1._Den *= f2._Den; f2._Den = f1._Den;
        }

        private static Fract Reverse(Fract f)
        {
            int a, b;
            a = f.Den;
            b = f.Num;

            return new Fract(a, b);
        }

        private static Fract Remainder(Fract f1, Fract f2)
        {
            Denominator(f1, f2);
            while (f1._Num >= f2._Num)
            {
                f1._Num -= f2._Num;
            }
            
            return new Fract(f1._Num, f1._Den);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

       
        public bool Equals(Fract f)
        {
            Denominator(this, f);

            if (this._Num == f._Num && this._Den == f._Den)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return object.ReferenceEquals(this, obj);
        }

        public override string ToString()
        {
            return $"{this._Num}/{this._Den}";
        }

        public static implicit operator float(Fract f)
        {
            return f.Num / f.Den;
        }

       
        public static implicit operator int(Fract f)
        {
            return f.Num / f.Den;
        }
        public static explicit operator Fract(float fl)
        {
            if (fl <= 0.0f)
                throw new InvalidOperationException();
            string fractionString = fl.ToString();
            string[] fractionArray = fractionString.Split('.');
            uint intpart = uint.Parse(fractionArray[0]);



            if (fractionArray.Length >= 2)
            {
                if (fractionArray[1] == "0")
                    return new Fract((int)intpart, 1);

                uint numpart = uint.Parse(fractionArray[1]);
                uint denpart = 1;
                int i = 0;
                while (i < numpart.ToString().Length)
                {
                    denpart = denpart * 10;
                    i++;
                }
                uint x = 0;
                if (numpart > denpart)
                {
                    x = denpart;
                }
                else
                {
                   x = numpart;
                }
                uint ii = x;
                while (ii >= 2)
                {
                    if (numpart % ii == 0)
                    {
                        if (denpart % ii == 0)
                            numpart /= ii;
                            denpart /= ii;
                    }
                    ii--;

                }
                return new Fract((int)(intpart * denpart + numpart), (int)denpart);
            }
            else
            {
                return new Fract((int)intpart, 1);

            }
        }
        
        public static Fract operator +(Fract f1, Fract f2)
        {
            Denominator(f1, f2);
            int a = f1._Num + f2._Num;
            return new Fract(a, f2._Den).ReduceFraction();

        }

        public static Fract operator -(Fract f1, Fract f2)
        {
            Denominator(f1, f2);
            int a = f1._Num - f2._Num;
            return new Fract(a, f2._Den).ReduceFraction();

        }

        public static Fract operator ++(Fract f)
        {
            int num = f._Num += 1;
            int den = f._Den += 1;
            return new Fract(num, den);
        }

        public static Fract operator --(Fract f)
        {
            int num = f._Num -= 1;
            int den = f._Den -= 1;
            return new Fract(num, den);
        }

        public static Fract operator *(Fract f1, Fract f2)
        {
            return (new Fract(f1._Num * f2._Num, f1._Den * f2._Den)).ReduceFraction();
        }

        public static Fract operator /(Fract f1, Fract f2)
        {

            Fract f3 = Reverse(f2);
            return (f1 * f3).ReduceFraction();
        }

        public static Fract operator %(Fract f1, Fract f2)
        {
            return Remainder(f1, f2).ReduceFraction();
        }

        public static bool operator ==(Fract f1, Fract f2)
        {
            Denominator(f1, f2);
            if (f1._Num == f2._Num)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator !=(Fract f1, Fract f2)
        {
            Denominator(f1, f2);
            if (f1._Num == f2._Num)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator <(Fract f1, Fract f2)
        {
            Denominator(f1, f2);
            if (f1._Den == f2._Den)
            {
                if (f1._Num > f2._Num)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (f1._Num == f2._Num)
            {
                if (f1._Den < f2._Den)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {

                if (f1._Den < f2._Den)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool operator >(Fract f1, Fract f2)
        {
            Denominator(f1, f2);
            if (f1._Den == f2._Den)
            {
                if (f1._Num > f2._Num)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (f1._Num == f2._Num)
            {
                if (f1._Den < f2._Den)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                
                if (f1._Den < f2._Den)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool operator <=(Fract f1, Fract f2)
        {
            Denominator(f1, f2);
            if (f1._Den == f2._Den)
            {
                if (f1._Num >= f2._Num)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (f1._Num == f2._Num)
            {
                if (f1._Den <= f2._Den)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                
                if (f1._Den <= f2._Den)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }


        public static bool operator >=(Fract f1, Fract f2)
        {
            Denominator(f1, f2);
            if (f1._Den == f2._Den)
            {
                if (f1._Num >= f2._Num)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (f1._Num == f2._Num)
            {
                if (f1._Den <= f2._Den)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                
                if (f1._Den <= f2._Den)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

