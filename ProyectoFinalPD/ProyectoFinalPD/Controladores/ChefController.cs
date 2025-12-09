using ProyectoFinalPD.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Controladores
{
    public class ChefController
    {
        private CocinaFacade _cocina;

        public ChefController(CocinaFacade cocina)
        {
            _cocina = cocina;
        }

        public void AgregarReceta(string nombre, double precio)
        {
            _cocina.AgregarRecetaBase(nombre, precio);
        }

        public void AgregarIngredienteExtra(string nombre, double precio)
        {
            _cocina.AgregarIngredienteExtra(nombre, precio);
        }
    }
}
