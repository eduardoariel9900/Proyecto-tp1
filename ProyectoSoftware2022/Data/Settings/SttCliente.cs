using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoSoftware2022.Data.Models;

namespace ProyectoSoftware2022.Data.Settings
{
    class SttCliente
    {
        public SttCliente(EntityTypeBuilder<Cliente> BuilderCliente) {
            //Primary Key.
            BuilderCliente.HasKey(X => X.ClienteId);

            //Others Entitys.
            BuilderCliente.Property(X => X.DNI).HasMaxLength(10).IsRequired();
            BuilderCliente.Property(X => X.Nombre).HasMaxLength(45).IsRequired();
            BuilderCliente.Property(X => X.Apellido).HasMaxLength(45).IsRequired();
            BuilderCliente.Property(X => X.Email).HasMaxLength(45).IsRequired();

            //Foraing Key.
           // BuilderCliente.HasMany(X => X.Alquiler_C).WithOne(Z => Z.clientesId).HasForeignKey(X => X.Id);
            //Esto no se si esta del todo bien hecho.
        }



    }
}
