using System.Numerics;

namespace CSharpProgramming
{
    internal class Program
    {
        /* 가위, 바위, 보 게임을 함수, 열거형, 구조체를 이용하여 체계화 시키자

            1. 플레이어한테 가위, 바위, 보 중에서 하나를 입력받도록 함
            2. 컴퓨터는 랜덤으로 가위, 바위, 보 중에서 하나를 선택하도록 함
            3. 가위, 바위, 보의 승패를 계산해서 이긴측에 승수를 1 올려주도록 함
            - 4. 어느 한쪽이라도 3승을 먼저 한 경우 ~~~가 승리 했습니다.
            
            조건1. Main 함수의 길이는 20줄로 제한 => 반복적으로 사용하는 기능을 함수로 구성
            조건2. 가위,바위,보 string 허용 X => 가위, 바위, 보를 열거형 관리 (코드가독성)
            조건3. 플레이어 입력 ReadLine() X => ReadKey() 로 진행 (반환형이 ConsoleKeyInfo)
         */

        enum RPS { Rock, Paper, Scissors }

        static RPS PlayerInput()
        {
            RPS result = RPS.Rock;
            // 1 : 가위, 2 : 바위, 3 : 보
            Console.WriteLine("가위, 바위, 보 중에 하나를 선택하세요.");
            Console.WriteLine("1. 가위 2. 바위 3. 보");
            Console.Write(": ");

            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    result = RPS.Scissors;
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    result = RPS.Rock;
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    result = RPS.Paper;
                    break;
            }

            return result;
        }

        static RPS ComputerRandom()
        {
            Random rand = new Random();
            int value = rand.Next(0, 3);

            RPS result = (RPS)value;
            return result;
        }

        enum WinOrLose { Win, Draw, Lose }

        static WinOrLose CalculateBattle(RPS player, RPS computer)
        {
            // 플레이어가 지는 경우
            if (player == RPS.Scissors && computer == RPS.Rock)
            {
                return WinOrLose.Lose;
            }
            else if (player == RPS.Rock && computer == RPS.Paper)
            {
                return WinOrLose.Lose;
            }
            else if (player == RPS.Paper && computer == RPS.Scissors)
            {
                return WinOrLose.Lose;
            }
            // 플레이어가 이기는 경우
            else if (player == RPS.Rock && computer == RPS.Scissors)
            {
                return WinOrLose.Win;
            }
            else if (player == RPS.Paper && computer == RPS.Rock)
            {
                return WinOrLose.Win;
            }
            else if (player == RPS.Scissors && computer == RPS.Paper)
            {
                return WinOrLose.Win;
            }
            // 비기는 경우
            else
            {
                return WinOrLose.Draw;
            }
        }

        static void PrintResult(RPS player, RPS computer, WinOrLose result, int playerWin, int computerWin)
        {
            Console.WriteLine();
            Console.WriteLine($"player : {player}");
            Console.WriteLine($"computer : {computer}");
            Console.WriteLine($"result : {result}");
            Console.WriteLine($"player : {playerWin}  computer : {computerWin}");
            Console.WriteLine();
        }

        static void PrintGameEnd(int playerWin, int computerWin)
        {
            if (playerWin == 3)
            {
                // 플레이어 승리
                Console.WriteLine("플레이어가 승리했습니다!!!");
            }
            else if (computerWin == 3)
            {
                // 컴퓨터 승리
                Console.WriteLine("컴퓨터가 승리했습니다.");
            }
        }

        static void Main(string[] args)
        {
            int playerWin = 0;
            int computerWin = 0;

            while (playerWin < 3 && computerWin < 3)
            {
                RPS player = PlayerInput();
                RPS computer = ComputerRandom();
                WinOrLose result = CalculateBattle(player, computer);

                if (result == WinOrLose.Win)
                {
                    playerWin++;
                }
                else if (result == WinOrLose.Lose)
                {
                    computerWin++;
                }

                PrintResult(player, computer, result, playerWin, computerWin);
            }
            PrintGameEnd(playerWin, computerWin);
        }
    }
}
