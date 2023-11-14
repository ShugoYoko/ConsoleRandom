namespace ConsoleRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] select = new string[]{ 
             "カレー",
            "とんかつ",
            "ラーメン",
            "チャーハン",
            "ケーキ",
            "茶碗蒸し"
            };

            int randomIndex = random.Next(select.Length);
            Console.WriteLine($"今週は{select[randomIndex]}");

            Console.ReadKey();

            




        }
    }
}