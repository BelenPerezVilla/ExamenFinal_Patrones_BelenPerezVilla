namespace ProyectoFinalPD.Presentacion
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.lblTextoReceta = new System.Windows.Forms.Label();
            this.lstRecetasCliente = new System.Windows.Forms.ListBox();
            this.btnElegirReceta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstIngredientesExtra = new System.Windows.Forms.ListBox();
            this.btnAgregarExtra = new System.Windows.Forms.Button();
            this.btnAgregarOtro = new System.Windows.Forms.Button();
            this.txtOtroIng = new System.Windows.Forms.TextBox();
            this.txtOtroIngPrecio = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextoReceta
            // 
            this.lblTextoReceta.AutoSize = true;
            this.lblTextoReceta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoReceta.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTextoReceta.Location = new System.Drawing.Point(8, 61);
            this.lblTextoReceta.Name = "lblTextoReceta";
            this.lblTextoReceta.Size = new System.Drawing.Size(180, 21);
            this.lblTextoReceta.TabIndex = 0;
            this.lblTextoReceta.Text = "Selecciona una receta:";
            // 
            // lstRecetasCliente
            // 
            this.lstRecetasCliente.FormattingEnabled = true;
            this.lstRecetasCliente.ItemHeight = 20;
            this.lstRecetasCliente.Location = new System.Drawing.Point(12, 97);
            this.lstRecetasCliente.Name = "lstRecetasCliente";
            this.lstRecetasCliente.Size = new System.Drawing.Size(260, 184);
            this.lstRecetasCliente.TabIndex = 1;
            // 
            // btnElegirReceta
            // 
            this.btnElegirReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(199)))), ((int)(((byte)(180)))));
            this.btnElegirReceta.Location = new System.Drawing.Point(54, 287);
            this.btnElegirReceta.Name = "btnElegirReceta";
            this.btnElegirReceta.Size = new System.Drawing.Size(147, 54);
            this.btnElegirReceta.TabIndex = 2;
            this.btnElegirReceta.Text = "Elegir receta";
            this.btnElegirReceta.UseVisualStyleBackColor = false;
            this.btnElegirReceta.Click += new System.EventHandler(this.btnElegirReceta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(345, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar Ingredientes extra:";
            // 
            // lstIngredientesExtra
            // 
            this.lstIngredientesExtra.FormattingEnabled = true;
            this.lstIngredientesExtra.ItemHeight = 20;
            this.lstIngredientesExtra.Location = new System.Drawing.Point(440, 97);
            this.lstIngredientesExtra.Name = "lstIngredientesExtra";
            this.lstIngredientesExtra.Size = new System.Drawing.Size(260, 164);
            this.lstIngredientesExtra.TabIndex = 4;
            // 
            // btnAgregarExtra
            // 
            this.btnAgregarExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(199)))), ((int)(((byte)(180)))));
            this.btnAgregarExtra.Location = new System.Drawing.Point(440, 278);
            this.btnAgregarExtra.Name = "btnAgregarExtra";
            this.btnAgregarExtra.Size = new System.Drawing.Size(134, 54);
            this.btnAgregarExtra.TabIndex = 5;
            this.btnAgregarExtra.Text = "Agregar Seleccionado";
            this.btnAgregarExtra.UseVisualStyleBackColor = false;
            this.btnAgregarExtra.Click += new System.EventHandler(this.btnAgregarExtra_Click);
            // 
            // btnAgregarOtro
            // 
            this.btnAgregarOtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(199)))), ((int)(((byte)(180)))));
            this.btnAgregarOtro.Location = new System.Drawing.Point(592, 278);
            this.btnAgregarOtro.Name = "btnAgregarOtro";
            this.btnAgregarOtro.Size = new System.Drawing.Size(134, 54);
            this.btnAgregarOtro.TabIndex = 6;
            this.btnAgregarOtro.Text = "Agregar otro ingrediente";
            this.btnAgregarOtro.UseVisualStyleBackColor = false;
            this.btnAgregarOtro.Click += new System.EventHandler(this.btnAgregarOtro_Click);
            // 
            // txtOtroIng
            // 
            this.txtOtroIng.Location = new System.Drawing.Point(440, 378);
            this.txtOtroIng.Name = "txtOtroIng";
            this.txtOtroIng.Size = new System.Drawing.Size(167, 26);
            this.txtOtroIng.TabIndex = 7;
            // 
            // txtOtroIngPrecio
            // 
            this.txtOtroIngPrecio.Location = new System.Drawing.Point(644, 378);
            this.txtOtroIngPrecio.Name = "txtOtroIngPrecio";
            this.txtOtroIngPrecio.Size = new System.Drawing.Size(82, 26);
            this.txtOtroIngPrecio.TabIndex = 8;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(199)))), ((int)(((byte)(180)))));
            this.btnContinuar.Location = new System.Drawing.Point(270, 425);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(171, 51);
            this.btnContinuar.TabIndex = 9;
            this.btnContinuar.Text = "Ver resumen del pedido";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(199)))), ((int)(((byte)(180)))));
            this.button2.Location = new System.Drawing.Point(261, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Volver al inicio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(332, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(758, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtOtroIngPrecio);
            this.Controls.Add(this.txtOtroIng);
            this.Controls.Add(this.btnAgregarOtro);
            this.Controls.Add(this.btnAgregarExtra);
            this.Controls.Add(this.lstIngredientesExtra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnElegirReceta);
            this.Controls.Add(this.lstRecetasCliente);
            this.Controls.Add(this.lblTextoReceta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoReceta;
        private System.Windows.Forms.ListBox lstRecetasCliente;
        private System.Windows.Forms.Button btnElegirReceta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstIngredientesExtra;
        private System.Windows.Forms.Button btnAgregarExtra;
        private System.Windows.Forms.Button btnAgregarOtro;
        private System.Windows.Forms.TextBox txtOtroIng;
        private System.Windows.Forms.TextBox txtOtroIngPrecio;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}