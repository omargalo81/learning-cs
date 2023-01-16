namespace _09_ClasesYObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un objeto es una representación de una entidad
            //que tiene propiedades y funcionalidades

            //Una clase es el molde que sirve para crear ese objeto
            //La clase es la definición de este objeto

            Venta venta1 = new Venta(70, DateTime.Now);
            Venta venta2 = new Venta(90, DateTime.Now);
            Venta venta3 = new Venta(120, DateTime.Now);
            venta1.Mostrar();
            Console.WriteLine(venta1.GetInfo());
            Console.WriteLine(venta2.GetInfo());
            Console.WriteLine(venta3.GetInfo());
        }
    }

    class Venta
    {
        int total;
        DateTime fecha;

        //Constructor

        public Venta(int total, DateTime fecha)
        {
            this.total = total;
            this.fecha = fecha;
        }

        public string GetInfo()
        {
            return total + " " + fecha.ToLongDateString();
        }
        public void Mostrar()
        {
            Console.WriteLine("Hola soy una venta");
        }
    }
}