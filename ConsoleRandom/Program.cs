namespace ConsoleRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] select = new string[]{ 
             "Cu",
            "Mn",
            "Fe",
            "Co_"
            };

            int randomIndex = random.Next(select.Length);
            Console.WriteLine($"今週は{select[randomIndex]}");

            Console.ReadKey();

            




        }
    }
}