using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftware2022.Data.Models;

namespace ProyectoSoftware2022.Application.Options.ControllerLibros
{
    class Validar_ISBN
    {
        public bool _ISBN_Valido(string _ISBN)
        {
            using (var contexto = new MyDbContext())
            {
                var ListClient = contexto.libros.Where(X => X.ISBN == _ISBN).ToList();
                if (ListClient.Count == 0)
                {
                    Console.WriteLine("No se ha encontrado cliente con el DNI: " + _ISBN);
                    return true;
                }
                else
                {
                    Console.WriteLine("Se encontro un cliente con el DNI:" + _ISBN);
                    return false;
                }
            }
        }
    }
}
