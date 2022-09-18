using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftware2022.Application.Options;
using ProyectoSoftware2022.Data.Models;

namespace ProyectoSoftware2022.Application
{
    class CrearClientes
    {
       /* private string nombre;
        private string apellido;
        private int dni;
        private string email;

        public CrearClientes(string _nombre, string _apellido, int _dni, string _email)
        {
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.dni = _dni;
            this.email = _email;
        }*/

        public bool CrearCliente(string _nombre, string _apellido, string _dni, string _email) {
            

            ValidarCliente Validar = new ValidarCliente();
            Cliente cliente = new Cliente();
            

            if ((Validar.Valido(_nombre, _apellido, _dni, _email))==true)
            {
                cliente.Nombre = _nombre;
                cliente.Apellido= _apellido;
                cliente.DNI = _dni;
                cliente.Email = _email;
                using (var db = new MyDbContext()){
                    db.clientes.Add(cliente);
                    db.SaveChanges();
                }
                Console.WriteLine("Datos Guardados");
                return true;
            }
            else {
                Console.WriteLine("Datos Erroneos");
                return false;
            }          
        }
    }

}
