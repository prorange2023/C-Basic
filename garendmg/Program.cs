using System.Data.SqlTypes;
using System.Net.Security;
using System.Reflection.Emit;

namespace traning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("레벨을 입력하세요 : ");
            int level = int.Parse(Console.ReadLine());
            
            if( level >=1 && level <= 18)
                { 
          
                int hp = 690;
                int lhpu = 98;
                int php = 0 + ((level-1) * lhpu);
                int bhp = 690 + php;
                float hprz = 8.0f;
                float lhprzu = 0.5f;
                float atk = 69.0f;
                float latku = 4.5f;
                float ats = 0.625f *(1+0.0365f*(level-1));
                float latsu = 0.0365f*(level-1);
                float def = 38;
                float ldefu = 4.2f;
                float mres = 32.0f;
                float lmresu = 1.55f;
                float range = 175;
                float ms = 340;
                float Qdmg = 30;
                float Wshield = 65;
                float Edmg = 4;
                float Rdmg = 4;
                float Elohp = 0;
                float eSpin = 7;

                Console.Write("가렌 Q스킬의 데미지 수치는 ");
                Console.WriteLine($"{(Qdmg + (atk + (latku * (level-1))) * 1.5):F0}");
                Console.Write("가렌 W스킬의 실드 수치는 ");
                Console.WriteLine($"{(Wshield + (php * 1.018)):F0}");
                Console.Write("가렌 E스킬의 데미지 수치는 ");
                Console.WriteLine($"회전당 {(Edmg + (atk * 0.32)):F0}, 총데미지는 {(Edmg + (atk * 0.32))*(7+(int)((latsu*(level-1))*0.25)):F0}");
                Console.Write("가렌 R스킬의 데미지 수치는 ");
                Console.WriteLine($"{(Rdmg + (atk * 0.25)):F0}");
            }

            else
            {

            }
        }
    }
}