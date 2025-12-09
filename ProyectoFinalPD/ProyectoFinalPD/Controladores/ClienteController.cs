using ProyectoFinalPD.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Controladores
{
    public class ClienteController
    {
        private CocinaFacade _cocina;

        public ClienteController(CocinaFacade cocina)
        {
            _cocina = cocina;
        }

        public void SeleccionarReceta(int index)
        {
            _cocina.SeleccionarReceta(index);
        }

        public void AgregarIngrediente(string nombre, double precio)
        {
            _cocina.AgregarIngredienteAReceta(nombre, precio);
        }

        public IRecetaComponent ObtenerReceta()
        {
            return _cocina.RecetaSeleccionada;
        }
    }
}
