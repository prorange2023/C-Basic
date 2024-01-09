using System.Security.Cryptography.X509Certificates;

namespace _10._Interface
{
    internal class Program
    {
        /***************************************************************************
         * 인터페이스 (Interface)
         * 
         * 인터페이스는 맴버를 가질 수 있지만 직접 구현하지 않음 단지 정의만을 가짐
         * 인터페이스를 가지는 클래스에서 반드시 인터페이스의 정의를 구현해야함
         * 이를 반대로 표현하자면 인터페이스를 포함하는 클래스는
         * 반드시 인터페이스의 구성 요소들을 구현했다는 것을 보장함
         * Can-a 관계 : 클래스가 해당 행동을 할 수 있는 경우 적합함
         ***************************************************************************/

        // <인터페이스 정의>
        // 일반적으로 인터페이스의 이름은 I로 시작함(국룰)
        // 인터페이스의 함수는 직접 구현하지 않고 정의만 진행
        public interface IEnterable
        {
            void Enter();
        }

        public interface IOpenable
        {
            void Open();
        }

        // <인터페이스 포함>
        // 상속처럼 정의한 인터페이스를 클래스 : 뒤에 선언하여 사용
        // 인터페이스를 포함하는 경우 반드시 인터페이스에서 정의한 함수를 구현해야 함
        // 인터페이스는 여러개 포함 가능


        
        public class Door : IEnterable, IOpenable
        {
            public void Enter()
            {
                Console.WriteLine("문 안으로 들어갑니다.");
            }   
                
            public void Open()
            {
                Console.WriteLine("문을 엽니다.");
            }
        }

        public class Town : IEnterable
        {
            // IEnteralbe 인터페이스가 소속에 있으니 Enter 을 구현해놔야함
            public void Enter()
            {
                Console.WriteLine("마을에 들어갑니다.");
            }
        }

        public class Box : IOpenable, IDamagable
        {
            // IOpenable 인터페이스가 소속되있으니 Open을 구현해놔야함
            public void Open()
            {
                Console.WriteLine("박스가 열립니다.");
            }

            public void TakeHit(int damage)
            {
                Console.WriteLine("상자가 부서집니다.");

            }
        }

        public interface IDamagable
        {
            void TakeHit(int damage);
        }

        // <인터페이스 사용>
        // 인터페이스를 이용하여 기능을 구현할 경우
        // 클래스의 상속관계와 무관하게 행동의 가능여부로 상호작용 가능
        // 인터페이스도 상속됨
        // 상속, 인터페이스 다 적용시 상속을 맨앞에 놔야함 주의
        // 인터페이스끼리 상속도 가능하다
        public class Player
        {
            public void Open(IOpenable openable)
            {
                Console.WriteLine("플레이어가 열기를 시도합니다");
                openable.Open();
            }
            public void Enter(IEnterable enterable)
            {
                Console.WriteLine("플레이어가 대상에 입장을 시도합니다.");
                enterable.Enter();
            }
            public void Attack(IDamagable damagable)
            {
                Console.WriteLine($"플레이어가 대상 공격");
                damagable.TakeHit(10);
            }
        }

        
        
        static void Main(string[] args)
        {
            Player player = new Player();
            Box box = new Box();
            Town town = new Town();

            player.Open(box);

            player.Enter(town);

            Door door = new Door();

            player.Open(door);
            player.Enter(door);
            // 열수도 있고 들어갈수도 있는 물체를 어떻게 구현하는가? 답은 인터페이스
            // 이럼 상속을 왜쓸까?
            // 추상클래스는 왜쓸까?
            // 추상클래스와 인터페이스 용도 차이 - 면접질문 알아두자

            
        }
    }
}
