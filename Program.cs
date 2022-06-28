namespace IntroOOP_1;
class Program
{
	static void Main(string[] args)
	{
		TestMethod();
		Console.WriteLine("\n\nВыполнение завершено.");
		Console.ReadKey(true);
	}
	// Метод, осуществляющий тестирование написанного кода класса BankAccount
	static void TestMethod()
	{
		BankAccount acc1 = new BankAccount();
		acc1.SetAccNum(10000000000000000000UL);
		acc1.SetBalance(100.00M);
		acc1.SetAccType(BankAccount.enum_accountTypes.CURR);
		Console.WriteLine("Номер счета: " + acc1.GetAccNum().ToString());
		Console.WriteLine("Баланс: {0:C2}", acc1.GetBalance());
		Console.WriteLine("Тип: {0}", acc1.ProcessEnumValue(acc1.GetAccType()));
		Console.Write("\n\n");
		acc1.PrintInfo();
		BankAccount acc2 = new BankAccount();
		acc2.Balance = 72.56M;
		acc2.AccountNumber = 1234567890UL;
		acc2.AccountType = BankAccount.enum_accountTypes.BROK;
		Console.Write("\n\n");
		Console.WriteLine("Номер счета: " + acc2.AccountNumber.ToString());
		Console.WriteLine("Баланс: {0:C2}", acc2.Balance);
		Console.WriteLine("Тип cчета: {0}", acc2.ProcessEnumValue(acc2.AccountType));
		BankAccount acc3 = new BankAccount(23650.92M);
		acc3.TopUp(5000.00M);
		acc3.Cash(2000.00M);
		Console.Write("\n\n");
		acc3.PrintInfo();
		BankAccount acc4 = new BankAccount(BankAccount.enum_accountTypes.SVNG);
		Console.Write("\n\n");
		acc4.PrintInfo();
		BankAccount acc5 = new BankAccount(40000.00M, BankAccount.enum_accountTypes.FRZN);
		Console.Write("\n\n");
		acc5.PrintInfo();
	}
}