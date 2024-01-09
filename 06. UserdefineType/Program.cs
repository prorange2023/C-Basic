using System.Security.Cryptography;

namespace _06._UserdefineType
{
    internal class Program
    {
        /********************************************************************
         * 열거형 (Enum)
        * 
        * 기본 정수 숫자의 형식의 명명된 상수 집합에 의해 정의되는 값 형식
        * 열거형 멤버의 이름으로 관리되어 코드의 가독성적인 측면에 도움이 됨
        ********************************************************************/

        // <열거형 기본사용>
        // enum 열거형이름 { 멤버이름, 멤버이름, ... }

        enum Direction { up, down, left, right }
        Void main1()
        {   
            //0 : 위 , 1 : 아래 2 : 왼 3 : 오른


            Direction input = Direction.right;
            switch (input)
            {
                case Direction.up:
                    Console.WriteLine("위로이동");
                    break;
                case Direction.down:
                    Console.WriteLine("아래로이동");
                    break;
                case Direction.left:
                    Console.WriteLine("왼쪽으로이동");
                    break;
                case Direction.right:
                    Console.WriteLine("오른쪽으로 이동");
                    break;
            }



        }
        // <열거형 변환>
        enum Season
        {
            Spring, // 0    // 열거형 멤버에 정수값을 지정하지 않을 경우 0부터 시작
            Summer, // 1    // 열거형 멤버에 정수값을 지정하지 않을 경우 이전 맴버 +1 값을 가짐
            Autumn = 20,    // 정수값을 직접 할당 가능
            Winter  // 21   // 정수값을 직접 할당한 경우에도 이전 멤버 +1 값을 가짐
        }
        Void main1()
        {
            Season season1 = Season.Autumn;
            Console.WriteLine($"{season1}의 정수값은 {(int)season1} 입니다."); 
            // 열거형변수를 int로 형변환
            /* int 로 집어넣는게 가능 위의 경우 int value1 = 2; 서로간 형변환이 가능하다는것 기억*/

            Season season2 = (Season)0;     // 정수에서 열거형변수로 형변환


            Console.WriteLine(season2);     // Spring
            Season season3 = (Season)11;  // 이렇게 없는걸로 형변환 하면? 그냥 11 뜸

        }


        /**************************************************
         * 구조체 (Struct)
         * 
         * 데이터와 관련 기능을 캡슐화할 수 있는 값 형식
         * 데이터를 저장하기 보관하기 위한 단위용도로 사용
         **************************************************/

        // <구조체 구성>
        // struct 구조체이름 { 구조체내용 }
        // 구조체 내용으로는 변수와 함수가 포함 가능


        // 몬스터 스탯같은거 여러게를 같이 관리하는 자료형이 있으면 편하지 않을까!에서 출발

        struct Monsterstat
        {
            public int hp;
            public int mp;
            public int level;
            public float speed;
            public float range;
            //몬스터 스탯이 가질수 있는 자료형들
            public int exp;
        }
        
        // 게임에서 많이 쓰는 구조체

        //struct Vector3
        //{
        //    public int x;
        //    public int y;
        //    public int z;

        //    // 여기서 길이 구하는 기능 넣기

        //    public float Magnatitude()
        //    {
        //        return (float)Math.Sqrt(x + x + y + y + z + z);
        //    }
        //}

        




        static void Main(string[] args)
        {
            // 위에서 저렇게 만들어 놓으면 이렇게 일일이 만들 필요가 없다 자료 추가가 쉽다. 다수의 개체에 추가할 자료가 있으면 구조체 활용시 하나 만들어서 여러 개체에 사용가능
            Monsterstat monsoter1;
            monsoter1.hp = 10;
            monsoter1.mp = 20;
            monsoter1.level = 30;
            monsoter1.speed = 50.0f;
            monsoter1.range = 100.0f;
            //위에 경치 추가하고
            monsoter1.exp = 50;
            //이러면 추가 끝 이런식
        }

        struct StudentInfo
        {
            public string name;
            public int math;
            public int english;
            public int science;

            // 아래가 기능 합치는 파트

            public int GetSum()
            {
                return math + english + science;
            }

            public float GetAverage()
            {
                return (math + english + science) / 3.0f;
            }
        }


        void Main3()
        {
            StudentInfo kim;
            kim.name = "김정택";
            kim.math = 60;
            kim.english = 100;
            kim.science = 50;

            // 이걸로 이제 계산을 하려고 하면 원래대로 입력을 일일이 해야하는데 구조체에 기능을 묶어서 간편화 하는 방법도 있음

            Console.WriteLine($"{kim.name}의 점수 총합은 {kim.GetSum()}입니다.");




            StudentInfo lee;
            lee.name = "이감자";
            lee.math = 60;
            lee.english = 100;
            lee.science = 50;
        }

        // <구조체 초기화>
        // 반환형이 없는 구조체이름의 함수를 초기화라 하며 구조체 변수들의 초기화를 진행하는 역할로 사용
        // 매개변수가 있는 초기화를 정의하여 구조체 변수의 값을 설정하기 위한 용도로 사용
        // 구조체의 초기화는 new 키워드를 통해서 사용

        struct Point
        {
            public int x;
            public int y;

            // C#  9.0 이전 버전 : 기본 초기화는 자동으로 생성되며 변경할 수 없음
            // C# 10.0 이후 버전 : 기본 초기화를 추가하지 않는 경우 자동으로 생성되며 추가하여 변경 가능
            /*public Point()
            {
                this.x = 0;
                this.y = 0;
            }*/

            public Point( )
            {
                // 초기화에서 모든 구조체 변수를 초기화하지 않으면 error 발생
                this.x = 0;     // this : 자기 자신을 가리킴
                this.y = 0;
            }
            //위 초기화 방식이 기본초기화인데 굳이 쓰진말것
            //
            //아래처럼 쓰는 일이 많지 않을지

            public Point(int x, int y)
            {
                // 초기화에서 모든 구조체 변수를 초기화하지 않으면 error 발생
                this.x = x;     // this : 자기 자신을 가리킴
                this.y = y;
            }
        }

        void main5()
        {
            Point point1;
            point1.x = 1;
            Console.WriteLine($"{point1.x}");
            //Console.WriteLine($"{point1.y}");
            // 초기화 안한 변수쓰면 에러남. 근데 변수가 너무 많으면 위처럼 일일이 초기화하는게 힘들어짐 그래서 위의 구조체 초기화 기능

            Point point2 = new Point(2, 3);
            Console.WriteLine($"{point1.x},{point2.y}");

            //아래처럼 쓰거나 위처럼 쓰거나

            Point point3 = new Point(); //  이게 기본초기화
            Console.WriteLine($"{point1.x},{point2.y}");

        }


        // <구조체 깊은복사>
        // 구조체에 대입연산자(=)를 통해 구조체 내 모든 변수들의 값이 복사됨
        // 얕은복사는 내일 배운다 차이 알아두자
        struct MyStruct
        {
            public int value1;
            public int value2;
        }

        void Main5()
        {
            MyStruct s;
            s.value1 = 1;
            s.value2 = 2;

            MyStruct t = s;     // 구조체 내 모든 변수들의 값이 복사됨
            t.value1 = 3;

            Console.WriteLine(s.value1);    // 1
            Console.WriteLine(s.value2);    // 2

            Console.WriteLine(t.value1);    // 3
            Console.WriteLine(t.value2);    // 2
        }

        // <튜플> 이란 것도 있음: 쓰지말랍신다 -> 구조체를 만들어라
        // 이유 : 관리 어려움, 확장성 안좋음
    }
}