using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPD.Presentacion
{
    public partial class RecetarioForm : Form
    {
        public RecetarioForm()
        {
            InitializeComponent();
            if(MainForm.Cocina.RecetaSeleccionada != null)
            {
                txtDescripcion.Text = MainForm.Cocina.RecetaSeleccionada.Descripcion;
                txtTotal.Text = "$" + MainForm.Cocina.RecetaSeleccionada.Costo;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido Finalizado :D");
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }
    }
}
