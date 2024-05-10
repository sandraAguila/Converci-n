namespace Converción
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertirKilogramos = new System.Windows.Forms.Button();
            this.btnConvertirLibras = new System.Windows.Forms.Button();
            this.btnConvertirFarenheit = new System.Windows.Forms.Button();
            this.btnConvertirCelsius = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convertidor";
            // 
            // btnConvertirKilogramos
            // 
            this.btnConvertirKilogramos.Location = new System.Drawing.Point(50, 197);
            this.btnConvertirKilogramos.Name = "btnConvertirKilogramos";
            this.btnConvertirKilogramos.Size = new System.Drawing.Size(84, 45);
            this.btnConvertirKilogramos.TabIndex = 1;
            this.btnConvertirKilogramos.Text = "Convertir a  kilogramos";
            this.btnConvertirKilogramos.UseVisualStyleBackColor = true;
            this.btnConvertirKilogramos.Click += new System.EventHandler(this.btnConvertirKilogramos_Click);
            // 
            // btnConvertirLibras
            // 
            this.btnConvertirLibras.Location = new System.Drawing.Point(205, 197);
            this.btnConvertirLibras.Name = "btnConvertirLibras";
            this.btnConvertirLibras.Size = new System.Drawing.Size(84, 45);
            this.btnConvertirLibras.TabIndex = 2;
            this.btnConvertirLibras.Text = "Convertir a  Libras";
            this.btnConvertirLibras.UseVisualStyleBackColor = true;
            this.btnConvertirLibras.Click += new System.EventHandler(this.btnConvertirLibras_Click);
            // 
            // btnConvertirFarenheit
            // 
            this.btnConvertirFarenheit.Location = new System.Drawing.Point(50, 266);
            this.btnConvertirFarenheit.Name = "btnConvertirFarenheit";
            this.btnConvertirFarenheit.Size = new System.Drawing.Size(84, 45);
            this.btnConvertirFarenheit.TabIndex = 3;
            this.btnConvertirFarenheit.Text = "Convertir a  Farenheit";
            this.btnConvertirFarenheit.UseMnemonic = false;
            this.btnConvertirFarenheit.UseVisualStyleBackColor = true;
            this.btnConvertirFarenheit.Click += new System.EventHandler(this.btnConvertirFarenheit_Click);
            // 
            // btnConvertirCelsius
            // 
            this.btnConvertirCelsius.Location = new System.Drawing.Point(205, 266);
            this.btnConvertirCelsius.Name = "btnConvertirCelsius";
            this.btnConvertirCelsius.Size = new System.Drawing.Size(84, 45);
            this.btnConvertirCelsius.TabIndex = 4;
            this.btnConvertirCelsius.Text = "Convertir a  Celsius";
            this.btnConvertirCelsius.UseMnemonic = false;
            this.btnConvertirCelsius.UseVisualStyleBackColor = true;
            this.btnConvertirCelsius.Click += new System.EventHandler(this.btnConvertirCelsius_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el valor a convertir:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(180, 127);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(90, 20);
            this.txtValor.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "La respuesta es:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(121, 409);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(114, 20);
            this.txtResultado.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(134, 317);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 42);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvertirCelsius);
            this.Controls.Add(this.btnConvertirFarenheit);
            this.Controls.Add(this.btnConvertirLibras);
            this.Controls.Add(this.btnConvertirKilogramos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertirKilogramos;
        private System.Windows.Forms.Button btnConvertirLibras;
        private System.Windows.Forms.Button btnConvertirFarenheit;
        private System.Windows.Forms.Button btnConvertirCelsius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSalir;
    }
}

