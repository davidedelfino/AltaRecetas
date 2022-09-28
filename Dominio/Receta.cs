using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaRecetas.Dominio
{
    internal class Receta
    {
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public string Cheff { get; set; }
        public List<DetalleReceta> Detalles { get; set; }

        public Receta()
        {
            Detalles = new List<DetalleReceta>();
        }

        public void AgregarDetalle(DetalleReceta oDetalle)
        {
            Detalles.Add(oDetalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }

        public int CantidadDetalles()
        {
            return Detalles.Count;
        }
    }
}
