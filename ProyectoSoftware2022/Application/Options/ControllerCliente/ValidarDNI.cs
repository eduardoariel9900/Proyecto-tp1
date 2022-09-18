using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftware2022.Data.Models;

namespace ProyectoSoftware2022.Application.Options
{
    class ValidarDNI
    {
        //Verifica el DNI del cliente
        public bool _dniValido(string _dni)
        {
            using (var contexto = new MyDbContext())
            {
                var ListClient = contexto.clientes.Where(X => X.DNI == _dni).ToList();
                if (ListClient.Count == 0)
                {
                    Console.WriteLine("No se ha encontrado cliente con el DNI: " + _dni);
                    return true;
                }

                else
                {
                    Console.WriteLine("Se encontro un cliente con el DNI:" + _dni);
                    return false;
                }
            }
        }
    }
}
