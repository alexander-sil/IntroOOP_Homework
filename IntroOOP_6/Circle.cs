using System;
namespace IntroOOP_6
{
    public class Circle : Point
    {


        // Поля
        #region Fields

        private const double _PI = 3.141592;

        private double _Area;

        private double _Radius;

        #endregion


        // Свойства
        #region Properties


        // Получение и установка площади окружности
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

        // Получение и установка радиуса окружности
        public double Radius
        {
            get
            {
                return _Radius;
            }
            set
            {
                _Radius = value;
            }
        }

        #endregion



        // Вычисление площади реализовано сразу в конструкторах
        #region Constructors


        public Circle(double radius, Colors col, bool vis, double x, double y)
        {
            (_Radius, _Color, _Visible, _X, _Y) = (radius, col, vis, x, y); _Area = _PI * (_Radius * _Radius);
        }

        public Circle(double radius, Colors col, bool vis)
        {
            (_Radius, _Color, _Visible, _X, _Y) = (radius, col, vis, 0.0, 0.0); _Area = _PI * (_Radius * _Radius);
        }

        public Circle(double radius, Colors col)
        {
            (_Radius, _Color, _Visible, _X, _Y) = (radius, col, true, 0.0, 0.0); _Area = _PI * (_Radius * _Radius);
        }

        public Circle(Colors col)
        {
            (_Radius, _Color, _Visible, _X, _Y) = (50.0, col, true, 0.0, 0.0); _Area = _PI * (_Radius * _Radius);
        }

        public Circle()
        {
            (_Radius, Color, _Visible, _X, _Y) = (50.0, Colors.BLK, true, 0.0, 0.0); _Area = _PI * (_Radius * _Radius);
        }

        #endregion



        // Переопределение методов
        #region Overrides


        // Перевод в строку
        public override string ToString() => $"Окружность\nX: {_X}\nY: {_Y}\nВидимость: {_Visible}\nЦвет: {ProcessEnum(_Color)}\nРадиус: {_Radius}\nПлощадь: {_Area}";

        // Сравнение по цвету и площади
        public override bool Equals(object obj)
        {

            if (obj.GetType() == typeof(Circle))
            {
                Circle circle = (Circle)obj;
                if (this._Color == circle._Color && this.Area == circle.Area)
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
        public override int GetHashCode() => (_Radius, _Color, _X, _Y).GetHashCode();

        #endregion

    }
}
