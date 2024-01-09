namespace _20231228_04
{
    internal class Program
    {

        public struct ChampionStat
        {
            public string name;
            public int Hp;
            public int BasicHp;
            public float BonusHp;
            public float GrowthHp;
            public int Atk;
            public int BasicAtk;
            public float BonusAtk;
            public float GrowthAtk;
            public float Ap;
            public float BasicAp;
            public float BonusAp;
            public float GrowthAp;
        }

        // 여기 구조체 섞어서 간편화 가능한가?
        public abstract class Champion
        {

            public string name;
            public int hp;
            public int atk;
            public int ap;


            Cost
            public void Attack(Champion champion)
            {
                int damage = this.atk;
                (champion).TakeHit(damage);
            }

            public void TakeHit(int damage)
            {
                this.hp -= damage;
            }
            public abstract void Passive();
            public abstract void QSkill();
            public abstract void WSkill();
            public abstract void ESkill();
            public abstract void RSkill();

        }


        public class Cost
        {

        }

        public class Mana : Cost
        {
            public float regen;
            public int maxMP;
            public int currentMP;
        }

        public class stamina : Cost
        {
            public float regenTiming = 3f;
        }

        public class Heat : Cost
        {

        }

        
        public class Garen : Champion
        {
            public Garen()
            {
                name = "가렌";
                hp = 690;
                atk = 69;
                ap = 0;

            }

            public override void QSkill()
            {
                var target;
                do 
                    {
                        target = Console.ReadKey();
                    } while (target == null)
                Console.WriteLine($"대검으로 {target}을 내리쳐 Atk에 비례한 데미지를 입히고 0.5초간 침묵 상태이상상태로 만듭니다.");
                Console.WriteLine("다음 7초간 이 스킬은 사용하지 못합니다");
            }
            public override void WSkill()
            {

            }
            public override void ESkill()
            {

            }
            public override void RSkill()
            {

            }


        }



        public class Ash : Champion
        {
            public Ash()
            { 
                name = "애쉬";
                hp = 690;
                atk = 69;
                ap = 0;
                               
            }
            public Mana maxMP;
            public int currentMP;

            public void Test()
            {
                Skill.Excute();
            }

            public override void QSkill()
            {
                Console.WriteLine("화살을 연사하여 Atk에 비례하는 데미지를 입힙니다.");
                Ash.maxMP -= 40;
            }
            public override void WSkill()
            {

            }
            public override void ESkill()
            {

            }
            public override void RSkill()
            {

            }
        }
    }
}
     

        static void Main(string[] args)
        {
            Garen garen = new Garen();
            Ash ash = new Ash();

            garen.Attack(ash);
        }
    }
}
