 namespace Helloworld
{

    enum Edirection
    {
        West,
        East,
        North,
        South
    }
    internal class Program
    {
        // Entry Point 
        // C# 프로그램은 반드시 어떤 함수에서 부터 시작해야한다.
        // 그 어떤 함수가 Main 함수 이다. 
        // arguments 
        static void Main(string[] args)
        {
            Edirection edirection = Edirection.West;

            if (edirection == Edirection.West)
            {
                Console.WriteLine("West");
            }
            Console.WriteLine("Hello, World!");

            int num3 = int.MaxValue;
            int result4 = num3 + 1;

            Console.WriteLine($"result4: {result4}");
        } 
    }
}