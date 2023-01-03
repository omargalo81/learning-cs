namespace _03_Funciones
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //El proposito de una función es empaquetar una funcionalidad
            //para poder reutilizarla

            // int a = 1;
            // int b = 2;

            // int c = a + b;
            // int d = a + b;

            Mostrar(); //Aqui se invoca la función Mostrar

            Suma(7,5);
            Suma(5, 9);
            Suma(4, 5);

            //Invocar la función Multiplica que nos regresa un dato
            int m = Multiplica(7,5);
            Console.WriteLine(m);
        }

        static void Suma(int num1, int num2) // num1 y num2 son los parametros
        {
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }

        //Esta es una función que solo recibe parametros
        static void Mostrar()
        {
            Console.WriteLine("Hola, soy un texto");
        }

        //Esta es una función que recibe parametros y regresa un dato
        static int Multiplica(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}