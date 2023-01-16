namespace _06_Arreglos
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //Podemos definir el tamaño (número de elementos) de nuestro arreglo
            string[] friends = new string[7]
            {
                "Jorge",
                "Jonathan",
                "Daniel",
                "Gabriel",
                "Miguel",
                "Victor",
                null
            };

            Console.WriteLine("Nombre de tu amigo: " + friends[0]);
            Console.WriteLine("Nombre de tu amigo: " + friends[1]);
            Console.WriteLine("Nombre de tu amigo: " + friends[2]);
            Console.WriteLine("Nombre de tu amigo: " + friends[3]);
            Console.WriteLine("Nombre de tu amigo: " + friends[4]);
            Console.WriteLine("Nombre de tu amigo: " + friends[5]);
            Console.WriteLine("Nombre de tu amigo: " + friends[6]);

            friends[6] = "Evelyn";

            Console.WriteLine("Nombre de tu amigo: " + friends[6]);
        }
    }
}