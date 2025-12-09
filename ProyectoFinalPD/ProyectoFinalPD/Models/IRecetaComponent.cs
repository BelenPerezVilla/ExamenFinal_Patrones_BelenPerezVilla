using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalPD.Controladores
{
    public interface IRecetaComponent
    {
        string Descripcion { get; }
        double Costo { get; }
    }
}
