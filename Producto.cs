using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCoder
{
    public class Producto
    {
        public int Id { get; private set; }
        public string Descripcion { get; set; }
        public int Costo { get; set; }
        public int PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; private set; }

        public Producto()
        {
            Id = 0;
            Descripcion = string.Empty;
            Costo = 0;
            PrecioVenta = 0;
            Stock = 0;
            IdUsuario = 0;
        }

        public Producto(int id, string descripcion, int costo, int precioVenta, int stock, int idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }

    }
}
