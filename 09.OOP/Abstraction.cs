using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.OOP
{
    internal class Abstraction
    {
        /***************************************************************************
         * 추상화 (Abstraction)
         *
         * 클래스를 정의할 당시 구체화 시킬 수 없는 기능을 추상적 표현으로 정의
         ****************************************************************************/

        // <추상클래스 (abstract class)>
        // 하나 이상의 추상함수를 포함하는 클래스
        // 클래스가 추상적인 표현을 정의하는 경우 자식에서 구체화시켜 구현할 것을 염두하고 추상화 시킴
        // 추상클래스에서 내용을 구체화 할 수 없는 추상함수는 내용을 정의하지 않음
        // 추상클래스를 상속하는 자식클래스가 추상함수를 재정의하여 구체화한 경우 사용가능

        public abstract class Animal
        {
            public string name;
            public int age;

            public abstract void Cry();

            //abstract 내용의 구현을 미뤄놓고 이런 게 있을것이다 예고
            public virtual void Render()
            {

            }

        }
        public class Cat : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("야옹");
            }
            // 미뤄놨던거 override 로 재정의 해주지 않으면 에러뜸
            // virtual 이랑 차이는 virtual 은 재정의 할 수 있다 고 이건 해야만 함
        }

        public class Dog : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("멍멍");
            }
        }

        static void Main123()
        {
            Animal cat = new Cat();
            Animal dog = new Dog();

            cat.Cry();
            dog.Cry();

        }


        public abstract class Item()
        {
            public abstract void Use();
        }

        public abstract class Potion : Item
        {
            public override void Use()
            {
                Console.WriteLine("포션이 체력을 회복시킵니다.");
            }
        }

        public class Player
        {
            public void Use(Item item)
            {
                item.Use();
            }
        }


        // <추상화 사용의미 1>
        // 객체들의 공통적인 특징을 도출하는데 의미
        // 구현을 구체화하기 어려운 상위클래스를 설계하기 위한 수단으로 사용
        //abstract class Animal
        //{
        //    public abstract void Cry();     // 상위클래스에서 구현하기 어려운 기능
        //}

        //class Cat : Animal
        //{
        //    public override void Cry()
        //    {
        //        Console.WriteLine("야옹");   // 자식클래스에서 구체화
        //    }
        //}

        //class Dog : Animal
        //{
        //    public override void Cry()
        //    {
        //        Console.WriteLine("멍멍");    // 자식클래스에서 구체화
        //    }
        //}


        // <추상화 사용의미 2>
        // 상위클래스의 인터페이스를 구현하기 위한 수단으로 사용
        // 추상적인 기능을 구체화시키지 않은 경우 인스턴스 생성이 불가
        // 이를 통해 자식클래스에게 순수가상함수의 구현을 강제하여 실수를 줄임
        //class Bird : Animal
        //{
        //    public override void Cry() { }      // 구현하지 않을 경우 오류
        //}
    }
}
