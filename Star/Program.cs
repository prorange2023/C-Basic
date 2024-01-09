using System.ComponentModel.Design;

namespace Star
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            do
            {
                Console.Write("1에서 9 사이의 수를 입력하세요.");
                string text = Console.ReadLine();
                input = int.Parse(text);
            } while (input < 1 || 9 < input);


        }
    }
}