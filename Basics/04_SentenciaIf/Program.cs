namespace _04_SentenciaIf
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            bool tienesHambre = true;
            bool tienesDinero = true;

            if (tienesHambre && tienesDinero && EstaAbiertoRestaurant("El paisa", 8))
            //En lugar de && puedes usar ||
            {
                Console.WriteLine("¡Adelante, buen provecho!");
            }
            else
            {
                Console.WriteLine("¡Moriras de hambre!");
            }
        }

        static bool EstaAbiertoRestaurant(string nombre, int hora = 0)
        {
            if (nombre == "El paisa" && hora >= 8 && hora <= 23)
            {
                return true;
            }
            else if (nombre == "Restaurant 24 horas")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}