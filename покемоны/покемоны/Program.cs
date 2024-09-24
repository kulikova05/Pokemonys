using pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static pokemon.pokemon;

namespace pokemon
{
    class pokemon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }
        public string Abilities { get; set; }
        public string Nature { get; set; }


        public pokemon(string name, int hp, int attack, int defense, int specialAttack, int specialDefense, int speed, string type, string abilities, string nature)
        {
            Name = name;
            HP = hp;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Speed = speed;
            Type = type;
            Abilities = abilities;
            Nature = nature;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Очки здоровья: {HP}");
            Console.WriteLine($"Атака: {Attack}");
            Console.WriteLine($"Защита: {Defense}");
            Console.WriteLine($"Специальная атака: {SpecialAttack}");
            Console.WriteLine($"Специальная защита: {SpecialDefense}");
            Console.WriteLine($"Скорость: {Speed}");
            Console.WriteLine($"Тип: {Type}");
            Console.WriteLine($"Умение: {Abilities}");
            Console.WriteLine($"Черта характера: {Nature}");

        }

        public class Seviper : pokemon
        {
            public Seviper() : base("Seviper", 256, 205, 125, 205, 125, 135, "ядовитый", "Work Up, Shadow Ball, Rock Tomb, Present", "Проказливый")
            {
            }
        }

        public class Mienfoo : pokemon
        {
            public Mienfoo() : base("Mienfoo", 200, 175, 105, 115, 105, 135, "боевой ", "Aerial Ase, Tail Whip, Facade", "Безрассудный")
            {
            }
        }

    
        public class Mienshao : pokemon
        {
            public Mienshao() : base("Mienshao", 240, 255, 125, 195, 125, 215, "боевой", "Aerial Ase, Tail Whip, Facade, Sand Attack", "Безрассудный")
            {
            }
        }

    }
internal class Program
    {
        static void Main(string[] args)
        {
        Seviper seviper = new Seviper();
        Mienfoo mienfoo = new Mienfoo();
        Mienshao mienshao = new Mienshao();

        seviper.PrintInfo();
        Console.WriteLine();
        mienfoo.PrintInfo();
        Console.WriteLine();
        mienshao.PrintInfo();
        Console.WriteLine();


    }
    }
}