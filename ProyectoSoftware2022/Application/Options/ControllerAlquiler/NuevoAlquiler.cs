using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftware2022.Data.Commans;
using ProyectoSoftware2022.Data.Queries;
using ProyectoSoftware2022.Data.Models;
using ProyectoSoftware2022.Application.Options.ControllerLibros;

namespace ProyectoSoftware2022.Application.Options.ControllerAlquiler
{
    class NuevoAlquiler
    {
        public void Nuevo_Alquiler() {
            Console.Clear();
            _Menu _MENU = new _Menu();

            ValidarDNI validarDNI = new ValidarDNI();
            Validar_ISBN validar_ISBN = new Validar_ISBN();
            
            Libros libro_Alquiler = new Libros();
            EstadoDeAlquileres Estado_Alquiler = new EstadoDeAlquileres();

            CrearAlquileres crearAlquileres = new CrearAlquileres();
            LibrosEnStock Lista_ISBN = new LibrosEnStock();//Id_Libro-Nombre.
            ListaCliente Lista_cliente_Id = new ListaCliente();//Id_Cliente-Nombre-Apellido.     

            Cliente cliente_Alquiler = null; //Cliente_Alquiler
            Libros Libro_Alquiler = null;
            List<Libros> ListLibro = Lista_ISBN.ListaLibros();           

            bool Alquilado=false;

            while (!Alquilado)
            {
                try
                {

                    Console.WriteLine("Ingrese el DNI del Cliente: ");
                    int Verificador = int.Parse(Console.ReadLine());
                    String _dni = Verificador.ToString();
                    if (!validarDNI._dniValido(_dni))//Crear una funcion de existe cliente
                    {
                        cliente_Alquiler = new ListaCliente().Cliente_Idx(_dni);                       
                        //int Alquiler_ClienteId = cliente_Alquiler.ClienteId;//Este Guardo en el Alquiler                       
                    }
                    else
                    {
                        Console.WriteLine("El Usuario no Existe: ");
                        Console.ReadKey();
                        _MENU._MENU();
                    }


                    Console.WriteLine("Lista de Libros Disponibles");
                    foreach (Libros l in ListLibro)
                    {
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.WriteLine("ISBN: " + l.ISBN);
                        Console.WriteLine("Titulo: " + l.Titulo);
                        Console.WriteLine("-----------------------------------------------------------");
                    }

                    Console.WriteLine("Ingrese el ISBN del Libro: ");
                    string _ISBN = Console.ReadLine();
                    if (!validar_ISBN._ISBN_Valido(_ISBN))//cambiar aca
                    {
                        libro_Alquiler = new LibrosEnStock().Libro_Idx(_ISBN);
                        string Alquiler_Isbn = libro_Alquiler.ISBN;//Guardar ESTO EN ALQUILER                       
                    }
                    else
                    {
                        Console.WriteLine("El Libro no Existe: ");
                        Console.ReadKey();
                        _MENU._MENU();
                    }
                    DateTime dia = DateTime.Now;
                    //CREO Lista de estado 
                    ListaEstado listaestado = new ListaEstado();
                    Estado_Alquiler = listaestado.Estado_Idx("Alquilado");

                    //Traigo si ID SEGUN LA DESCRIPCION
                    //lO PONGO EN LA CREACION DE ALQUILER
                    crearAlquileres.CrearAlquiler(cliente_Alquiler,Estado_Alquiler, libro_Alquiler,dia,dia.AddDays(7));
                                          
                    //Pongo los datos y los mando a guardar
                    Console.WriteLine("Esta seguro que quiere Alquilar ese Libro:");//Agrego nombre del libro y fecha de devolucion
                    Console.WriteLine("Ingrese S/N ");
                    string x = Console.ReadLine().ToLower();
                    
                    if (x=="s")
                    {
                        //Guardo los datos
                    }
                    else
                    {
                        _MENU._MENU();
                    }                        
                }
                catch (Exception)
                {
                    Console.WriteLine("Algo salio mal");
                    throw;
                }
            }            
         }
    }
}
