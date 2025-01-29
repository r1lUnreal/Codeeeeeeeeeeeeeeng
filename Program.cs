using System;
using System.Collections.Generic;

// Абстрактный класс "Существо" (Creature)
abstract class Creature
{
    public string Name { get; set; }
    public int Health { get; private set; }

    public Creature(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void Attack(Creature target);

    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
        Console.WriteLine($"{Name} takes {damage} damage. Health: {Health}");
    }
}

// Класс "Герой" (Hero)
class Hero : Creature
{
    public int AttackPower { get; set; }

    public Hero(string name, int health, int attackPower) : base(name, health)
    {
        AttackPower = attackPower;
    }

    public override void Attack(Creature target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }
}

// Класс "Монстр" (Monster)
class Monster : Creature
{
    public int AttackPower { get; set; }

    public Monster(string name, int health, int attackPower) : base(name, health)
    {
        AttackPower = attackPower;
    }

    public override void Attack(Creature target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }
}

// Класс "Предмет" (Item)
abstract class Item
{
    public string Name { get; }
    public string Description { get; }

    public Item(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract void Use(Hero hero);
}

// Класс "Зелье лечения" (HealingPotion)
class HealingPotion : Item
{
    public int HealAmount { get; }

    public HealingPotion(string name, string description, int healAmount) : base(name, description)
    {
        HealAmount = healAmount;
    }

    public override void Use(Hero hero)
    {
        Console.WriteLine($"{hero.Name} uses {Name} and heals for {HealAmount} health.");
        hero.Heal(HealAmount);
    }
}

// Дополняем класс "Герой" методом лечения
static class HeroExtensions
{
    public static void Heal(this Hero hero, int amount)
    {
        hero.GetType().GetProperty("Health")?.SetValue(hero, hero.Health + amount);
    }
}

//Game
public class Game
{
    private Hero hero;
    private List<Monster> monsters;
    private List<Item> inventory;

    public Game()
    {
        hero = new Hero("Зёбра", 100, 20);
        monsters = new List<Monster>
        {
            new Monster("Чубака", 30, 5),
            new Monster("Макака", 50, 10)
        };
        inventory = new List<Item>
        {
            new HealingPotion("Small Healing Potion", "Heals 20 health points", 20)
        };
    }

    public void Play()
    {
        Console.WriteLine("Welcome to the RPG Game!");
        Console.WriteLine($"{hero.Name} starts the journey with {hero.Health} health and {hero.AttackPower} attack power.");

        foreach (var monster in monsters)
        {
            Console.WriteLine($"\nA wild {monster.Name} appears!");

            while (monster.Health > 0 && hero.Health > 0)
            {
                hero.Attack(monster);
                if (monster.Health > 0)
                {
                    monster.Attack(hero);
                }
            }

            if (hero.Health > 0)
            {
                Console.WriteLine($"{hero.Name} defeated the {monster.Name}!");
            }
            else
            {
                Console.WriteLine($"{hero.Name} was defeated by the {monster.Name}...");
                return;
            }
        }

        Console.WriteLine($"\n{hero.Name} has defeated all the monsters!");

        foreach (var item in inventory)
        {
            item.Use(hero);
        }

        Console.WriteLine($"{hero.Name} has {hero.Health} health remaining after using items.");
    }
}

//запуск игры
public class Program
{
    public static void Main()
    {
        Game game = new Game();
        game.Play();
    }
}