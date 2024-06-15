namespace EldenPizza
{
    partial class Form1
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
            this.usuariotxt = new System.Windows.Forms.TextBox();
            this.Clavetxt = new System.Windows.Forms.TextBox();
            this.labelusurio = new System.Windows.Forms.Label();
            this.labelclave = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuariotxt
            // 
            this.usuariotxt.Location = new System.Drawing.Point(106, 65);
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.Size = new System.Drawing.Size(192, 20);
            this.usuariotxt.TabIndex = 0;
            // 
            // Clavetxt
            // 
            this.Clavetxt.Location = new System.Drawing.Point(106, 152);
            this.Clavetxt.Name = "Clavetxt";
            this.Clavetxt.Size = new System.Drawing.Size(192, 20);
            this.Clavetxt.TabIndex = 1;
            // 
            // labelusurio
            // 
            this.labelusurio.AutoSize = true;
            this.labelusurio.Location = new System.Drawing.Point(103, 40);
            this.labelusurio.Name = "labelusurio";
            this.labelusurio.Size = new System.Drawing.Size(43, 13);
            this.labelusurio.TabIndex = 2;
            this.labelusurio.Text = "Usuario";
            // 
            // labelclave
            // 
            this.labelclave.AutoSize = true;
            this.labelclave.Location = new System.Drawing.Point(103, 127);
            this.labelclave.Name = "labelclave";
            this.labelclave.Size = new System.Drawing.Size(61, 13);
            this.labelclave.TabIndex = 3;
            this.labelclave.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelclave);
            this.Controls.Add(this.labelusurio);
            this.Controls.Add(this.Clavetxt);
            this.Controls.Add(this.usuariotxt);
            this.Name = "Form1";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuariotxt;
        private System.Windows.Forms.TextBox Clavetxt;
        private System.Windows.Forms.Label labelusurio;
        private System.Windows.Forms.Label labelclave;
        private System.Windows.Forms.Button button1;
    }
}

