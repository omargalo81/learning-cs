namespace _08_SentenciaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7]
            {
                "Jorge",
                "Jonathan",
                "Daniel",
                "Gabriel",
                "Miguel",
                "Victor",
                "Ruben"
            };

            bool run = true;
            for (int i = 0; i < friends.Length && run; i++)
            {
                Console.WriteLine(friends[i]);
            }
        }
    }
}