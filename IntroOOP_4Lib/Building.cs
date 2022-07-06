namespace IntroOOP_4Lib;

public class Building
{
	// Перечисление полей
	public enum Fields {NUM, HGT, FLR, FLT, ENT};
	
	// Поля сделал типа uint, чтобы они не принимали отрицательные значения
	private uint _Number, _Height, _Floors, _Flats, _Entrances;
	private static uint _LastUsedNumber;
	
	// Получение значения полей
	public uint Get(Fields fields)
	{
		switch (fields)
		{
			case Fields.NUM:
				return _Number;
				break;
			case Fields.HGT:
				return _Height;
				break;
			case Fields.FLR:
				return _Floors;
				break;
			case Fields.FLT:
				return _Flats;
				break;
			case Fields.ENT:
				return _Entrances;
				break;
			default:
				return 0U;
				break;
		}
	}
	
    // Установка значения полей
	internal void Set(Fields fields, uint val)
	{
		switch (fields)
		{
			case Fields.NUM:
				_Number = val;
				break;
			case Fields.HGT:
				_Height = val;
				break;
			case Fields.FLR:
				_Floors = val;
				break;
			case Fields.FLT:
				_Flats = val;
				break;
			case Fields.ENT:
				_Entrances = val;
				break;
			default:
				break;
		}
	}
	
	// Вычисление количества квартир на этаже
	public uint FltsIn1Floor()
	{
		return _Flats / _Floors;
	}
	// Вычисление количества квартир в подъезде
	public uint FlatsIn1Entr()
	{
		return _Flats / _Entrances;
	}
	//Вычисление высоты этажа
	public uint UFloorHeight()
	{
		return _Height / _Floors;
	}
	// Конструктор
	internal Building(uint height, uint floors, uint flats, uint entrances)
	{
		(_Height, _Floors, _Flats, _Entrances) = (height, floors, flats, entrances);
		_Number = GenerateNumber();
	}
	
	// Генератор номера дома
	private uint GenerateNumber()
	{
		_LastUsedNumber += 1; return _LastUsedNumber;
	}
	
}