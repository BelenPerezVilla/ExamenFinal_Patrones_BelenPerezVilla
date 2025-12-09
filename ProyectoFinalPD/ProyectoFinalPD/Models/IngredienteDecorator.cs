using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Controladores
{
    public abstract class IngredienteDecorator : IRecetaComponent
    {
        protected IRecetaComponent _receta;

        public IngredienteDecorator(IRecetaComponent receta)
        {
            _receta = receta;
        }
        public virtual string Descripcion
        {
            get { return _receta.Descripcion; }
        }

        public virtual double Costo
        {
            get { return _receta.Costo; }
        }

    }
}
