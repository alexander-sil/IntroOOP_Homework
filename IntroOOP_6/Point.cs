using System;

namespace IntroOOP_6
{
    public class Point : Figure
    {

        // Поля
        #region Fields

        protected double _X;

        protected double _Y;

        #endregion


        // Свойства
        #region Properties 


        // Расположение по оси X
        public double X
        {
            get
            {
                return _X;
            }
            set
            {
                _X = value;
            }
        }

        // Расположение по оси Y
        public double Y
        {
            get
            {
                return _Y;
            }
            set
            {
                _Y = value;
            }

        }

        #endregion



        // Конструкторы
        #region Constructors


        public Point(Colors col, bool vis, double x, double y)
        {
            (_Color, _Visible, _X, _Y) = (col, vis, x, y);
        }

        public Point(Colors col, bool vis)
        {
            (_Color, _Visible, _X, _Y) = (col, vis, 0.0, 0.0);
        }

        public Point(Colors col)
        {
            (_Color, _Visible, _X, _Y) = (col, true, 0.0, 0.0);
        }

        public Point()
        {
            (_Color, _Visible, _X, _Y) = (Colors.BLK, true, 0.0, 0.0);
        }

        #endregion



        // Переопределение методов (геометрия)
        #region GeometryOverrides


        // Перемещение относительно текущих координат
        public override void Move(double dx, double dy)
        {
            _X += dx;
            _Y += dy;
        }

        // Перемещение по оси X
        public override void MoveX(double dx) => _X += dx;

        // Перемещение По оси Y
        public override void MoveY(double dy) => _Y += dy;

        #endregion



        // Переопределение стандартных методов
        #region StandardOverrides


        // Перевод в строку
        public override string ToString() => $"Точка\nX: {_X}\nY: {_Y}\nВидимость: {_Visible}\nЦвет: {ProcessEnum(_Color)}";

        // Сравнение по цвету
        public override bool Equals(object obj)
        {

            if (obj.GetType() == typeof(Point))
            {
                Point point = (Point)obj;
                if (this._Color == point._Color)
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
        public override int GetHashCode() => (_Color, _X, _Y).GetHashCode();

        #endregion

    }
}

