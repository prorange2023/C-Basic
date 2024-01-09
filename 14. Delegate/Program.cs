namespace _14._Delegate
{
    internal class Program
    {

        /****************************************************************
         * 대리자 (Delegate)
         * 
         * 특정 매개 변수 목록 및 반환 형식이 있는 함수에 대한 참조
         * 대리자 인스턴스를 통해 함수를 호출 할 수 있음
         * 요약하면 함수 보관하는 변수다
         ****************************************************************/

        // <델리게이트 정의>
        // delegate 반환형 델리게이트이름(매개변수들);

        public delegate float Delegate1(float left, float right);

        public delegate void Delegate2(string str);
        public float Add(float left, float right) { return left + right; }
        public float Minus(float left, float right) { return left + right; }

        public void Message(string message) { Console.WriteLine(message); }
        void Main1()
        {
            int value = 2;

            Delegate1 delegate1 = Add;

            float result = delegate1(1.2f, 3.4f); // Add(1.2f, 3.4f) == 4.6f

            delegate1 = Minus;
            result = delegate1(3.4f, 1.2f); // Minus(3.4f, 1.2f) == 2.2f

            // delegate1 = Message; 
            // delegate 는 반환형과 매개변수 자료형이 일치한 함수만 담을수 있음
            Delegate2 delegate2 = Message;

            
        }
        // <델리게이트 사용>
        // 반환형과 매개변수가 일치하는 함수를 델리게이트 변수에 할당
        // 델리게이트 변수에 참조한 함수를 대리자를 통해 호출 가능
        //void Main1()
        //{
        //    DelegateMethod1 delegate1 = new DelegateMethod1(Plus);  // 델리게이트 인스턴스 생성
        //    DelegateMethod2 delegate2 = Message;                    // 간략한 문법의 델리게이트 인스턴스 생성

        //    delegate1.Invoke(20, 10);   // Plus(20, 10);            // Invoke를 통해 참조되어 있는 함수를 호출
        //    delegate2("메세지");        // Message("메세지");       // 간략한 문법의 델리게이트 함수 호출

        //    delegate1 = Plus;
        //    Console.WriteLine(delegate1(20, 10));       // output : 30
        //    delegate1 = Minus;
        //    Console.WriteLine(delegate1(20, 10));       // output : 10
        //    delegate1 = Multi;
        //    Console.WriteLine(delegate1(20, 10));       // output : 200
        //    delegate1 = Divide;
        //    Console.WriteLine(delegate1(20, 10));       // output : 2

        //    // delegate2 = Plus;        // error : 반환형과 매개변수가 일치하지 않은 함수는 참조 불가
        //}

        static void Main(string[] args)
    }
}
