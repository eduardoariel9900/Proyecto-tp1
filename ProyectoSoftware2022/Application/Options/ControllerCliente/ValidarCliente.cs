using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftware2022.Data.Models;

namespace ProyectoSoftware2022.Application.Options
{
    class ValidarCliente
    {
        //Aca tengo q validar que el cliente no exista

        public bool Valido(string _nombre, string _apellido, string _dni, string _email){
            
            if (((_nombre!="")&&(_apellido!="")&&(_dni!="")&&(_email!="")))
            {
                Console.WriteLine("Los datos no son vacios");
                return true;
            }
            if ((_nombre != null) && (_apellido != null) && (_dni != null) && (_email != null))
            {
                Console.WriteLine("Los datos no son Nulls");
                return true;
            }
            return false;
        }
    }
}
