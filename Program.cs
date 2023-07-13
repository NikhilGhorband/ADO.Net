namespace ADODotNetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Customer.CreateDatabase();
            Customer.CreateTable();
            
        }
    }
}