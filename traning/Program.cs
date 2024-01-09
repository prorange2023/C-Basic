using System;
​
class TestDeepCopy
{
    public int field1;
    public int field2;
​
    public TestDeepCopy DeepCopy()
    {
        TestDeepCopy copy = new TestDeepCopy();
        copy.field1 = this.field1;
        copy.field2 = this.field2;
​
        return copy;
    }
​
    public void Print()
    {
        Console.WriteLine("{0} {1}", field1, field2);
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            {
                TestDeepCopy source = new TestDeepCopy();
                source.field1 = 10;
                source.field2 = 20;
​
            TestDeepCopy target = source;
                target.field2 = 30;
​
            source.Print();
                target.Print();
            }
​
        Console.WriteLine("Deep Copy");
            {
                TestDeepCopy source = new TestDeepCopy();
                source.field1 = 10;
                source.field2 = 20;
​
            TestDeepCopy target = source.DeepCopy();
                target.field2 = 30;
​
            source.Print();
                target.Print();
            }
        }
    }
}