using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Model;

namespace Repositorio.ViewModel
{
    public class ViewModelProducto : IViewModel<Producto>
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public string Fabricante { get; set; }
        public double Precio_Coste { get; set; }
        public double Precio_Venta { get; set; }
        public int idCategoria { get; set; }

        public void FromBaseDatos(Producto modelo)
        {
            throw new NotImplementedException();
        }

        public Producto ToBaseDatos()
        {
            throw new NotImplementedException();
        }

        public void UpdateBaseDatos(Producto modelo)
        {
            throw new NotImplementedException();
        }
    }

}
