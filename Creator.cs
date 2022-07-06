using System.Collections;
namespace IntroOOP_4Lib;

public static class Creator
{
	
	// Хеш-таблица
	private static Hashtable storage = new Hashtable();
	
	// Cтатический конструктор
	// При применении модификаторов доступа к статическим конструкторам будет CS0515
	/// <summary>Конструктор</summary>
	static Creator()
	{
		
	}
	
	// Создание объекта класса здания
	/// <summary>Фабричный метод</summary>
	/// <returns>Ключ</returns>
	public static uint CreateBuild(uint key)
	{
		Random random = new Random();
		storage.Add(key, new Building(uint.Parse(random.Next(1, 30).ToString()), uint.Parse(random.Next(1, 10).ToString()), uint.Parse(random.Next(1, 300).ToString()), uint.Parse(random.Next(1, 20).ToString())));
		return key;
	}
	
	// Перегрузка метода CreateBuild()
	/// <summary>Альтернативный фабричный метод с ручным заполнением полей класса Building</summary>
	/// <returns>Ключ</returns>
	public static uint CreateBuild(uint key, uint height, uint floors, uint flats, uint entrances)
	{
		Random random = new Random();
		storage.Add(key, new Building(height, floors, flats, entrances));
		return key;
	}
	
	// Удаление объекта класса здания по номеру (uint). Пока только по ключу, хеш-коды я не освоил
	/// <summary>Удаление объекта по ключу</summary>
	public static void Remove(uint key)
	{
		storage.Remove(key);
	}
	
	public static void PrintInfo()
	{
		ICollection values = storage.Values;
		foreach (Building i in values)
		{
			Console.WriteLine("НОМЕР = {0}, ВЫСОТА = {1}, ЭТАЖЕЙ = {2}, КВАРТИР = {3}, ПОДЪЕЗДОВ = {4}", i.Get(Building.Fields.NUM), i.Get(Building.Fields.HGT), i.Get(Building.Fields.FLR), i.Get(Building.Fields.FLT), i.Get(Building.Fields.ENT));
			Console.WriteLine("КВАРТИР НА ОДНОМ ЭТАЖЕ = {0}, КВАРТИР В ОДНОМ ПОДЪЕЗДЕ = {1}, ВЫСОТА ЭТАЖА = {2}", i.FltsIn1Floor(), i.FlatsIn1Entr(), i.UFloorHeight());
		}	
	}
}
