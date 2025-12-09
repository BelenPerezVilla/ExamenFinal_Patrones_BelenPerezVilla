namespace ProyectoFinalPD.Presentacion
{
    partial class ChefForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefForm));
            this.lblReceta = new System.Windows.Forms.Label();
            this.txtNombreReceta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.btnAgregarReceta = new System.Windows.Forms.Button();
            this.lstRecetaBase = new System.Windows.Forms.ListBox();
            this.lstIngredientes = new System.Windows.Forms.ListBox();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.lblIng = new System.Windows.Forms.Label();
            this.txtIngredientprice = new System.Windows.Forms.TextBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReceta
            // 
            this.lblReceta.AutoSize = true;
            this.lblReceta.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceta.ForeColor = System.Drawing.Color.DarkRed;
            this.lblReceta.Location = new System.Drawing.Point(12, 74);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(158, 21);
            this.lblReceta.TabIndex = 0;
            this.lblReceta.Text = "Nombre de la Receta:";
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.Location = new System.Drawing.Point(177, 71);
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Size = new System.Drawing.Size(200, 26);
            this.txtNombreReceta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precio base:";
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(114, 124);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(100, 26);
            this.txtPrecioBase.TabIndex = 3;
            // 
            // btnAgregarReceta
            // 
            this.btnAgregarReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(199)))), ((int)(((byte)(180)))));
            this.btnAgregarReceta.Location = new System.Drawing.Point(240, 147);
            this.btnAgregarReceta.Name = "btnAgregarReceta";
            this.btnAgregarReceta.Size = new System.Drawing.Size(137, 64);
            this.btnAgregarReceta.TabIndex = 4;
            this.btnAgregarReceta.Text = "Agregar Receta Base";
            this.btnAgregarReceta.UseVisualStyleBackColor = false;
            this.btnAgregarReceta.Click += new System.EventHandler(this.btnAgregarReceta_Click);
            // 
            // lstRecetaBase
            // 
            this.lstRecetaBase.FormattingEnabled = true;
            this.lstRecetaBase.ItemHeight = 20;
            this.lstRecetaBase.Location = new System.Drawing.Point(461, 71);
            this.lstRecetaBase.Name = "lstRecetaBase";
            this.lstRecetaBase.Size = new System.Drawing.Size(320, 164);
            this.lstRecetaBase.TabIndex = 5;
            // 
            // lstIngredientes
            // 
            this.lstIngredientes.FormattingEnabled = true;
            this.lstIngredientes.ItemHeight = 20;
            this.lstIngredientes.Location = new System.Drawing.Point(461, 272);
            this.lstIngredientes.Name = "lstIngredientes";
            this.lstIngredientes.Size = new System.Drawing.Size(320, 164);
            this.lstIngredientes.TabIndex = 11;
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.Location = new System.Drawing.Point(12, 317);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.Size = new System.Drawing.Size(200, 26);
            this.txtIngredientName.TabIndex = 7;
            // 
            // lblIng
            // 
            this.lblIng.AutoSize = true;
            this.lblIng.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng.ForeColor = System.Drawing.Color.DarkRed;
            this.lblIng.Location = new System.Drawing.Point(12, 272);
            this.lblIng.Name = "lblIng";
            this.lblIng.Size = new System.Drawing.Size(222, 21);
            this.lblIng.TabIndex = 6;
            this.lblIng.Text = "Ingredientes Extra Disponibles:";
            // 
            // txtIngredientprice
            // 
            this.txtIngredientprice.Location = new System.Drawing.Point(240, 317);
            this.txtIngredientprice.Name = "txtIngredientprice";
            this.txtIngredientprice.Size = new System.Drawing.Size(80, 26);
            this.txtIngredientprice.TabIndex = 12;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(199)))), ((int)(((byte)(180)))));
            this.btnAddIngredient.Location = new System.Drawing.Point(93, 382);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(148, 54);
            this.btnAddIngredient.TabIndex = 13;
            this.btnAddIngredient.Text = "Agregar Ingrediente Extra";
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(199)))), ((int)(((byte)(180)))));
            this.btnVolver.Location = new System.Drawing.Point(295, 500);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(166, 56);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver al Inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(372, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cheft";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // ChefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(828, 564);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.txtIngredientprice);
            this.Controls.Add(this.lstIngredientes);
            this.Controls.Add(this.txtIngredientName);
            this.Controls.Add(this.lblIng);
            this.Controls.Add(this.lstRecetaBase);
            this.Controls.Add(this.btnAgregarReceta);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreReceta);
            this.Controls.Add(this.lblReceta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChefForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChefForm";
            this.Load += new System.EventHandler(this.ChefForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.Button btnAgregarReceta;
        private System.Windows.Forms.ListBox lstRecetaBase;
        private System.Windows.Forms.ListBox lstIngredientes;
        private System.Windows.Forms.TextBox txtIngredientName;
        private System.Windows.Forms.Label lblIng;
        private System.Windows.Forms.TextBox txtIngredientprice;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}