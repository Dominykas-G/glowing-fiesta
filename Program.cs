namespace HelloWorld
{
    class Soft{
       public static void write()
        {
            Console.WriteLine("This is from another class\a");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {   
           Soft.write();
           Console.WriteLine("Hello, World!");
        }
    }
}