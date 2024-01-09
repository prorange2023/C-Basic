namespace lenshu
{
    internal class Program
    {
        class Skill
        {
            protected float coolTime;
            public virtual void Execute()       // 가상함수
            {
                Console.WriteLine("스킬 재사용 대기시간을 진행시킴");
            }
        }

        class FireBall : Skill
        {
            public FireBall()
            {
                coolTime = 3f;
                // Excute = "불덩이를 날린다"; 이걸 날리고 아래로 덮어쓰기
            }
            public override void Execute()      // 오버라이딩
            {
                base.Execute();      // base : 부모클래스를 가리킴
                Console.WriteLine("전방에 화염구를 날림");
            }
        }

        class Heal : Skill
        {
            public Heal()
            {
                coolTime = 5f;

            }
            public override void Execute()
            {
                base.Execute();
                Console.WriteLine("체력회복");
            }
        }
        static void Main(string[] args)
        {
            Skill fireBall = new Skill();
            fireBall.Execute();     // 자식클래스의 함수가 호출됨
            // 스킬 재사용 대기시간을 진행시킴
            // 전방에 화명구를 날림

            Skill heal = new Skill();
            heal.Execute();         // 자식클래스의 함수가 호출됨
            // 스킬 재사용 대기시간을 진행시킴
            // 체력회복

            // 위 아래 차이 : 위는 Skill(부모클래스)에 업캐스팅 한거라서?
            // 그래서 Skill 의 Execute 만 실행이 됨 - 뒷부분에 뭘 넣느냐가 결정
            // 아래느 Fireball 의 execute 먼저 실행이 됨

            Skill fireBall2 = new FireBall();
            Skill heal2 = new Heal();

            fireBall2.Execute();
            heal2.Execute();
        
        }
    }
}
