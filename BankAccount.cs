namespace IntroOOP_1;
public class BankAccount
{
	// Тип счета: не определен, валютный, брокерский, накопительный, замороженный
	public enum enum_accountTypes { UDFD, CURR, BROK, SVNG, FRZN };
	private enum_accountTypes atype;
	// Баланс
	private decimal m_balance;
	// Номер счета
	private ulong ul_accountNumber;
	// Случайный номер счета
	private static ulong ul_randomAccountNum;
	// Получение номера счета
	public ulong GetAccNum()
	{
		return ul_accountNumber;
	}
	// Установка номера счета
	public void SetAccNum(ulong accnum)
	{
		ul_accountNumber = accnum;
	}
	// Получение номера счета
	public decimal GetBalance()
	{
		return m_balance;
	}
	// Установка номера счета
	public void SetBalance(decimal balance)
	{
		m_balance = balance;
	}
    // Получение типа счета
	public enum_accountTypes GetAccType()
	{
		return atype;
	}
	// Установка типа счета
    public void SetAccType(enum_accountTypes acctype)
	{
		atype = acctype;
	}
	// Свойства получения и установки значений полей
	public decimal Balance
	{
		get
		{
			return m_balance;
		}
		set
		{
			m_balance = value;
		}
	}
	public ulong AccountNumber
	{
		get
		{
			return ul_accountNumber;
		}
		set
		{
			ul_accountNumber = value;
		}
	}
	public enum_accountTypes AccountType
	{
		get
		{
			return atype;
		}
		set
		{
			atype = value;
		}
	}
	// Метод пополнения
	public void TopUp(decimal money)
	{
		m_balance += money;
	}
	// Метод снятия
    public decimal Cash(decimal funds)
	{
		if (m_balance < funds) {
			return 0.00M;
		} else {
			decimal oldbl = m_balance;
			m_balance -= funds;
			return oldbl - funds;
		}
	}
	// Конструктор по умолчанию
	public BankAccount()
	{
		atype = enum_accountTypes.UDFD;
		m_balance = 0.00M;
		ul_randomAccountNum = RandomAccNum();
		ul_accountNumber = ul_randomAccountNum;
	}
	// Конструктор с заполнением поля баланс
    public BankAccount(decimal balance)
	{
		atype = enum_accountTypes.UDFD;
		m_balance = balance;
		ul_randomAccountNum = RandomAccNum();
		ul_accountNumber = ul_randomAccountNum;
	}
	// Конструктор с заполнением поля тип счета
	public BankAccount(enum_accountTypes actype)
	{
		atype = actype;
		m_balance = 0.00M;
		ul_randomAccountNum = RandomAccNum();
		ul_accountNumber = ul_randomAccountNum;
	}
	// Конструктор с заполнением обоих полей
    public BankAccount(decimal balance, enum_accountTypes actype)
	{
		atype = actype;
		m_balance = balance;
		ul_randomAccountNum = RandomAccNum();
		ul_accountNumber = ul_randomAccountNum;
	}
	// Служебный метод
	public string ProcessEnumValue(enum_accountTypes enumtype)
	{
		switch (enumtype)
		{
			case enum_accountTypes.UDFD:
				return "Не определен";
				break;
			case enum_accountTypes.CURR:
				return "Валютный";
				break;
			case enum_accountTypes.BROK:
				return "Брокерский";
				break;
			case enum_accountTypes.SVNG:
				return "Накопительный";
				break;
			case enum_accountTypes.FRZN:
				return "Заморожен";
				break;
			default:
				return "";
				break;
		}
	}
	// Получение случайного номера счета
	private ulong RandomAccNum()
	{
		Random r = new Random();
        byte[] b = new byte[sizeof (ulong)];
        r.NextBytes(b);
        ulong res = BitConverter.ToUInt64(b, 0);
		return res;
	}
	// Вывод данных счета
	public void PrintInfo()
	{
		Console.WriteLine("Номер счета: {0}", ul_accountNumber);
		Console.WriteLine("Баланс: {0:C2}", m_balance);
		Console.WriteLine("Тип счета: {0}", ProcessEnumValue(atype));
	}
}