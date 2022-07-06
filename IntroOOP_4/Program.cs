using IntroOOP_4Lib;
namespace IntroOOP_4;

class Program
{
	static void Main(string[] args)
	{
		// Тестовый пример
		Creator.CreateBuild(0, 100, 100, 100, 100);
		
		Creator.CreateBuild(1);
		Creator.CreateBuild(2);
		Creator.CreateBuild(3);
		Creator.CreateBuild(4);
		
		Creator.Remove(4);
		
		Creator.PrintInfo();
		
		Console.Write("\n\n");
		Console.WriteLine("Выполнение завершено");
		Console.ReadKey(true);
		
	}
}
