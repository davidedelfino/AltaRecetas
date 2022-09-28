using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaRecetas.Dominio
{
    internal class Ingrediente
    {
        public int IdIngrediente { get; set; }
        public string Nombre { get; set; }

        public Ingrediente()
        {
            IdIngrediente = 0;
            Nombre = String.Empty;
        }

        public Ingrediente(int idIngrediente, string nombre)
        {
            IdIngrediente = idIngrediente;
            Nombre = nombre;

        }
    }
}
