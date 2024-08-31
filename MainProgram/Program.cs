using DLLFile;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();

            Console.WriteLine("Hello, World!");

            Console.WriteLine(obj.Method());

            Console.ReadLine();
        }
    }
}
