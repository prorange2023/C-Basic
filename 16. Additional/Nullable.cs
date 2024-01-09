using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional
{
    internal class Nullable
    {

        public class Item
        {
            public string name;

            public void Use()
            {

            }

        }
        void Main()
        {
            // <Nullable 타입>
            // 값형식의 자료형들은 null을 가질 수 없음
            // 값을 안갖고 있다는 표현을 하고 싶을 때 
            // int? value = null;
            // 클래스에도 되지만 굳이 써야하나? 하는 의견이 많음 어차피 참조라
            // 값형식에도 null을 할당할 수 있는 Nullable 타입을 지원
            bool? b = null;
            int? i = 20;
            if (b != null) Console.WriteLine(b);    // b 값이 null이 아닐때만 써달라 아닌가
            if (i.HasValue) Console.WriteLine(i);   // i 값이 있으므로 20 출력


            // <Null 조건연산자>
            // ? 앞의 객체가 null 인 경우 null 반환
            // ? 앞의 객체가 null 이 아닌경우 접근
            Item item = null;
            //if (item != null)
            //{ 
            //string name = item.name;

            //}

            //if (item != null)
            //{
            //    item.Use();

            //}
            // 위 요약하면

            Console.WriteLine($"{item?.name}");
            item?.Use();
            //이상

            item = new Item() { name = "포션" };
            //if (item != null)
            //{
            //    string name = item.name;

            //}

            //if (item != null)
            //{
            //    item.Use();

            //}

            // 위 요약한게 아래
            string name = item?.name;
            item?.Use();




            NullClass instance = null;
            // instance.Func();                     // 예외발생 : instance가 null 이므로 접근할 객체가 없음
            Console.WriteLine(instance?.value);     // instance?.value는 null 반환
            instance?.Func();                       // instance?.Func()은 null 반환

            instance = new NullClass();
            Console.WriteLine(instance?.value);     // instance?.value는 5 반환
            instance?.Func();                       // instance?.Func()은 함수 호출


            // <Null 병합연산자>
            // ?? 앞의 객체가 null 인 경우 ?? 뒤의 객체 반환
            // ?? 앞의 객체가 null 이 아닌경우 앞의 객체 반환
            int[] array = null;
            int length = array?.Length ?? 0;        // 배열이 null 인경우 0 반환, 아닌경우 배열의 크기 반환


            // <Null 병합할당연산자>
            // ??= 앞의 객체가 null 인 경우 ??= 뒤의 객체를 할당
            // ??= 앞의 객체가 null 인 아닌경우 ??= 뒤의 객체를 할당하지 않음
            NullClass nullClass = null;
            nullClass ??= new NullClass();          // nullClass 가 null이므로 새로운 인스턴스 할당
            nullClass ??= new NullClass();          // nullClass 가 null이 아니므로 새로운 인스턴스 할당이 되지 않음
        }

        public class NullClass
        {
            public int value = 5;

            public void Func() { }
        }



    }
}
