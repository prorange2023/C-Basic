using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _14._Delegate
{
    internal class Callback
    {
        /*******************************************************************************
         * 콜백함수
         * 
         * 델리게이트를 이용하여 특정조건에서 반응하는 함수를 구현
         * 함수의 호출(Call)이 아닌 역으로 호출받을 때 반응을 참조하여 역호출(Callback)
         * 너가 뭐 누르면 내가 뭐할꺼야하고 선언하는 역반응형식이라 역호출(Callback)
         *******************************************************************************/

        public class Player
        {
            public void Jump()
            {
                Console.WriteLine("플레이어 점프함");

            }

            public void Dash()
            {
                Console.WriteLine("플레이어 대쉬함");
            }
        }
        public class Button
        {
            public Action Onclick; //대리자임 여기에 뭘 집어넣느냐로 버튼 구분할 예정
            public void Click()
            {
                if (Onclick != null)
                    Onclick();
            }
            // 기초개념 null = 참조변수가 아무것도 안 가리키고 있다.
        }

        void Main()
        {
            Player player = new Player();

            Button jumpButton = new Button();

            jumpButton.Onclick = player.Jump; // 플레이어입장에서 뭐 눌리면 점프한다고 선언하는것

            jumpButton.Click();

            Button dashButton = new Button();

            dashButton.Onclick = player.Dash;

            dashButton.Click();
        }
    }
}
