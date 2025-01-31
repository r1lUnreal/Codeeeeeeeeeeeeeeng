using System.IO.Pipelines;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;



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
    public virtual void TakeDamage(int damages)
    {
        Health = Health - damages;
        if (Health <= 0)
        {
            Console.WriteLine("you dead");
        }
    }
}

    class Hero : Creature
    {
        public int AttackPower;

        public Hero(string name, int health, int attackpower):base(name, health)
        {
            AttackPower = attackpower;
        }

        public override void Attack(Creature target)
        {
            Console.WriteLine($"{Name} атакует {target.Name} наносит {AttackPower} урон!");
            target.TakeDamage(AttackPower);
        }
    }

    class Monster : Creature
    {
        public int AttackPower;
        public Monster(string name, int health, int attackpower):base(name, health)
        {
            AttackPower = attackpower;
        }
        public override void Attack(Creature target)
        {
            Console.WriteLine($"{Name} атакует {target.Name} наносит {AttackPower} урон! ему бобо:(");
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

        public virtual void Use(string name, string description)
        {
            Console.WriteLine($"Using {Name}: {Description}");
        }
    }














// Класс "Игра" (Game)
public class Game
{
    private Hero hero;
    private List<Monster> monsters;
    private List<Item> inventory;

    public Game(Hero hero, List Monsters, List Item)
    {
        hero = new Hero("Zebra", 100, 20);
        monsters = new List<Monster>
        {
            new Monster("Chubaka", 30, 5),
            new Monster("Ivan Zolo", 50, 10)
        };
        inventory = new List<Item>
        {
            new HealingPotion("Small Healing Potion", "Heals 20 health points", 20)
        };
    }

    public void Play()
    {
        Console.WriteLine("Welcome to the my stuped RPG Game!");
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

// Основной класс для запуска игры
public class Program
{
    public static void Main()
    {
        Game game = new Game();
        game.Play();
    }
}

// why delete me C#!?!?!?
// чем дальше тем больше я не понимаю :(