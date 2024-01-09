using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
    internal class Lambda
    {
        /*************************************************************************
         * 무명메서드와 람다식
         * 
         * 진짜 난이도 높으니 일단 나중에 연차 쌓이면....
         * LinQ라는 것도있음
         * 
         * 델리게이트 변수에 할당하기 위한 함수를 소스코드 구문에서 생성하여 전달
         * 전달하기 위한 함수가 간단하고 일회성으로 사용될 경우에 간단하게 작성
         *************************************************************************/

        void Main()
        {
            Action<string> action;

            // <함수를 통한 할당>
            // 클래스에 정의된 함수를 직접 할당
            // 클래스의 멤버함수로 연결하기 위한 기능이 있을 경우 적합

            action = Message;


            // 일회용으로 잠시 쓰고 버리는 함수가 필요할 때가 있음
            // 이걸위한 무명 메서드
            // <무명메서드>
            // 함수를 통한 연결은 함수가 직접적으로 선언되어 있어야 사용 가능
            // 할당하기 위한 함수가 간단하고 자주 사용될수록 비효율적
            // 간단한 표현식을 통해 함수를 즉시 작성하여 전달하는 방법
            // 전달하기 위한 함수가 간단하고 일회성으로 사용될 경우에 적합
            action = delegate(string str) { Console.WriteLine(str); };

            // 위도 긴거 같으니까 더줄이려고 만든게
            // <람다식>
            // 무명메서드의 간단한 표현식

            action = (str) => { Console.WriteLine(str); };
            // 더 줄이면
            action = str => Console.WriteLine(str);

            // 더안쓸꺼면

            action = null;
        }


        void Message(string Message)
        {
            Console.WriteLine(Message);
        }

        
    }
}
