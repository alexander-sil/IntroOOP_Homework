using System;
using System.Text;

namespace IntroOOP_6
{

    public class BankAccount
    {
        // Тип счета: не определен, валютный, брокерский, накопительный, замороженный
        public enum EnumAccountTypes { UDFD, CURR, BROK, SVNG, FRZN };
        private EnumAccountTypes _AccountType;

        // Баланс
        private decimal _Balance;

        // Номер счета
        private ulong _AccountNumber;

        // Случайный номер счета
        private static ulong ul_randomAccountNum;


        // Внимание: Аксессоры-методы удалены в целях уменьшения количества неиспользуемого кода


        // Свойства получения и установки значений полей
        public decimal Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                _Balance = value;
            }
        }

        public ulong AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
            set
            {
                _AccountNumber = value;
            }
        }

        public EnumAccountTypes AccountType
        {
            get
            {
                return _AccountType;
            }
            set
            {
                _AccountType = value;
            }
        }

        // Метод пополнения
        public void TopUp(decimal money)
        {
            _Balance += money;
        }

        // Метод снятия
        public decimal Cash(decimal funds)
        {
            if (_Balance < funds)
            {
                return 0.00M;
            }
            else
            {
                decimal oldbl = _Balance;
                _Balance -= funds;
                return oldbl - funds;
            }
        }

        // Классы являются ссылочными типами, ref не нужен
        public bool Transfer(BankAccount source, decimal amount)
        {
            try
            {
                if (source.Balance > amount)
                {
                    decimal oldBalance = source.Balance;
                    decimal B = oldBalance - amount;
                    source.Balance -= amount;
                    this.Balance = amount;
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        // Конструктор по умолчанию
        public BankAccount()
        {
            _AccountType = EnumAccountTypes.UDFD;
            _Balance = 0.00M;
            ul_randomAccountNum = RandomAccNum();
            _AccountNumber = ul_randomAccountNum;
        }

        // Конструктор с заполнением поля баланс
        public BankAccount(decimal balance)
        {
            _AccountType = EnumAccountTypes.UDFD;
            _Balance = balance;
            ul_randomAccountNum = RandomAccNum();
            _AccountNumber = ul_randomAccountNum;
        }

        // Конструктор с заполнением поля тип счета
        public BankAccount(EnumAccountTypes actype)
        {
            _AccountType = actype;
            _Balance = 0.00M;
            ul_randomAccountNum = RandomAccNum();
            _AccountNumber = ul_randomAccountNum;
        }

        // Конструктор с заполнением обоих полей
        public BankAccount(decimal balance, EnumAccountTypes actype)
        {
            _AccountType = actype;
            _Balance = balance;
            ul_randomAccountNum = RandomAccNum();
            _AccountNumber = ul_randomAccountNum;
        }

        // Служебный метод
        public static string ProcessEnumValue(EnumAccountTypes enumtype)
        {
            return enumtype switch
            {
                EnumAccountTypes.UDFD => "Не определен",
                EnumAccountTypes.CURR => "Валютный",
                EnumAccountTypes.BROK => "Брокерский",
                EnumAccountTypes.SVNG => "Накопительный",
                EnumAccountTypes.FRZN => "Заморожен",
                _ => "",
            };
        }

        // Получение случайного номера счета
        private static ulong RandomAccNum()
        {
            Random r = new Random();
            byte[] b = new byte[sizeof(ulong)];
            r.NextBytes(b);
            ulong res = BitConverter.ToUInt64(b, 0);
            return res;
        }


        public override int GetHashCode() => (this._Balance, this._AccountNumber, this._AccountType).GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(BankAccount))
            {
                BankAccount acc = (BankAccount)obj;
                if (acc._Balance == this._Balance && acc._AccountType == this._AccountType)
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
                return false;
            }
        }

        public override string ToString() => $"Номер счета: {_AccountNumber}\nБаланс: {_Balance}\nТип счета: {ProcessEnumValue(_AccountType)}";

        public static bool operator ==(BankAccount a, BankAccount b)
        {


            if (a._Balance == b._Balance && a._AccountType == b._AccountType)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        public static bool operator !=(BankAccount a, BankAccount b)
        {
            if (a._Balance != b._Balance && a._AccountType != b._AccountType)
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

