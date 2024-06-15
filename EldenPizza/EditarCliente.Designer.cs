namespace EldenPizza
{
    partial class EditarCliente
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
            this.Direcciontxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefonotxt = new System.Windows.Forms.TextBox();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMasDireccion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Direcciontxt
            // 
            this.Direcciontxt.Location = new System.Drawing.Point(24, 214);
            this.Direcciontxt.Name = "Direcciontxt";
            this.Direcciontxt.Size = new System.Drawing.Size(138, 20);
            this.Direcciontxt.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // telefonotxt
            // 
            this.telefonotxt.Location = new System.Drawing.Point(24, 139);
            this.telefonotxt.Name = "telefonotxt";
            this.telefonotxt.Size = new System.Drawing.Size(138, 20);
            this.telefonotxt.TabIndex = 10;
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(24, 74);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(138, 20);
            this.Nombretxt.TabIndex = 9;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(210, 97);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(210, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnMasDireccion
            // 
            this.btnMasDireccion.Location = new System.Drawing.Point(210, 170);
            this.btnMasDireccion.Name = "btnMasDireccion";
            this.btnMasDireccion.Size = new System.Drawing.Size(75, 23);
            this.btnMasDireccion.TabIndex = 20;
            this.btnMasDireccion.Text = "+ Direccion";
            this.btnMasDireccion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Id";
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(24, 32);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(138, 20);
            this.Idtxt.TabIndex = 31;
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.btnMasDireccion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.Direcciontxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telefonotxt);
            this.Controls.Add(this.Nombretxt);
            this.Name = "EditarCliente";
            this.Text = "EditarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Direcciontxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefonotxt;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMasDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Idtxt;
    }
}