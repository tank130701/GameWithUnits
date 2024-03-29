﻿using GameWithUnits.Models.Units;

namespace GameWithUnits.Models.Army;
// Класс для представления армии
class Army
{
    // Свойство для хранения имени армии
    private string Name { get; set; }
    // Список крипов в армии
    private List<Unit> Units { get; set; }
    // Свойство для хранения количества убитых крипов
    private int Kills { get; set; }

    // Конструктор, который принимает имя армии и список крипов
    public Army(string name, List<Unit> units)
    {
        Name = name;
        Units = units;
        Kills = 0;
    }

    // Метод для атаки другой армии
    public void Attack(Army enemy)
    {
        // Пока обе армии живы, продолжаем сражение
        while (!IsDead() && !enemy.IsDead())
        {
            // Выбираем случайного крипа из своей армии
            Unit attacker = Units[new Random().Next(Units.Count)];
            // Выбираем случайного крипа из вражеской армии
            Unit defender = enemy.Units[new Random().Next(enemy.Units.Count)];
            // Атакуем вражеского крипа
            attacker.Attack(defender);
            // Если вражеский крип умер, удаляем его из списка и увеличиваем счетчик убийств
            if (defender.IsDead())
            {
                enemy.Units.Remove(defender);
                Kills++;
                // Выводим сообщение о том, кто убил кого
                Console.WriteLine($"{Name} убили {defender.Name}");
            }
            // Если армия врага еще жива, то она тоже атакует нашего крипа
            if (!enemy.IsDead())
            {
                // Выбираем случайного крипа из вражеской армии
                attacker = enemy.Units[new Random().Next(enemy.Units.Count)];
                // Выбираем случайного крипа из нашей армии
                defender = Units[new Random().Next(Units.Count)];
                // Атакуем нашего крипа
                attacker.Attack(defender);
                // Если наш крип умер, удаляем его из списка и увеличиваем счетчик убийств врага
                if (defender.IsDead())
                {
                    Units.Remove(defender);
                    enemy.Kills++;
                    // Выводим сообщение о том, кто убил кого
                    Console.WriteLine($"{enemy.Name} убили {defender.Name}");
                }
            }
        }
        Console.WriteLine("=== Игра оконочена ===");
        // Если армия врага мертва, выводим сообщение о победе
        if (enemy.IsDead())
        {
            Console.WriteLine($"{Name} победили!");
        }
        // Если наша армия мертва, выводим сообщение о поражении
        if (IsDead())
        {
            Console.WriteLine($"{enemy.Name} победили!");
        }
        
        Console.WriteLine($"{Name} убили {Kills} крипов");
        Console.WriteLine($"{enemy.Name} убили {enemy.Kills} крипов");
    }

    // Метод для проверки смерти армии
    private bool IsDead()
    {
        // Армия считается мертвой, если в ней нет крипов
        return Units.Count == 0;
    }
}