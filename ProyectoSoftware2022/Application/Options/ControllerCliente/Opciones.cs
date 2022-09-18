using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftware2022.Data.Models;
using ProyectoSoftware2022.Data;
using ProyectoSoftware2022.Data.Queries;

namespace ProyectoSoftware2022.Application.Options.ControllerCliente
{
    class Opciones
    {
        public void NuevoCliente() {//Opcion N°1 del Menu.
            Console.Clear();
            _Menu _M = new _Menu();
            CrearClientes _CrearCliente = new CrearClientes();
            ValidarDNI _ValidarDNI = new ValidarDNI();

            bool Verifycarted = false;
            string DNI = "";
            string Nombre = "";
            string Apellido = "";
            string Email = "";
            List<Cliente> cliente= null;
            while (!Verifycarted)
            {
                try
                {
                    //Ingreso de los datos.
                    Console.WriteLine("Ingrese su DNI.");
                    int Verificador = int.Parse(Console.ReadLine());
                    DNI = Verificador.ToString();
                    if (_ValidarDNI._dniValido(DNI)==true)
                    {
                        Console.WriteLine("Ingrese su Nombre.");
                        Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su Apellido.");
                        Apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese su Email.");
                        Email = Console.ReadLine();
                        Verifycarted = true;
                        _CrearCliente.CrearCliente(Nombre, Apellido, DNI, Email);
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Uno de los datos es erroneo.");
                }
            }
            Console.Clear();
            _M._MENU();
        }
    }
}
