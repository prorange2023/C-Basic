using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.OOP
{
    internal class Inheritance
    {

        /**********************************************************************************
         * 상속 (Inheritance)
         *
         * 부모클래스의 모든 기능을 가지는 자식클래스를 설계하는 방법
         * is-a 관계 : 부모클래스가 자식클래스를 포함하는 상위개념일 경우 상속관계가 적합함
         **********************************************************************************/

        // <상속>
        // 부모클래스를 상속하는 자식클래스에게 부모클래스의 모든 기능을 부여
        // class 자식클래스 : 부모클래스 <==이러면 상속됨

        class Monster
        {
            public string name;
            public int hp;
            // 체력바 구현
            public void TakeHit(int damage)
            {
                hp -= damage;
                Console.WriteLine($"{name}이/가 데미지를 받아 체력이 {hp}가 되었습니다.");
            }
        }


        // C#에선 다중 상속이 안됨

        // 육지생물 : 육지에서 살수있다
        // 해양생물 : 해양에서 살수있다

        // 개구리 : 육지에서 살 수 있다, 해양에서 살 수 있다 이런식으로 구현
        // 자세한건 내일 인터페이스에서 
        

        class Dragon : Monster
        {
            public Dragon()
            {
                name = "용";
                hp = 100;
            }

            public void Breath()
            {
                Console.WriteLine($"{name} 이/가 화염을 뿜습니다.");
            }
        }


        class Slime : Monster
        {
            public Slime()
            {
                name = "슬라임";
                hp = 25;
            }

            public void Split()
            {
                Console.WriteLine($"{name} 이/가 분열합니다.");
            }
        }

        class Orc : Monster
        {
            public void Rage()
            {
                name = "오크";
                hp = 35;
                Console.WriteLine($"{name} 이/가 분노합니다.");
            }
        }

        class Hero
        {
            int damage = 3;

            public void Attack(Monster monster)//업캐스팅 없으면 이거 못함
            {
                monster.TakeHit(damage);
            }

        }

        
        void Main1()
        {
            Dragon dragon = new Dragon();
            dragon.TakeHit(10);
            dragon.Breath();


            Slime slime = new Slime();
            slime.TakeHit(10);
            slime.Split();

            Orc orc = new Orc();
            orc.TakeHit(10);
            orc.Rage();

            Hero hero = new Hero();
            hero.Attack(dragon);
            hero.Attack(slime); 
            hero.Attack(orc);

            //아래와같이 부모로 자식클래스가 형변환이 가능하다.
            //자식 클래스를 부모위치에 보관(업캐스팅) 가능

            Monster monster1 = new Dragon();
            Monster monster2 = new Slime();

            // 이게 묵시적으로 가능하단 말이다.

            monster1.TakeHit(10);
            // monster1.Breath(); // 부모자리에 들어간 인스턴스는 자식만 가진 기능을 쓸 수 없음.

            monster2.TakeHit(10);
            //monster2.split(); // 마찬가지로 안됨

            //다운캐스팅 : 가능하긴 한데 위험할 때 있음 사용 권장하지 않음
            Dragon dra = (Dragon)monster1; // 100% 인 경우 명시적
            // Slime sli = (Slime)monster1; // error 터짐 이건

            // 확신이 있다면 아래의 방법을

            if (monster1 is Dragon) // 직접 형변환 하는 줄 
            {
                Dragon d = (Dragon)monster1;
                Console.WriteLine("monster1은 드래곤입니다.");
            }
            else
            {
                Console.WriteLine("monster1은 드래곤이 아닙니다.");
            }


           if (monster2 is Dragon)
            {
                Dragon d = (Dragon)monster2;
                Console.WriteLine("monster2은 드래곤입니다.");
            }
            else
            {
                Console.WriteLine("monster2는 드래곤이 아닙니다.");
            }

            //위를 축약하면

            Dragon asDragon = monster1 as Dragon;
            // as뜻은 드래곤이면 바꿔주고 아니면 말아라
            Slime asslime = monster1 as Slime;
            //  슬라임이면 바꿔주고 아니면 없다(null)

        }


        // <상속 사용의미 1>
        // 상속을 진행하는 경우 부모클래스의 소스가 자식클래스에서 모두 적용됨
        // 부모클래스와 자식클래스의 상속관계가 적합한 경우 부모클래스에서의 기능 구현이 자식클래스에서도 어울림
        class Fruit
        {
            // 부모클래스에서 기능을 구현할 경우 모든 부모를 상속하는 자식클래스에 기능을 구현하는 효과
        }

        class Apple : Fruit
        {
            // 자식클래스에서 자식클래스만의 기능을 구현
        }


        // <상속 사용의미 2>
        // 업캐스팅을 통해 자식클래스는 부모클래스로 형변환이 가능함
        // 자식클래스는 부모클래스를 요구하는 곳에서 동일한 기능을 수행할 수 있음
        class Parent
        {
            public void Func() { }
        }
        class Child1 : Parent { }
        class Child2 : Parent { }
        class Child3 : Parent { }

        void UseParent(Parent parent) { parent.Func(); }
        void Main2()
        {
            Child1 child1 = new Child1();
            Child2 child2 = new Child2();
            Child3 child3 = new Child3();

            UseParent(child1);
            UseParent(child2);
            UseParent(child3);
        }


    }
}
