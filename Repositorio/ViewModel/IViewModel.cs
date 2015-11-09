using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.ViewModel
{
    public interface IViewModel <TModelo> where TModelo:class
    {
        TModelo ToBaseDatos();
        void FromBaseDatos(TModelo modelo);
        void UpdateBaseDatos(TModelo modelo);
    }
}
