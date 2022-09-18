using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftware2022.Application.Options.ControllerLibros;
using ProyectoSoftware2022.Data.Commans;
using ProyectoSoftware2022.Application.Options.ControllerCliente;
using ProyectoSoftware2022.Application.Options.ControllerAlquiler;

namespace ProyectoSoftware2022.Application
{
    public class _Menu
    {
        public void _MENU()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                               Municipalidad 9 de Julio                                           |");
            Console.WriteLine("|                                                    Menu Principal                                                |");
            Console.WriteLine("|                                                                                                                  |");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("\n");
            Console.WriteLine("1)Crear Cliente.");
            Console.WriteLine("2)Crear Alquiler.");
            Console.WriteLine("3)Crear Reserva.");
            Console.WriteLine("4)Enlistar Reservas de Libros.");
            Console.WriteLine("5)Libros que tenemos en Stock.");
            Console.WriteLine("6)Salir de la Aplicacion");

            Console.Write("\n\nSelecciona una Opcion.\n");
            try
            {
                int Valor = int.Parse(Console.ReadLine());
                switch (Valor)
                {
                    case 1:
                        Opciones OP1 = new Opciones();
                        OP1.NuevoCliente();
                        break;
                    case 2:
                        NuevoAlquiler NuevoAlquiler = new NuevoAlquiler();
                        NuevoAlquiler.Nuevo_Alquiler();
                        break;
                    case 3:
                        break;
                    case 4:                     
                        break;
                    case 5:
                        LibrosStock librostock = new LibrosStock();
                        librostock.ListaLibro();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del Programa");
                        break;
                    default:
                        throw new Exception();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El dato Ingresado es erroneo");
                Thread.Sleep(5000);
                Console.Clear();
                _MENU();
            }
        }
    }
}
