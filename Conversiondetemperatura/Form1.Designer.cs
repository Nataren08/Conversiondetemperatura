namespace Conversiondetemperatura
{
    partial class Form1
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
            this.btnConvertidorCaF = new System.Windows.Forms.Button();
            this.btnConvertirFaC = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbTituloConversor = new System.Windows.Forms.Label();
            this.lbCelcius = new System.Windows.Forms.Label();
            this.lbFarenheit = new System.Windows.Forms.Label();
            this.txtResultadoCaF = new System.Windows.Forms.TextBox();
            this.txtResultadoFaC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvertidorCaF
            // 
            this.btnConvertidorCaF.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertidorCaF.Location = new System.Drawing.Point(61, 261);
            this.btnConvertidorCaF.Name = "btnConvertidorCaF";
            this.btnConvertidorCaF.Size = new System.Drawing.Size(111, 87);
            this.btnConvertidorCaF.TabIndex = 2;
            this.btnConvertidorCaF.Text = "CELSIUS A FARENHEIT";
            this.btnConvertidorCaF.UseVisualStyleBackColor = true;
            this.btnConvertidorCaF.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConvertirFaC
            // 
            this.btnConvertirFaC.Font = new System.Drawing.Font("PT Bold Broken", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnConvertirFaC.Location = new System.Drawing.Point(530, 259);
            this.btnConvertirFaC.Name = "btnConvertirFaC";
            this.btnConvertirFaC.Size = new System.Drawing.Size(211, 78);
            this.btnConvertirFaC.TabIndex = 3;
            this.btnConvertirFaC.Text = "FARENHEIT A CELSIUS";
            this.btnConvertirFaC.UseVisualStyleBackColor = true;
            this.btnConvertirFaC.Click += new System.EventHandler(this.btnConvertirFaC_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(308, 261);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 55);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbTituloConversor
            // 
            this.lbTituloConversor.AutoSize = true;
            this.lbTituloConversor.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloConversor.Location = new System.Drawing.Point(151, 25);
            this.lbTituloConversor.Name = "lbTituloConversor";
            this.lbTituloConversor.Size = new System.Drawing.Size(442, 47);
            this.lbTituloConversor.TabIndex = 5;
            this.lbTituloConversor.Text = "Conversor de Temperatura";
            this.lbTituloConversor.UseMnemonic = false;
            // 
            // lbCelcius
            // 
            this.lbCelcius.AutoSize = true;
            this.lbCelcius.Font = new System.Drawing.Font("Akhbar MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbCelcius.Location = new System.Drawing.Point(55, 109);
            this.lbCelcius.Name = "lbCelcius";
            this.lbCelcius.Size = new System.Drawing.Size(141, 31);
            this.lbCelcius.TabIndex = 6;
            this.lbCelcius.Text = "Grados Celsius";
            // 
            // lbFarenheit
            // 
            this.lbFarenheit.AutoSize = true;
            this.lbFarenheit.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFarenheit.Location = new System.Drawing.Point(525, 109);
            this.lbFarenheit.Name = "lbFarenheit";
            this.lbFarenheit.Size = new System.Drawing.Size(176, 26);
            this.lbFarenheit.TabIndex = 7;
            this.lbFarenheit.Text = "Grados Farenheit";
            // 
            // txtResultadoCaF
            // 
            this.txtResultadoCaF.Location = new System.Drawing.Point(74, 165);
            this.txtResultadoCaF.Name = "txtResultadoCaF";
            this.txtResultadoCaF.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoCaF.TabIndex = 8;
            // 
            // txtResultadoFaC
            // 
            this.txtResultadoFaC.Location = new System.Drawing.Point(567, 165);
            this.txtResultadoFaC.Name = "txtResultadoFaC";
            this.txtResultadoFaC.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoFaC.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultadoFaC);
            this.Controls.Add(this.txtResultadoCaF);
            this.Controls.Add(this.lbFarenheit);
            this.Controls.Add(this.lbCelcius);
            this.Controls.Add(this.lbTituloConversor);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvertirFaC);
            this.Controls.Add(this.btnConvertidorCaF);
            this.Name = "Form1";
            this.Text = "Comversiondetemp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConvertidorCaF;
        private System.Windows.Forms.Button btnConvertirFaC;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbTituloConversor;
        private System.Windows.Forms.Label lbCelcius;
        private System.Windows.Forms.Label lbFarenheit;
        private System.Windows.Forms.TextBox txtResultadoCaF;
        private System.Windows.Forms.TextBox txtResultadoFaC;
    }
}

