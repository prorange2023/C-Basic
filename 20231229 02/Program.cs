using System.Diagnostics.Contracts;

namespace _20231229_02
{
    internal class Program
    {
        abstract class Item
        {
            public abstract void Used();
            
        }

        abstract class Player
        {
            public abstract void Use(Item item);
        }

        class Potion : Item
        {
            public override void Used()
            {
                Console.WriteLine("체력이 30 회복됩니다.");
            }

        }

        class PoisonPotion : Item
        {
            public override void Used()
            {
                Console.WriteLine("맹독입니다!");
                Console.WriteLine("매 턴 체력이 10씩 감소합니다!");
            }
        }

        class AntiPosion : Item
        {
            public override void Used()
            {
                Console.WriteLine("해독되었습니다.");

                Random rand = new Random();
                int random_number = rand.Next(0,3);

                
                switch (random_number)
                {
                    case 0: Console.WriteLine("신이 보우하사 해독이되었습니다.");
                        break;
                    case 1: Console.WriteLine("한번은 목숨을 건졌지만, 다음은 없을것입니다.");
                        break;
                    case 2: Console.WriteLine("해독제를 구하는 행운이 여러번 있을거라 생각하십니까?");
                        break;
                }
                    
                
            }
        }
        
        class Mage : Player
        {
            public override void Use(Item item)
            {
                item.Used(); 
            }
        }

        static void Main()
        {
            Mage mage = new Mage();
            Item potion = new Potion();
            Item poisonpotion = new PoisonPotion();
            Item antipoison = new AntiPosion();
            mage.Use(potion);
            mage.Use(poisonpotion);
            mage.Use(potion);
            mage.Use(potion);
            mage.Use(potion);
            mage.Use(antipoison);
        }
    }
}
