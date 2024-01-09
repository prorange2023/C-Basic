//using System.ComponentModel.Design;
//using System.Reflection.Emit;

//namespace _03._conditional
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // CS 공부
//            // bool result = 1 <= level <= 18;   
//            // bool abc = false;
//            // abc = (abc >= 1) && (abc <=18);
//            // 왜 안되는지
//            // 어떻게 소스를 구성해야 위에 의도를 구현할 수 있는지
//            // 비트마스크라는 것을 조사하고 공부하자

//            // 상태이상 여러개를 효율적으로 관리하기 위해서 비트 플래그라는 기법으로 관리한다

//            // 이러면 int 만으로 상태이상 bool값 32개를 관리할 수 있다.

//            // 장점은 속도, 용량

//            // 유니티 엔진 설명서에서 게임 오브젝트, 레이어 검색

//            /****************************************************************
//             * 조건문 (Conditional)
//             *
//             * 조건에 따라 실행이 달라지게 할 때 사용하는 문장
//             ****************************************************************/

//            /****************************************************************
//             * if 조건문
//             *
//             * 조건식의 true, false에 따라 실행할 블록을 결정하는 조건문
//             ****************************************************************/

//            // <if 조건문 기본>

//             예시
            int playerHp = 100;
            int monsterAtk = 20;

            if (playerHp > monsterAtk)   // 조건이 true인 경우 바로 아래의 블록이 실행됨
            {
                Console.WriteLine("플레이어가 데미지를 받습니다.");
                playerHp -= monsterAtk;
            }
            else
            {
                Console.WriteLine("플레이어가 쓰러집니다.");
                playerHp = 0;
            }

//            bool isJumpPressed = true;
//            bool isGround = true;

//            if (isGround && isJumpPressed)
//            {
//                Console.WriteLine("점프한다");
//            }
//            else //이런경우  else 는 생략해도됨
//            {
//                Console.WriteLine("아무것도 안한다");
//            }

            string input = "바위";
            if (input == "바위")
            {
                Console.WriteLine("입력한 값이 바위일때 처리");
            }

            else if (input == "보")
            {
                Console.WriteLine("입력한 값이 보일때 처리");
            }

            else if (input =="가위")
            {
                Console.WriteLine("입력한 값이 가위일때 처리");
            }

            else
            {
                Console.WriteLine("입력한 값이 셋다 아닐때 처리");
            }

//            // 위 경우 조심할 상황

//            int score = 65; // 60이하 아이언, 61~70 브론즈, 71~80 실버, 81~90 골드, 91~100 플레;

//            if (score <= 60)
//            {
//                Console.WriteLine("아이언");
//            }
//            else if (score <= 70)
//            {
//                Console.WriteLine("브론즈");

//            }
//            // 이렇게 큰범위를 먼저 써버리면 안됨

//            /****************************************************************
//             * switch 조건문
//             *
//             * 조건값에 따라 실행할 시작지점을 결정하는 조건문
//             ****************************************************************/

//            // < swtich 조건문 기본 >
//            char c = 'D';
//            switch (c) // 조건값 지정
//            {
//                case 'A':
//                    Console.WriteLine("조건값이 A인 경우 실행");
//                    break;
//                case 'B':
//                    Console.WriteLine("조건값이 B인 경우 실행");
//                    break;
//                case 'C':
//                    Console.WriteLine("조건값이 C인 경우 실행");
//                    break;
//                default:            // 조건값이 case에 일치한 적이 없으니 default가 실행지점이 됨
//                    Console.WriteLine("값은 그 외");
//                    break;
//            }

//            // switch 와 if 의 차이
//            // switch 는 값밖에 못해서 범위지정으로 못함


//            // 조건값에 따라 동일한 실행이 필요한 경우 묶어서 사용 가능
//            char key = 'w';
//            switch (key)
//            {
//                case 'w':
//                case 'W':
//                case 'ㅈ':
//                    Console.WriteLine("위쪽으로 이동");
//                    break;
//                case 'a':
//                case 'A':
//                case 'ㅁ':
//                    Console.WriteLine("왼쪽으로 이동");
//                    break;
//                case 's':
//                case 'S':
//                case 'ㄴ':
//                    Console.WriteLine("아래쪽으로 이동");
//                    break;
//                case 'd':
//                case 'D':
//                case 'ㅇ':
//                    Console.WriteLine("오른쪽으로 이동");
//                    break;
//                default:
//                    Console.WriteLine("이동하지 않음");
//                    break;
//            }

//            /****************************************************************
//             * 삼항연산자
//             *
//             * 간단한 조건문을 빠르게 작성
//             ****************************************************************/

//            // <삼항 연산자 기본>
//            // 조건 ? true인 경우 값 : false인 경우 값

//            // 예시
//            int left = 11;
//            int right = 21;

//            int bigger;
//            if (left > right)
//            {
//                bigger = left;
//            }

//            else (right > left)
//            {
//                bigger = right;
//            }

//            // 위를 줄이면

//            int bigger = left > right ? left : right;

//            // 위 문장임
//            // 간단할때만 쓰자

//            int big = 20 > 10 ? 20 : 10;      // 조건이 true이니 20
//            int small = 20 < 10 ? 20 : 10;      // 조건이 false이니 10
//        }


//    }
//    }
//}