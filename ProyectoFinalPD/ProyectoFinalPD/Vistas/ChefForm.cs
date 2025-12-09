using ProyectoFinalPD.Controladores;
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
    public partial class ChefForm : Form
    {
        private ChefController _controller;
        public ChefForm()
        {
            InitializeComponent();
            _controller = new ChefController(MainForm.Cocina);
        }

        private void ChefForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarReceta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreReceta.Text;
            double precio;

            if(double.TryParse(txtPrecioBase.Text, out precio))
            {
                _controller.AgregarReceta(nombre, precio);
                lstRecetaBase.Items.Add(nombre + " - $" + precio);
                txtNombreReceta.Clear();
                txtPrecioBase.Clear();
            }
            else
            {
                MessageBox.Show("El precio no es valido");
            }
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            string nombre = txtIngredientName.Text;
            double precio;

            if (double.TryParse(txtIngredientprice.Text, out precio))
            {
                _controller.AgregarIngredienteExtra(nombre, precio);

                lstIngredientes.Items.Add(nombre + " - $" + precio);
                txtIngredientName.Clear();
                txtIngredientprice.Clear();
            }
            else
            {
                MessageBox.Show("El precio no es valido");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MainForm inicio = new MainForm();
            inicio.Show();
            this.Hide();
        }
    }
}
