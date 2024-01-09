namespace _05._function
{
    internal class Program
    {
        /****************************************************************
      * 함수 (Function)
      *
      * 미리 정해진 동작을 수행하는 코드 묶음
      * 어떤 처리를 미리 함수로 만들어 두면 다시 반복적으로 사용 가능
      ****************************************************************/

        // <함수 구성>
        // 일련의 코드를 하나의 이름 아래에 묶음
        // 반환형 함수이름(매개변수목록) { 함수내용 }


        // < 함수 구성 >
        // 일련의 코드를 하나의 이름아래 묶는 기능
        // 일단 static 투명인간 취급하되 모든 함수 앞에 붙여줄것
        // 반환형(출력) 함수이름(매개변수들(입력들)) {함수 내용}
        //static int Plus(int left, int right)
        //{
        //    Console.WriteLine($"input : {left}, {right}");
        //    int result = left + right;
        //    Console.WriteLine($"ouput  {result}");
        //    return result;

            // 출력이 나오면 함수가 끝난거라서 뒤에  Console.WriteLine(); 뭐 이런거 입력하면 무시됨 
            // return 만나면 함수 즉시 종료
            
        //}

        // 출력 이름(입력들) {동작}

        // < 함수 사용 >
        // 함수로 구성해둔 코드를 이름으로 불러서 사용함

        // <반환형(출력형태 즉 반환형태 결정파트) (Return Type)>
        // 함수의 결과(출력) 데이터의 자료형
        // 함수가 끝나기 전까지 반드시 return으로 반환형에 맞는 데이터를 출력해야함
        // return 없으면 오류, 자료형 다른게 나와도 오류
        // 함수 진행 중 return을 만나는 경우 그 즉시 결과 데이터를 반환하고 함수가 종료됨
        // 함수의 결과(출력)이 없는 경우 반환형은 void이며 return을 생략 가능
        // 최적화때문에 return 을 쓰는 경우도 있다고??
        // void 사용하는 경우는 행동 자체가 의미가 있는 경우

        //static void PrintProfile(string name, string phone)
        //    {
        //        Console.WriteLine($"이름 : {name}");
        //        Console.WriteLine($"번호 : {phone}");
        //    }

        //static int Return10()
        //{
        //    Console.WriteLine("도달하는 코드");

        //    return 10;

        //    Console.WriteLine("도달하지 못하는 코드");
        //}

        // <매개변수(말그대로 입력할 변수) (Parameter)>
        // 함수에 추가(입력)할 데이터의 자료형과 변수명
        // 같은 함수에서도 매개변수 입력이 다름에 따라 다른 처리가 가능
        // 매개변수명은 고유해야한다 그 함수 블록 안에서만

        //static int Minus(int left, int right)
        //{
        //    //함수의 입력으로 넣어준 매개변수 left, right에 따라 다른 처리가 가능
        //    return left - right;
        //}

        //static void SetVolume(int volume)
        //{
        //    Console.WriteLine($"볼륨을 {volume}로 설정합니다.");
        //    // 뒤에 굉장한 사운드 관련 옵션들 건드린다고 상상
        //}


        // <함수 호출 순서>
        // 함수는 호출되었을 때 해당 함수블록으로 제어가 전송되며 완료되었을 때 원위치로 제어가 전송됨 <- 이게 return 이 마지막에 붙는 이유.원래의 큰 함수로 돌아감
        // 중요한건 함수가 일직선으로 진행되는게 아니라는것.


        //static void TripleShot()
        //{
        //    int damage = 0;
        //    damage += Attack();
        //    damage += Attack();
        //    damage += Attack();
        //}

        //static void Attack()
        //{
        //    Console.WriteLine("공격!");
        //}

        //void Func2()
        //{               // 1 
        //                // 2
        //}               // 3

        //void Func1()
        //{               // 4
        //    Func2();    // 5
        //}               // 6

        //void Main4()
        //{               // 7
        //    Func1();    // 8
        //}               // 9
        //                // 함수 호출 순서 : 7 -> 8 -> 4 -> 5 -> 1 -> 2 -> 3 -> 6 -> 9

        // return : 왜 아웃풋이 아니라 리턴이냐?
        // 보기엔 하나지만 함수로 나눠보면 작은 문제 여러개인걸 기억할것
        // 출력한 함수값을 들고 실행하려고 대기중이던 곳으로 다시 돌아가니까



        // <함수 오버로딩>
        // 같은 이름의 함수를 매개변수를 달리하여 다른 함수로 재정의하는 기술
        // 같은 이름의 함수를 호출하여도 매개변수의 자료형에 따라 함수를 달리 호출할 수 있음

        int Multi(int left, int right) { return left * right; }
        float Multi(float left, float right) { return left * right; }
        double Multi(double left, double right) { return left * right; }


        static void Main(string[] args)
        {
            int result1 = Multi(2, 3);
            float result2 = Multi(2.9f, 3.5f);
            double result3 = Multi(5.1, 3.3);
        }        
    }
}