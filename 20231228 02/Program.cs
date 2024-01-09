namespace _20231228_02
{
    internal class Program
    {
        class Monster
        {
            public string name;
            public int hp;

            public void TakeHit(int damage)
            {
                hp -= damage;
                Console.WriteLine($"{name}이/가 데미지를 받아 체력이 {hp}가 되었습니다.");
            }

            
        }
        static void Main(string[] args)
        {
            
        }
    }
}
