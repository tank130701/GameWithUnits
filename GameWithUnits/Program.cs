using GameWithUnits.Factories;
using GameWithUnits.Models.Army;
using GameWithUnits.Models.Units;

namespace GameWithUnits;

static class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите уровень сложности: 1 - Легкий, 2 - Средний, 3 - Сложный");
        string input = Console.ReadLine();
        IFactory factory;

        switch (input)
        {
            case "1":
                factory = new EazyLvlFactory();
                break;
            case "2":
                factory = new MiddleLvlFactory();
                break;
            case "3":
                factory = new HardLvlFactory();
                break;
            default:
                Console.WriteLine("Неверный ввод, установлен легкий уровень сложности по умолчанию.");
                factory = new EazyLvlFactory();
                break;
        }

        List<Unit> unitsOne = factory.Create();
        
        Army armyOne = new Army("Силы света", unitsOne);
 
        List<Unit> unitsTwo = factory.Create();
        
        Army armyTwo = new Army("Силы тьмы", unitsTwo);
 
        armyOne.Attack(armyTwo);
 
        Console.ReadKey();
    }
}