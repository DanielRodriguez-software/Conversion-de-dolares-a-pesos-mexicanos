namespace Conversion_de_dolar_a_pesos_mexicanos
{
    partial class conversi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conversi));
            this.gbPantalla = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConversion = new System.Windows.Forms.Button();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblDolares = new System.Windows.Forms.Label();
            this.gbPantalla.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPantalla
            // 
            this.gbPantalla.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbPantalla.Controls.Add(this.lblError);
            this.gbPantalla.Controls.Add(this.btnLimpiar);
            this.gbPantalla.Controls.Add(this.btnConversion);
            this.gbPantalla.Controls.Add(this.txtPesos);
            this.gbPantalla.Controls.Add(this.txtDolares);
            this.gbPantalla.Controls.Add(this.lblPesos);
            this.gbPantalla.Controls.Add(this.lblDolares);
            this.gbPantalla.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPantalla.Location = new System.Drawing.Point(99, 38);
            this.gbPantalla.Margin = new System.Windows.Forms.Padding(4);
            this.gbPantalla.Name = "gbPantalla";
            this.gbPantalla.Padding = new System.Windows.Forms.Padding(4);
            this.gbPantalla.Size = new System.Drawing.Size(601, 233);
            this.gbPantalla.TabIndex = 0;
            this.gbPantalla.TabStop = false;
            this.gbPantalla.Text = "Pantalla Principal";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(306, 166);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 16);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Error";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Image = global::Conversion_de_dolar_a_pesos_mexicanos.Properties.Resources.icons8_broom_48;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(296, 97);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 53);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConversion
            // 
            this.btnConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConversion.Image = global::Conversion_de_dolar_a_pesos_mexicanos.Properties.Resources.icons8_add_48;
            this.btnConversion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConversion.Location = new System.Drawing.Point(281, 29);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(128, 54);
            this.btnConversion.TabIndex = 4;
            this.btnConversion.Text = "Conversion";
            this.btnConversion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConversion.UseVisualStyleBackColor = false;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(25, 145);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.ReadOnly = true;
            this.txtPesos.Size = new System.Drawing.Size(115, 28);
            this.txtPesos.TabIndex = 3;
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(25, 74);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(100, 28);
            this.txtDolares.TabIndex = 2;
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(22, 115);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(123, 16);
            this.lblPesos.TabIndex = 1;
            this.lblPesos.Text = "Pesos Mexicanos:";
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Location = new System.Drawing.Point(34, 48);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(62, 16);
            this.lblDolares.TabIndex = 0;
            this.lblDolares.Text = "Dolares:";
            // 
            // conversi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gbPantalla);
            this.Font = new System.Drawing.Font("Harlow Solid Italic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "conversi";
            this.Text = "Conversion de dolares a pesos mexicanos";
            this.gbPantalla.ResumeLayout(false);
            this.gbPantalla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPantalla;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.Label lblError;
    }
}

