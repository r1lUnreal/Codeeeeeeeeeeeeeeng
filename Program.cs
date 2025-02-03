using System;
using System.Collections.Generic;

public class Creature
{
    public string Name;
    public int Health;
    
    public Creature(string name, int health)
    {
        Name = name;
        Health = health;
    }
    
    public virtual void Attack(Creature target)
    {
        Console.WriteLine("ponel");
    }
    
    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Console.WriteLine("you dead");
        }
    }
}

class Hero : Creature
{
    public int AttackPower;
    
    public Hero(string name, int health, int attackPower) : base(name, health)
    {
        AttackPower = attackPower;
    }
    
    public override void Attack(Creature target)
    {
        Console.WriteLine($"{Name} атакует {target.Name} и наносит {AttackPower} урона!");
        target.TakeDamage(AttackPower);
    }
}

class Monster : Creature
{
    public int AttackPower;
    
    public Monster(string name, int health, int attackPower) : base(name, health)
    {
        AttackPower = attackPower;
    }
    
    public override void Attack(Creature target)
    {
        Console.WriteLine($"{Name} атакует {target.Name} и наносит {AttackPower} урона!");
        target.TakeDamage(AttackPower);
    }
}

class Item
{
    public string Name;
    public string Description;
    
    public Item(string name, string description)
    {
        Name = name;
        Description = description;
    }
    
    public virtual void Use(Hero hero)
    {
        Console.WriteLine($"Используется {Name}: {Description}");
    }
}

class HealingPotion : Item
{
    private int healingAmount;
    
    public HealingPotion(string name, string description, int healingAmount) : base(name, description)
    {
        this.healingAmount = healingAmount;
    }
    
    public override void Use(Hero hero)
    {
        hero.Health += healingAmount;
        Console.WriteLine($"{hero.Name} использует {Name} и восстанавливает {healingAmount} здоровья! Теперь у него {hero.Health} HP.");
    }
}

public class Game
{
    private Hero hero;
    private List<Monster> monsters;
    private List<Item> inventory;

    public Game()
    {
        hero = new Hero("Zebra", 100, 20);
        monsters = new List<Monster>
        {
            new Monster("Chubaka", 30, 5),
            new Monster("Ivan Zolo", 50, 10)
        };
        inventory = new List<Item>
        {
            new HealingPotion("Малое зелье лечения", "Восстанавливает 20 единиц здоровья", 20)
        };
    }

    public void Play()
    {
        Console.WriteLine("Добро пожаловать в мою глупую RPG!");
        Console.WriteLine($"{hero.Name} начинает своё приключение с {hero.Health} здоровья и {hero.AttackPower} силы атаки.");

        foreach (var monster in monsters)
        {
            Console.WriteLine($"\nДикий {monster.Name} появился!");

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
                Console.WriteLine($"{hero.Name} победил {monster.Name}!");
            }
            else
            {
                Console.WriteLine($"{hero.Name} был побеждён {monster.Name}...");
                return;
            }
        }

        Console.WriteLine($"\n{hero.Name} победил всех монстров!");

        foreach (var item in inventory)
        {
            item.Use(hero);
        }

        Console.WriteLine($"{hero.Name} теперь имеет {hero.Health} здоровья после использования предметов.");
    }
}

public class Program
{
    public static void Main()
    {
        Game game = new Game();
        game.Play();
    }
}