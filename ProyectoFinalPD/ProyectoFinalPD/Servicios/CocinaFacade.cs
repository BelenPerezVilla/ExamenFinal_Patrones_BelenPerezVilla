using ProyectoFinalPD.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Servicios
{
    public class CocinaFacade
    {
        public List<RecetaBase> RecetasBase { get; private set; }
        public List<KeyValuePair<string, double>> IngredientesExtra { get; private set; }

        public IRecetaComponent RecetaSeleccionada { get; private set; }

        public CocinaFacade()
        {
            RecetasBase = new List<RecetaBase>();
            IngredientesExtra = new List<KeyValuePair<string, double>>();
        }

        public void AgregarRecetaBase(string nombre, double precio)
        {
            RecetasBase.Add(new RecetaBase(nombre, precio));
        }

        public void AgregarIngredienteExtra(string nombre, double precio)
        {
            IngredientesExtra.Add(new KeyValuePair<string, double>(nombre, precio));
        }

        public void SeleccionarReceta(int index)
        {
            RecetaSeleccionada = RecetasBase[index];
        }

        public void AgregarIngredienteAReceta(string nombre, double precio)
        {
            RecetaSeleccionada = new IngredienteExtraSimple(RecetaSeleccionada, nombre, precio);
        }
    }
}
