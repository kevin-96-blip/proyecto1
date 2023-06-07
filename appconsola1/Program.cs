

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace holamundo
{
    class program
    {
        private static void Main(string[] args)
        {

            Console.Write("Ingrese el número de filas del triángulo: ");
            int numeroFilas = Convert.ToInt32(Console.ReadLine());

            for (int fila = 1; fila <= numeroFilas; fila++)
            {
                for (int columna = 1; columna <= fila; columna++)
                {
                    Console.Write("*");
                }
            }
        }
    }

    class Persona
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }

        public Persona(int id, string name, string desc)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
        }

        public void getInfo()
        {
            Console.WriteLine(id+" "+name);
        }

        public int? getID(int? id)
        {
            return this.id;
        }
    }
}
