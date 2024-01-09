namespace _20231228_시계
{
    internal class Program
    {
        class Driver
        {
            public string name;

            public void Accel(Vehicle vehicle)
            {
                Console.WriteLine($"{this.name} 이/가 {vehicle.name} 의 엑셀을 밟습니다.");
                vehicle.SpeedUp();
            }

            public void Break(Vehicle vehicle)
            {
                Console.WriteLine($"{this.name} 이/가 {vehicle.name} 의 브레이크를 밟습니다.");
                vehicle.SpeedDown();
            }
        }

        class Vehicle
        {
            public string name;
            public int speed = 0;

            public void SpeedUp()
            {
                speed += 10;
                Console.WriteLine($"{name} 의 속도가 {speed} 으로 증가합니다.");

                
            }

            public void SpeedDown()
            {
                
                    speed -= 10;
                if (speed > 0)
                {
                    Console.WriteLine($"{name} 의 속도가 {speed} 으로 감소합니다.");
                }
                else
                {
                    Console.WriteLine($"{name}의 속도가 0으로 감소합니다.");
                }

            }
        }

        static void Game(Driver driver, Vehicle car)
        {
            
            while (car.speed < 100 )
            {
                Console.WriteLine("명령을 입력하시오.");
                Console.WriteLine("엑셀 : 위쪽 방향키, 브레이크 : 아래쪽 방향키");
                var input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        driver.Accel(car);
                        break;
                    case ConsoleKey.DownArrow:
                        driver.Break(car);
                        break;
                }
                Console.WriteLine($"자동차의 현재 속도는{car.speed} 입니다.");
            }
        }

        static void Endmsg()
        {
            Console.WriteLine("자동차의 속도가 100을 이상입니다.");
            Console.WriteLine("안전을 위해 실험을 종료합니다");
        }
        static void Main(string[] args)
        {
            Driver driver = new Driver() { name = "스피드스타" };
            Vehicle car = new Vehicle() { name = "자동차" };

            Game(driver, car);
            Endmsg();

            

            
        }
    }
}
