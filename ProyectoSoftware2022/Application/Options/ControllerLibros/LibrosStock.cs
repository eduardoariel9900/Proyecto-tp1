using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftware2022.Data.Models;
using ProyectoSoftware2022.Data.Queries;


namespace ProyectoSoftware2022.Application.Options.ControllerLibros
{
    class LibrosStock
    {
        public void ListaLibro() {
            LibrosEnStock lista = new LibrosEnStock();
            List<Libros> l = lista.ListaLibros();
            _Menu M = new _Menu();

            Console.WriteLine("Lista de los Libros con Stock Disponible");
            foreach (Libros X in l)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("ISBN: " + X.ISBN);
                Console.WriteLine("Titulo: "+ X.Titulo);
                Console.WriteLine("Autor" + X.Autor);
                Console.WriteLine("Editorial" + X.Editorial);
                Console.WriteLine("Edicion" + X.Edicion);
                Console.WriteLine("Imagen" + X.Imagen);
                Console.WriteLine("El libro " + X.Titulo +" tiene disponible " + X.Stock +" Ejemplares");
                Console.WriteLine("--------------------------------------------------\n\n");
                
            }
            Console.ReadKey();
            Console.Clear();
            M._MENU();
        }
    }
}
