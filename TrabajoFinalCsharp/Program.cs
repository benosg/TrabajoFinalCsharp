using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu Principal \n");
            Console.Write("1º) Usuario" + "\n" + "2º) Ingresar OC" + "\n" + "3º) Ingresar Factura" + "\n" + "4º) Salir" + "\n");
            Console.WriteLine("Seleccione una opción: ");
            ConsoleKeyInfo op = Console.ReadKey();
            switch (op.KeyChar)
            {
                case '1':
                    Console.Clear();
                    
                    menuUsuario();
                    break;
                case '2':

                    break;
                case '3':

                    break;
                case '4':
                    Console.Write("Saliendo..");
                    System.Environment.Exit(-1);
                    break;
            }
           
        }
        static void menuUsuario()
        {
            Console.Clear();
            for (; ; )
            {
                Console.WriteLine("Menu Usuario \n");
                Console.Write("1º) Crear" + "\n" + "2º) Eliminar" + "\n" + "3º) Buscar" + "\n" + "4º) Volver" + "\n");
                Console.WriteLine("Seleccione una opción: ");

                ConsoleKeyInfo op = Console.ReadKey();

                switch (op.KeyChar)
                {
                    case '1':

                        break;
                    case '2':

                        break;
                    case '3':

                        break;
                    case '4':
                        Menu();
                        break;

                }
            }
        }
    }
}
