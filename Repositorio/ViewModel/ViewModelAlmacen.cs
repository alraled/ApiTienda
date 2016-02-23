using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Model;

namespace Repositorio.ViewModel
{
    public class ViewModelAlmacen : IViewModel<Almacen>
    {


        public string Ciudad { get; set; }
        public int CP { get; set; }
        public int idAlmacen { get; set; }




        public Almacen ToBaseDatos()
        {
            var al = new Almacen()
            {
                Ciudad = Ciudad,
                CP = CP
            };
            return al;
        }

        public void FromBaseDatos(Almacen modelo)
        {
            Ciudad = modelo.Ciudad;
            CP = modelo.CP;
        }

        public void UpdateBaseDatos(Almacen modelo)
        {
            modelo.Ciudad = Ciudad;
            modelo.CP = CP;
        }

        public object[] GetKeys()
        {
            return new[] {Ciudad};
        }
    }
}
