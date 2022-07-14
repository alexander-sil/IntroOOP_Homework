using System;
namespace IntroOOP_6
{
    public class Rectangle : Point
    {
        // Поля
        #region Fields

        private double _Area;

        private double _Width;

        private double _Height;

        #endregion


        // Свойства
        #region Properties


        // Получение и установка площади прямоугольника
        public double Area
        {
            get
            {
                return _Area;
            }
            set
            {
                _Area = value;
            }
        }

        // Получение и установка ширины
        public double Width
        {
            get
            {
                return _Width;
            }
            set
            {
                _Width = value;
            }
        }

        // Получение и установка высоты
        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                _Height = value;
            }
        }

        #endregion



        // Вычисление площади реализовано сразу в конструкторах
        #region Constructors


        public Rectangle(double w, double h, Colors col, bool vis, double x, double y)
        {
            (_Width, _Height, _Color, _Visible, _X, _Y) = (w, h, col, vis, x, y); _Area = _Height * _Width;
        }

        public Rectangle(double w, double h, Colors col, bool vis)
        {
            (_Width, _Height, _Color, _Visible, _X, _Y) = (w, h, col, vis, 0.0, 0.0); _Area = _Height * _Width;
        }

        public Rectangle(double w, double h, Colors col)
        {
            (_Width, _Height, _Color, _Visible, _X, _Y) = (w, h, col, true, 0.0, 0.0); _Area = _Height * _Width;
        }

        public Rectangle(Colors col)
        {
            (_Width, _Height, _Color, _Visible, _X, _Y) = (80.0, 45.0, col, true, 0.0, 0.0); _Area = _Height * _Width;
        }

        public Rectangle()
        {
            (_Width, _Height, Color, _Visible, _X, _Y) = (80.0, 45.0, Colors.BLK, true, 0.0, 0.0); _Area = _Height * _Width;
        }

        #endregion



        // Переопределение методов
        #region Overrides


        // Перевод в строку
        public override string ToString() => $"Прямоугольник\nX: {_X}\nY: {_Y}\nВидимость: {_Visible}\nЦвет: {ProcessEnum(_Color)}\nШирина: {_Width}\nВысота: {_Height}\nПлощадь: {_Area}";

        // Сравнение по цвету и площади
        public override bool Equals(object obj)
        {

            if (obj.GetType() == typeof(Rectangle))
            {
                Rectangle Rectangle = (Rectangle)obj;
                if (this._Color == Rectangle._Color && this.Area == Rectangle.Area)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }

        }

        // Хеш-код
        public override int GetHashCode() => (_Width, _Height, _Color, _X, _Y).GetHashCode();

        #endregion

    }
}
