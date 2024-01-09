using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace _20231228_03
{
    internal class Program
    {
        class Monster
        {
            protected string name;
            protected int hp;
            protected int def;

            public void Move()
            {
                Console.WriteLine($"{name} 이/가 움직입니다.");
            }

            public void TakeHit(int damage)
            {
                hp -= damage - this.def;
                Console.WriteLine($"{name} 이/가 공격을 받아 ({damage-this.def})만큼 체력이 감소하여 {hp} 이 되었습니다.");
            }
        }

        class Dragon : Monster
        {
            public Dragon ()
            {
                name = "드래곤";
                hp = 100;
                def = 1;
            }

            public void Breath ()
            {
                Console.WriteLine($"{name}이 브레스를 뿜습니다");
            }
        }

        class Slime : Monster
        {
            public Slime()
            {
                name = "메탈슬라임";
                hp = 30;
                def = 1;
            }

            public void Split ()
            {
                Console.WriteLine($"{name}이 분열합니다.");
            }
        }

        class Orc : Monster
        {
            protected int damage;
            public Orc()
            {
                name = "오크";
                hp = 10;
                damage = 1;
                def = 1;
            }

            public void Rage ()
            {
                Console.WriteLine($"{name}이 분노합니다. 공격력이 2배로 증가합니다.");
                damage = damage*2;
                
            }
        }

        class OrcWarrior : Orc
        {
            
            public OrcWarrior()
            {
                
                name = "오크 전사";
                hp = 30;
                damage = 2;
                def = 2;
            }
            public void AxeThrow (Player player)
            {
                Console.WriteLine($"{name}이 도끼를 {player}에게 던집니다.");
                player.TakeHit(damage);

            }
        }

        class Player
        {
            protected string name;
            protected int hp;
            protected int damage;
            protected int def;

            public void Attack(Monster monster) 
            {
                monster.TakeHit(damage);
            }
            public void TakeHit(int damage)
            {
                hp -= (damage-this.def);
                Console.WriteLine($"{name} 이/가 {damage-this.def} 를 받아 체력이 {hp} 이 되었습니다.");
            }
        }

        class HumanWarrior : Player 
        {
            public HumanWarrior()
            {
                name = "플레이어01";
                hp = 100;
                damage = 5;
                def = 1;
            }


        }

        static void Main(string[] args)
        {
            Dragon dragon = new Dragon();
            Slime metalslime = new Slime();
            OrcWarrior orcwarrior1 = new OrcWarrior();

            HumanWarrior humanwarrior = new HumanWarrior();
            humanwarrior.Attack(dragon);
            orcwarrior1.AxeThrow(humanwarrior);
            humanwarrior.Attack(orcwarrior1);
            orcwarrior1.Rage();
            orcwarrior1.AxeThrow(humanwarrior);
            metalslime.Split();
        }
    }
}
