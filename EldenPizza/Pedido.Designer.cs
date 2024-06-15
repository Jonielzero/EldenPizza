namespace EldenPizza
{
    partial class Pedido
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
            this.Preciotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Productotxt = new System.Windows.Forms.TextBox();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.Cantidadtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Totallbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Preciotxt
            // 
            this.Preciotxt.Location = new System.Drawing.Point(21, 148);
            this.Preciotxt.Name = "Preciotxt";
            this.Preciotxt.Size = new System.Drawing.Size(138, 20);
            this.Preciotxt.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Precio";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(228, 111);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 22;
            this.btnNuevo.Text = "Guardar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre Cliente";
            // 
            // Productotxt
            // 
            this.Productotxt.Location = new System.Drawing.Point(21, 95);
            this.Productotxt.Name = "Productotxt";
            this.Productotxt.Size = new System.Drawing.Size(138, 20);
            this.Productotxt.TabIndex = 19;
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(21, 43);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(138, 20);
            this.Nombretxt.TabIndex = 18;
            // 
            // Cantidadtxt
            // 
            this.Cantidadtxt.Location = new System.Drawing.Point(21, 206);
            this.Cantidadtxt.Name = "Cantidadtxt";
            this.Cantidadtxt.Size = new System.Drawing.Size(138, 20);
            this.Cantidadtxt.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cantidad";
            // 
            // Totallbl
            // 
            this.Totallbl.AutoSize = true;
            this.Totallbl.Location = new System.Drawing.Point(376, 155);
            this.Totallbl.Name = "Totallbl";
            this.Totallbl.Size = new System.Drawing.Size(31, 13);
            this.Totallbl.TabIndex = 29;
            this.Totallbl.Text = "Total";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 269);
            this.Controls.Add(this.Totallbl);
            this.Controls.Add(this.Cantidadtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Preciotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Productotxt);
            this.Controls.Add(this.Nombretxt);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Preciotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Productotxt;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.TextBox Cantidadtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Totallbl;
    }
}