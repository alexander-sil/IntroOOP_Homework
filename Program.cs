using System.Text;
using DynaminimNamespace;

namespace IntroOOP_3;

class Program
{
	
	public static BankAccount DestinationAccount = new BankAccount(0.00M, BankAccount.EnumAccountTypes.CURR);
	
	static void Main(string[] args)
	{
		Task1();
		Console.Write("\n\n");
		
		Console.Write(Task2("палиндром") + "\n");
		Console.Write(Task2("заказ"));
		Console.Write("\n\n");
		
		Task3();

		Console.WriteLine("Выполнение завершено");
		Console.ReadKey(true);
		
		
	}
	
	static void Task1()
	{
		BankAccount acc1 = new BankAccount(10000.00M, BankAccount.EnumAccountTypes.SVNG);
		
		DestinationAccount.Transfer(acc1, 2000.00M);
		DestinationAccount.PrintInfo();
		
		Console.Write("\n");
		
		acc1.PrintInfo();
	}
	
	static string Task2(string str)
	{
		char[] chrArray = str.ToCharArray();
		Array.Reverse(chrArray);
		return new string(chrArray);
	}
	
	static void Task3()
	{
		if (!File.Exists("file.txt"))
			File.Create("file.txt").Dispose();
		
		string str = File.ReadAllText("file.txt");
		SearchMail(ref str);
		
		Console.WriteLine(str);
		File.Create("file2.txt").Dispose();
		File.WriteAllText("file2.txt", str);
	}
	
	static void SearchMail(ref string s)
	{

			
		string[] namesAndEmails = (s.Split('\n'));
		
		for (int k = 0; k < namesAndEmails.Length; k++)
		{
			namesAndEmails[k].Trim();
		}
		
		string[] names = new string[] {};
		string[] emails = new string[] {};
		
		Dynaminim d = new Dynaminim();
		
		int i = 0;
		while (i < namesAndEmails.Length)
		{
			string[] buffer = namesAndEmails[i].Split('&');
			for (int n = 0; n < buffer.Length; n++)
				if (n % 2 == 1)
					d.ArrayPush(ref emails, buffer[n]);
				
			
			
			i++;
		}

		
		StringBuilder sb = new StringBuilder();
		
		foreach (string x in emails)
		{
			sb.Append(x + "\n");
		}
		
		s = sb.ToString();
		
		

	}
	
}
