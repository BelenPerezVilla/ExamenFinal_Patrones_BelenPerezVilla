namespace ProyectoFinalPD.Presentacion
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnChef = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitulo.Location = new System.Drawing.Point(59, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(309, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SIMULADOR DE COCINA";
            // 
            // btnChef
            // 
            this.btnChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(199)))), ((int)(((byte)(180)))));
            this.btnChef.FlatAppearance.BorderSize = 0;
            this.btnChef.Location = new System.Drawing.Point(64, 87);
            this.btnChef.Name = "btnChef";
            this.btnChef.Size = new System.Drawing.Size(267, 40);
            this.btnChef.TabIndex = 1;
            this.btnChef.Text = "Chef (Administrador de Recetas)";
            this.btnChef.UseVisualStyleBackColor = false;
            this.btnChef.Click += new System.EventHandler(this.btnChef_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(199)))), ((int)(((byte)(180)))));
            this.btnCliente.Location = new System.Drawing.Point(64, 155);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(267, 44);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente (Hacer Pedido)";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(398, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnChef);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnChef;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}