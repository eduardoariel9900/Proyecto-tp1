using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoSoftware2022.Data.Models;

namespace ProyectoSoftware2022.Data.Settings
{
    class SttAlq
    {
        public SttAlq(EntityTypeBuilder<Alquileres> BuilderAlq) {
            //Primary Key.
            BuilderAlq.HasKey(X => X.Id);

            //Others Entitys.
            BuilderAlq.Property(X => X.FechaAlquiler).IsRequired();
            BuilderAlq.Property(X => X.FechaDevolucion).IsRequired();
            BuilderAlq.Property(X => X.FechaReserva).IsRequired();
           // BuilderAlq.Property(X => X.clientesId);
           // BuilderAlq.Property(X => X.ISBNId);
           // BuilderAlq.Property(X => X.estadosId);
        }   
        
    }
}
