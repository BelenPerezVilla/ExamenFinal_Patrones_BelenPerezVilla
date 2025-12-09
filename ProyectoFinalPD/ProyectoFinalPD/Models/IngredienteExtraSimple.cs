using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Controladores
{
    public class IngredienteExtraSimple : IngredienteDecorator
    {
        private string _nombre;
        private double _precio;

        public IngredienteExtraSimple(IRecetaComponent receta, string nombre, double precio)
            : base(receta)
        {
            _nombre = nombre;
            _precio = precio;
        }

        public override string Descripcion
        {
            get { return _receta.Descripcion + " + " + _nombre; }
        }

        public override double Costo
        {
            get { return _receta.Costo + _precio; }
        }

    }
}
