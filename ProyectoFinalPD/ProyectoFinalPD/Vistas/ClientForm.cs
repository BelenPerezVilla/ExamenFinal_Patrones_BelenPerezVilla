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
    public partial class ClientForm : Form
    {
        private ClienteController _controller;
        public ClientForm()
        {
            InitializeComponent();
            _controller = new ClienteController(MainForm.Cocina);
            CargarDatos();
        }
        private void CargarDatos()
        {
            foreach(RecetaBase r in MainForm.Cocina.RecetasBase)
            {
                lstRecetasCliente.Items.Add(r.Nombre + " - $"+r.PrecioBase);
            }
            foreach(var ing in MainForm.Cocina.IngredientesExtra)
            {
                lstIngredientesExtra.Items.Add(ing.Key + " - $" + ing.Value);
            }
        }

        private void btnElegirReceta_Click(object sender, EventArgs e)
        {
            if (lstRecetasCliente.SelectedIndex >= 0)
            {
                _controller.SeleccionarReceta(lstRecetasCliente.SelectedIndex);
                MessageBox.Show("Receta seleccionada correctamente");
            }
            else
            {
                MessageBox.Show("Selecciona una receta.");
            }
        }

        private void btnAgregarExtra_Click(object sender, EventArgs e)
        {
            if (lstIngredientesExtra.SelectedIndex >= 0)
            {
                var ing = MainForm.Cocina.IngredientesExtra[lstIngredientesExtra.SelectedIndex];
                _controller.AgregarIngrediente(ing.Key, ing.Value);

                MessageBox.Show("Ingrediente agregado: " + ing.Key);
            }
            else
            {
                MessageBox.Show("Selecciona un ingrediente");
            }
        }

        private void btnAgregarOtro_Click(object sender, EventArgs e)
        {
            string nombre = txtOtroIng.Text;
            double precio;

            if(double.TryParse(txtOtroIngPrecio.Text, out precio))
            {
                _controller.AgregarIngrediente(nombre, precio);
                MessageBox.Show("Ingrediente agregado: " + nombre);

                txtOtroIng.Clear();
                txtOtroIngPrecio.Clear();
            }
            else
            {
                MessageBox.Show("El precio no es valido");
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if(MainForm.Cocina.RecetaSeleccionada == null)
            {
                MessageBox.Show("Debes seleccionar una receta antes de continuar");
                return;
            }
            RecetarioForm resumen = new RecetarioForm();
            resumen.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm inicio = new MainForm(); 
            inicio.Show();
            this.Hide();
        }
    }
}
