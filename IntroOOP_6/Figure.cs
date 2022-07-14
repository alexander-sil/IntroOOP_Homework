using System;
namespace IntroOOP_6
{
    public class Figure
    {

        // Служебная модель состояния
        #region Utility

        public enum Colors { BLK, RED, BLU, YLW, GRN, PRP, ORG };

        protected Colors _Color;

        protected bool _Visible;

        #endregion


        // Свойства
        #region Properties


        // Опрос состояния (видимое/невидимое)
        public bool Visible
        {
            get
            {
                return _Visible;
            }
            set
            {
                _Visible = value;
            }
        }

        // Цвет
        public Colors Color
        {
            get
            {
                return _Color;
            }
            set
            {
                _Color = value;
            }
        }

        #endregion



        // Конструкторы
        #region Constructors


        public Figure(Colors col, bool vis)
        {
            (_Color, _Visible) = (col, vis);
        }

        public Figure(Colors col)
        {
            (_Color, _Visible) = (col, true);
        }

        public Figure()
        {

            (_Color, _Visible) = (Colors.BLK, true);
        }

        #endregion



        // Виртуальные методы, переопределение в классе Point
        #region Virtual


        // Перемещение
        public virtual void Move(double dx, double dy) { }

        // Перемещение по оси X
        public virtual void MoveX(double dx) { }

        // Перемещение по оси Y
        public virtual void MoveY(double dy) { }

        #endregion



        // Методы обработки
        #region ProcessingMethods


        // Метод обработки перечисления
        protected string ProcessEnum(Colors col)
        {

            switch (col)
            {
                case Colors.BLK:
                    return "черный";
                case Colors.RED:
                    return "красный";
                case Colors.BLU:
                    return "синий";
                case Colors.YLW:
                    return "желтый";
                case Colors.GRN:
                    return "зеленый";
                case Colors.PRP:
                    return "фиолетовый";
                case Colors.ORG:
                    return "оранжевый";
                default:
                    return "не определен";
            }

        }

        #endregion



        // Переопределение методов
        #region Overrides


        // Перевод в строку
        public override string ToString() => $"Фигура\nВидимость: {_Visible}\nЦвет: {ProcessEnum(_Color)}";

        // Равенство по цвету
        public override bool Equals(object obj)
        {

            if (obj.GetType() == typeof(Figure))
            {
                Figure figure = (Figure)obj;
                if (this._Color == figure._Color)
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
        public override int GetHashCode() => (_Color).GetHashCode();

        #endregion

    }
}
