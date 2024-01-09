﻿using System;
using System.Net.Security;
using System.Runtime.InteropServices;

namespace _01._Variable
{
    internal class Program
    {



        char input;

        string id;
        float cripercent;

        static void Main(string[] args)
        {
            //데이터를 어떻게 저장할지 형태가 필요하다. 결국 자료형
            /*****************************************************************
             * 자료형 (Data Type)
             * 
             * 자료(데이터)의 형태를 지정
             * 데이터가 메모리에 저장되는 형태와 처리되는 방식을 명시하는 역할
             * 0과 1만으로 구성된 컴퓨터에게 여러 형태의 자료를 저장하기 위함
             *****************************************************************/
            // 
            // <자료형 종류>
            // 자료형 이름      자료형 형태          메모리 크기     표현 범위
            //
            // - 논리형 -
            // bool             논리 자료형          1byte           true(0이 아니면), false(0) 1bit 아님 1byte 인거 기억해둘것
            //
            // - 정수형 (소수점 X) -
            // byte             부호없는 정수형      1byte              0 ~ 255 <-얘가 좀 특이케이스 얘랑 int만 외우고 나머진 굳이 외우진 마라
            // sbyte            부호있는 정수형      1byte           -128 ~ 127
            //
            // short            부호있는 정수형      2byte           -2^15 ~ 2^15 - 1     =>  -32,768 ~ 32,767 

            // int              부호있는 정수형      4byte           -2^31 ~ 2^31 - 1     =>  -2,147,483,648 ~ 2,147,483,647 대충 -21억부터 21억까지
            // int (인티저)말고는 굳이 외울필요없다잉
            // uint             부호있는 정수형      4byte           0 ~ 2^32 - 1         =>   0 ~ 4,294,967,295

            // signed
            // unsigned 

            // long             부호있는 정수형      8byte           -2^63 ~ 2^63 - 1     =>  -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
            //                                                                                
            // ushort           부호있는 정수형      2byte           0 ~ 2^16 - 1         =>   0 ~ 65,535
            // uint             부호있는 정수형      4byte           0 ~ 2^32 - 1         =>   0 ~ 4,294,967,295
            // ulong            부호있는 정수형      8byte           0 ~ 2^64 - 1         =>   0 ~ 18,446,744,073,709,551,615
            //                                                                                
            // - 실수형 (소수점 O) -                                                                     
            // float            부동소수점 실수      4byte           3.4e-38  ~ 3.4e+38   =>  약 소수점 7자리 일단 여기서 넘어가고 심화때 깊게 설명예정 계산이 빠르니가 이거 많이 쓸꺼임
            // double           부동소수점 실수      8byte           1.7e-308 ~ 1.7e+308  =>  약 소수점 15자리
            //
            // 부동 소수점이 뭘까 스스로 공부

            // - 문자형 - 
            // char             유니코드 문자형      2byte           'a', 'b', '한', ...  =>   한글자 ''
            // string           유니코드 문자열        X             "abcde", "안녕", ... =>   여러글자 ""

            // ASCII 코드라는걸 기억하라 -> 영어만 되서 유니코드라는게 추가되고 이걸로도 안되서 UTF-8

            /************************************************************************
             * 변수 (variable)
             * 
             * 데이터를 저장하기 위해 프로그램에 의해 이름을 할당받은 메모리 공간
             * 데이터를 저장할 수 있는 메모리 공간을 의미하며, 저장된 값은 변경 가능
             ************************************************************************/

            // <변수 선언 및 초기화>
            // 자료형의 선언하고 빈칸 뒤에 변수이름을 작성하여 변수 선언
            // 선언한 변수에 값을 처음 할당하는 과정을 초기화라고 함
            // 변수 선언과 초기화 과정을 동시에 진행할 수 있음


            int iValue = 10;   // int 자료형의 이름이 inValue인 변수에 10의 데이터를 초기화
            float fValue;      // float 자료형의 이름이 floatValue인 변수를 선언하지만 값을 초기화하지 않음
                               // int intValue;                    // error : 같은 이름의 변수는 사용 불가
                               // Console.WriteLine(floatValue);   // error : 선언한 변수에 값을 초기화하기 전까지 사용 불가

            // <변수에 데이터 저장>
            // =(대입연산자) 좌측에 변수를 배치
            iValue = 5;                         // iValue 변수에 5의 데이터 저장
            fValue = 1.2f;                      // fValue 변수에 1.2f 데이터를 초기화 // 소수점 뒤에 f 붙이면 float 소수점 1.2는 더블 소수점 1.2d = 1.2 기본이 더블

            // <변수의 데이터 불러오기>
            // 데이터가 필요한곳에 변수명을 ㅐ치
            // int rValue = 20;
            // int lValue = rValue;
            //  Console.WriteLine($"rValue 변수에 보관된 데이터는 {rValue} 입니다."); // $ 넣고 변수 꺼낼곳 {} 로 감싸주면 나옴<=최적회적으로 좋으니까 이렇게 써
            // Console.WriteLine($"lValue 변수에 보관된 데이터는 {lValue} 입니다.");

            // float level = 10.23456f;
            // Console.WriteLine($"당신의 레벨은 {level:F3}입니다.");// + level + 이건 웹개발자나 쓰는 방식 , :F3 소수점 셋째 자리까지만


            // 한번 정해놓고 변하지 못하게 해야하는 값이 있다. 그건 바로
            /*****************************************************************
            * 상수 (Constant)
            *
            * 프로그램이 실행되는 동안 변경할 수 없는 데이터
            * 프로그램에서 값이 변경되기를 원하지 않는 데이터가 있을 경우 사용
            * 저장된 값은 프로그램 종료시까지 변경 불가능
            ******************************************************************/


            // <상수 선언 및 초기화>
            // 변수 선언 앞에 const 키워드를 추가하여 상수 선언

            const int MAX = 10; // 변수 앞에 const 붙여주면 상수 고정됨
            const string gameName = "리그 오브 레전드";

           
            Console.WriteLine($"{MAX}");

            // const int MIN;  // error : 상수는 초기화 없이 사용 불가
            // MAX = 20        // error : 상수의 데이터 변경 불가



            //이 수많은걸 일일이 변수로 만들기 빡셀때

            /*******************************************************************
             * 배열 (Array)
             * 
             * 동일한 자료형의 요소들로 구성된 데이터 집합
             * 인덱스를 통하여 개개의 배열요소(Element)에 접근할 수 있음
             * 배열의 처음 요소의 인덱스는 0부터 시작함  
             *******************************************************************/

            //int[] exam = new int [26]; // 자료형 다음에 [] 붙여주면 배열임 뒤의 new int [26]은 26개의 자료를 만든다는것

            // exam[0] = 99;
            // exam[1] = 20;
            // exam[2] = 60;

            // <1차원 배열>
            // 1차원 배열의 선언은 자료형뒤에 []괄호를 추가하여 배열로 사용함을 선언
            // int[] iArray;                                   // int 배열 선언
            // iArray = new int[10];                           // int 데이터를 10개 가지는 배열 생성
            // iArray[0] = 20;                                 // 1차원 배열의 0번째 배열요소에 접근
            // 아래는 자동화 과정
            // float[] fArray = { 1.1f, 2.3f, 3.1f, 4.5f };    // 1차원 배열의 선언과 초기화, 배열의 크기는 초기화한 갯수만큼 자동으로 생성. 이러면 자동으로 0번째부터 3번째까지 세팅이 됨

            // <다차원 배열>
            // 다차원 배열의 선언은 자료형뒤에 []괄호를 추가하며, 추가하는 차원수만큼 ','를 추가
            // int[,] iMatrix = new int[5, 4];                         // 2차원 배열 선언, 이 경우 총 20개가 있는 모양 (5x4니까.)
            // int[,,] iCube = new int[3, 3, 3];                       // 3차원 배열 선언, 이 경우 27개가 있는 것 (3x3x3이니까)
            // iMatrix[2, 2] = 10;                                     // 2차원 배열의 2x2번째 배열요소에 접근
            // float[,] fMatrix = { { 1.1f, 2.3f }, { 3.1f, 4.5f } };  // 2차원 배열의 선언과 초기화, 배열의 크기는 초기화한 갯수만큼 자동으로 생성


            // Console.WriteLine(iMatrix[2, 2]);

            /*****************************************************************
             * 형변환 (Casting)
             *
             * 데이터를 선언한 자료형에 맞는 형태로 변환하는 작업
             * 다른 자료형의 데이터를 저장하기 위해선 형변환 과정을 거쳐야하며,
             * 이 과정에서 보관할 수 없는 데이터는 버려짐
             ******************************************************************/

            // <명시적 형변환 - 수동 >
            // 변환할 데이터의 앞에 변환할 자료형을 괄호안에 넣어 형변환 진행
            int damage = (int)29.9;            // 이때 기본적으로 29.9를 int로 변환하는 과정 중 보관할 수 없는 소수점이 버려짐
            // int damage = 29.9;              // error : 명시적 형변환 없이 변환 불가
            // ex
            float fff = (float)123.15638583663251;
            
           


            // <묵시적 형변환 - 자동 >
            // 변수에 데이터를 넣는 과정에서 자료형이 더 큰범위를 표현하는 경우 자동으로 형변환을 진행
            double ddd = (double)123.345f;      // 이경우는 float 가 double의 하위범위라서 자동형변환이 되므로 (double)을 날린다. 
            float f  = (float)123.45642365476;  // 이 경우는 더블을 플롯에 넣는 거니까 표기하고
            //그니까 데이터 손실이 있으면 반드시 표기 없으면 표기 안해도됨
            // 부동소수점형 변수에 정수형 데이터를 넣을 경우 자동형변환 가능
            // double doubleValue = 1.2f;          // double은 float를 포함하는 큰 범위이니 자동형변환 가능
            // doubleValue = (double)floatValue;   // 일반적으로 변수의 형변환 같은 경우 자동형변환이 가능하다 하더라도 형변환을 적어줌


            // <문자 형변환과 아스키코드 & 유니코드>
            // 아스키코드 : 이진법을 사용하는 컴퓨터에서 문자를 표현하기 위해 정해둔 문자와 숫자의 매칭표
            // 유니코드 : 영어만 표현이 가능했던 아스키코드에서 전세계의 모든 문자를 다루도록 설계한 매칭표
            // char key = (char)65; // 이러면 유니코드 65번 A가 나옴
            // int value = (int)'a'; // 이러면 97인가 나올거

            // Console.WriteLine($"유니코드 65는 {(char)65} 로 표현합니다.");
            // Console.WriteLine($"문자 'a'는 {(int)'a'} 로 처리합니다.");

            //문자는 단순한 방식으로 형변환이 안되서 추가되는 절차
            // <문자열 형변환>
            // 문자열은 단순형변환이 불가
            // 각 자료형의 Parse, TryParse를 이용하여 문자열에서 자료형으로 변환
            // 각 자료형에서 ToString을 이용하여 자료형에서 문자열로 변환

            int value = int.Parse("142");               // int.Parse를 통해 string 자료형을 int로 변환
            // int value = (int)"142";                  // error : 문자열 자료를 정수형 자료형으로 단순형변환은 불가능
            // int value = int.Parse("abc");            // error : 변환할 수 없는 문자열 자료를 정수형으로 변환하려 시도하는 경우 예외 발생


            int hp;
            int.TryParse("100", out hp);
            // float percent = float.Parse("0.2");


            bool fail = int.TryParse("abc", out value);         // 변환이 불가한 문자열이므로, fail은 false, value는 0이 결과로 나옴
            bool successs = int.TryParse("123", out value);     // 변환이 가능한 문자열이므로, success는 true, value는 변환 결과가 나옴

            //역으로 숫자를 문자로?

            string hundred = 100.ToString();
            string aaaa = 10.2f.ToString();
            string valueTostiong = value.ToString();


        }
    }
}