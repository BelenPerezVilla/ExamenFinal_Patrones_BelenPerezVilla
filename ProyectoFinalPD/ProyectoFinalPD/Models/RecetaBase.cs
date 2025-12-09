using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Controladores
{
    public class RecetaBase:IRecetaComponent
    {
        public string Nombre { get; set; }
        public double PrecioBase { get; set; }

        public RecetaBase(string nombre, double precio)
        {
            Nombre = nombre;
            PrecioBase = precio;
        }
        public string Descripcion
        {
            get { return Nombre; }
        }
        public double Costo
        {
            get { return PrecioBase; }
        }
    }
}
