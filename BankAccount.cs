namespace IntroOOP_3;

public class BankAccount
{
	// Тип счета: не определен, валютный, брокерский, накопительный, замороженный
	public enum EnumAccountTypes { UDFD, CURR, BROK, SVNG, FRZN };
	private EnumAccountTypes atype;
	
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
	public EnumAccountTypes GetAccType()
	{
		return atype;
	}
	
	// Установка типа счета
        public void SetAccType(EnumAccountTypes acctype)
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
	
	public EnumAccountTypes AccountType
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
			} else
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
		atype = EnumAccountTypes.UDFD;
		m_balance = 0.00M;
		ul_randomAccountNum = RandomAccNum();
		ul_accountNumber = ul_randomAccountNum;
	}
	
	// Конструктор с заполнением поля баланс
        public BankAccount(decimal balance)
	{
		atype = EnumAccountTypes.UDFD;
		m_balance = balance;
		ul_randomAccountNum = RandomAccNum();
		ul_accountNumber = ul_randomAccountNum;
	}
	
	// Конструктор с заполнением поля тип счета
	public BankAccount(EnumAccountTypes actype)
	{
		atype = actype;
		m_balance = 0.00M;
		ul_randomAccountNum = RandomAccNum();
		ul_accountNumber = ul_randomAccountNum;
	}
	
	// Конструктор с заполнением обоих полей
        public BankAccount(decimal balance, EnumAccountTypes actype)
	{
		atype = actype;
		m_balance = balance;
		ul_randomAccountNum = RandomAccNum();
		ul_accountNumber = ul_randomAccountNum;
	}
	
	// Служебный метод
	public string ProcessEnumValue(EnumAccountTypes enumtype)
	{
		switch (enumtype)
		{
			case EnumAccountTypes.UDFD:
				return "Не определен";
				break;
			case EnumAccountTypes.CURR:
				return "Валютный";
				break;
			case EnumAccountTypes.BROK:
				return "Брокерский";
				break;
			case EnumAccountTypes.SVNG:
				return "Накопительный";
				break;
			case EnumAccountTypes.FRZN:
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
