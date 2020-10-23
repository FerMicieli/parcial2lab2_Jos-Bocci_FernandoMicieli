namespace WindowsFormsApp1
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
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.rbtnPantalon = new System.Windows.Forms.RadioButton();
            this.cbxMangaCorta = new System.Windows.Forms.CheckBox();
            this.cbxBermuda = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCalidad = new System.Windows.Forms.Label();
            this.comboBoxCalidad = new System.Windows.Forms.ComboBox();
            this.rbtnCamisa = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(26, 19);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(474, 29);
            this.lblNombreEmpresa.TabIndex = 0;
            this.lblNombreEmpresa.Text = "VENTAS AL POR MAYOR - PradBit";
            // 
            // rbtnPantalon
            // 
            this.rbtnPantalon.AutoSize = true;
            this.rbtnPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPantalon.Location = new System.Drawing.Point(85, 131);
            this.rbtnPantalon.Name = "rbtnPantalon";
            this.rbtnPantalon.Size = new System.Drawing.Size(115, 29);
            this.rbtnPantalon.TabIndex = 2;
            this.rbtnPantalon.TabStop = true;
            this.rbtnPantalon.Text = "Pantalón";
            this.rbtnPantalon.UseVisualStyleBackColor = true;
            this.rbtnPantalon.CheckedChanged += new System.EventHandler(this.rbtnPantalon_CheckedChanged);
            // 
            // cbxMangaCorta
            // 
            this.cbxMangaCorta.AutoSize = true;
            this.cbxMangaCorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMangaCorta.Location = new System.Drawing.Point(228, 87);
            this.cbxMangaCorta.Name = "cbxMangaCorta";
            this.cbxMangaCorta.Size = new System.Drawing.Size(284, 29);
            this.cbxMangaCorta.TabIndex = 3;
            this.cbxMangaCorta.Text = "Manga corta (10% menos)";
            this.cbxMangaCorta.UseVisualStyleBackColor = true;
            // 
            // cbxBermuda
            // 
            this.cbxBermuda.AutoSize = true;
            this.cbxBermuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBermuda.Location = new System.Drawing.Point(228, 132);
            this.cbxBermuda.Name = "cbxBermuda";
            this.cbxBermuda.Size = new System.Drawing.Size(250, 29);
            this.cbxBermuda.TabIndex = 4;
            this.cbxBermuda.Text = "Bermuda (20% menos)";
            this.cbxBermuda.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(58, 321);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(167, 31);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(326, 321);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(145, 31);
            this.txtCantidad.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(53, 289);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(172, 29);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio Unitario";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(330, 289);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(109, 29);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Gold;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(120, 363);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(273, 76);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular Precio Final";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalidad.Location = new System.Drawing.Point(144, 183);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(212, 29);
            this.lblCalidad.TabIndex = 11;
            this.lblCalidad.Text = "Calidad de prenda";
            // 
            // comboBoxCalidad
            // 
            this.comboBoxCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCalidad.FormattingEnabled = true;
            this.comboBoxCalidad.Items.AddRange(new object[] {
            "Standard (No afecta al precio)",
            "Premium (Recargo en el precio del 30%)"});
            this.comboBoxCalidad.Location = new System.Drawing.Point(58, 231);
            this.comboBoxCalidad.Name = "comboBoxCalidad";
            this.comboBoxCalidad.Size = new System.Drawing.Size(413, 33);
            this.comboBoxCalidad.TabIndex = 12;
            // 
            // rbtnCamisa
            // 
            this.rbtnCamisa.AutoSize = true;
            this.rbtnCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCamisa.Location = new System.Drawing.Point(88, 87);
            this.rbtnCamisa.Name = "rbtnCamisa";
            this.rbtnCamisa.Size = new System.Drawing.Size(102, 29);
            this.rbtnCamisa.TabIndex = 13;
            this.rbtnCamisa.TabStop = true;
            this.rbtnCamisa.Text = "Camisa";
            this.rbtnCamisa.UseVisualStyleBackColor = true;
            this.rbtnCamisa.CheckedChanged += new System.EventHandler(this.rbtnCamisa_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.rbtnCamisa);
            this.Controls.Add(this.comboBoxCalidad);
            this.Controls.Add(this.lblCalidad);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cbxBermuda);
            this.Controls.Add(this.cbxMangaCorta);
            this.Controls.Add(this.rbtnPantalon);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.RadioButton rbtnPantalon;
        private System.Windows.Forms.CheckBox cbxMangaCorta;
        private System.Windows.Forms.CheckBox cbxBermuda;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCalidad;
        private System.Windows.Forms.ComboBox comboBoxCalidad;
        private System.Windows.Forms.RadioButton rbtnCamisa;
    }
}

