using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalPD.Servicios;

namespace ProyectoFinalPD.Presentacion
{
    public partial class MainForm : Form
    {
        public static CocinaFacade Cocina=new CocinaFacade();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            ChefForm chef = new ChefForm();
            chef.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ClientForm cliente = new ClientForm();
            cliente.Show();
            this.Hide();
        }
    }
}
