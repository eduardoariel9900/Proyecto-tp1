using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSoftware2022.Data.Models
{
    public class Alquileres
    {
        public int Id { get; set; }
        public int cliente_idx { get; set; }
        public virtual Cliente? clientes { get; set; } = null;
        public int estado_idx{ get; set; }
        public virtual EstadoDeAlquileres? estados { get; set; } = null;
        public string ISBN_idx { get; set; }
        public virtual Libros? ISBN { get; set; } = null;
        public DateTime? FechaAlquiler { get; set; } = null;
        public DateTime? FechaReserva { get; set; } = null;
        public DateTime? FechaDevolucion { get; set; } = null;

    }
}


