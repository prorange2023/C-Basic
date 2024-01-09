namespace _20231229_01
{
    internal class Program
    {
        class Skill()
        {
            protected float coolTime;

            public virtual void Art()
            {
                Console.WriteLine("스킬 재사용 대기시간을 감소시킴");
            }


        }
        class FireBall : Skill
        {
            public FireBall()
            {
                coolTime = 5f;
            }
            public override void Art()
            {
                Console.WriteLine("스킬 재사용 대기시간을 감소시킴");
                Console.WriteLine("전방에 화염구를 던집니다.");
            }

        }
        class Heal : Skill
        {
            public Heal()
            {
                coolTime = 12f;
            }
            public override void Art()
            {
                Console.WriteLine("스킬 재사용 대기시간을 감소시킴");
                Console.WriteLine("아군의 체력을 10 회복합니다.");
            }

        }

        class Boost : Skill
        {
            public Boost()
            {
                coolTime = 25f;
            }

            public override void Art()
            {
                Console.WriteLine("스킬 재사용 대기시간을 감소시킴");
                Console.WriteLine("다음에 사용하는 스킬의 데미지가 40% 증가합니다.");
            }
        }

        public abstract class Player
        {
            public abstract void QSkill();
            public abstract void WSkill();
            public abstract void ESkill();

            
        }

        class Mage : Player
        {
            public override void QSkill()
            {
                FireBall fireBall = new FireBall();
                fireBall.Art();
            }

            public override void WSkill()
            {
                Heal heal = new Heal();
                heal.Art();
            }
            public override void ESkill()
            {
                Boost boost = new Boost();
                boost.Art();
            }
        }
        static void Main()
        {
            Mage mage = new Mage();
            mage.ESkill();
            mage.QSkill();
            mage.ESkill();
            mage.QSkill();
            mage.QSkill();
            mage.WSkill();
            mage.WSkill();
            
            

        }
    }
}
