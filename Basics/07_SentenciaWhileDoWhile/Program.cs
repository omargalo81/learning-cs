namespace _07_SentenciaWhileDoWhile
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Iteración de i " + i);
                //i = i + 1;
                i++;
            }

            int j = 0;
            while(j < 100)
            {
                if (j > 20)
                {
                    break;
                }

                Console.WriteLine("Iteración de j " + j);
                j++;
            }

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

            int index = 0;
            while(index < friends.Length)
            {
                Console.WriteLine("Amigo: " + friends[index]);
                index++;
            }

            //Do while

            bool run = false;
            do
            {
                //Console.WriteLine("Entro una ves y ya");
                Show();

            } while (run);
        }

        static void Show()
        {
            Console.WriteLine("Entro una ves y listo");
        }
    }
}