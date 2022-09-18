using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftware2022.Data.Models;

namespace ProyectoSoftware2022.Data.Commans
{
    class CrearAlquileres
    {
        EstadoDeAlquileres Estado_Alquiler = new EstadoDeAlquileres();

        public Alquileres CrearAlquiler(Cliente _cliente_Id,EstadoDeAlquileres _estado_Id,Libros _libro_idx, DateTime fecha_Alquiler, DateTime fecha_devolucion) {
            using (var Contexto = new MyDbContext()) {
                using (var DB = Contexto.Database.BeginTransaction()) { 
                    Alquileres alquileres = new Alquileres();
                    DateTime _fechareserva = DateTime.Now;

                    alquileres.cliente_idx = _cliente_Id.ClienteId;
                    alquileres.ISBN_idx = _libro_idx.ISBN;
                    alquileres.estado_idx = _estado_Id.EstadoId;
                    alquileres.FechaAlquiler = fecha_Alquiler;
                    alquileres.FechaReserva = _fechareserva;
                    alquileres.FechaDevolucion = fecha_devolucion;
                    Contexto.alquileres.Add(alquileres);
                    Contexto.SaveChanges();
                    return alquileres;
                }
            }  
        }
    }
}
