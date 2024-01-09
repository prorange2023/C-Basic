using System.Globalization;

namespace prorange001
{
    internal class Program
    {
        public int[] solution(int numer1, int denom1, int numer2, int denom2)
        {

            // 1단계
            int child1 = numer1 * denom2;
            int child2 = numer2 * denom1;
            int parent = denom1 * denom2;

            // 2단계
            int child = child1 + child2;

            // 3단계
            // 최대공약수 찾는 법 알아봐라
            int[] answer = new int[2];
            int a = child;

            while (true)
            {
                a = child % parent;
                parent = child;

                if (a == 0)
                {
                    break;
                }
                parent = 0; 
            }

            answer = new int[] {parent, parent*child/}
            
            
            //for (int i = 2; i <= child; i++)
            //{
            //    if (parent % i == 0 && child % i == 0)
            //    {
            //        parent = parent / i;
            //        child = child / i;
            //        i--;
            //    }

            //}
            return new int[] { child, parent };
        }
            static void Main(string[] args)
        {
            

        }
    }
}