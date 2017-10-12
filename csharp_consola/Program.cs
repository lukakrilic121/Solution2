using System;


namespace csharp_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            for(int i = 0; i < 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.WriteLine("Hellow world");
            Console.ReadKey();
        }
    }
}
