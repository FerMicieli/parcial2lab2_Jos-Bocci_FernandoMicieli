using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCamisa.Checked == true)
            {
                cbxMangaCorta.Enabled = true;
                cbxBermuda.Enabled = false;
            }
        }

        private void rbtnPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPantalon.Checked == true)
            {
                cbxMangaCorta.Enabled = false;
                cbxBermuda.Enabled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precioFinal = 0, precioBase = 0;
            int cantidad = 1;
            bool validar1 = false;
            bool validar2 = false;
            validar1 = Utiles.validarCampo(txtPrecio.Text, "float");
            validar2 = Utiles.validarCampo(txtCantidad.Text, "int");
            if (comboBoxCalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de calidad", "ERROR");
                return;
            }
            #region(CAMISA)
            if (rbtnCamisa.Checked == true && cbxMangaCorta.Checked == true)
            {
                if (validar1 && validar2)
                {
                    precioFinal = Convert.ToInt32(txtPrecio.Text);
                    precioFinal -= (precioFinal * 0.1);

                    if (comboBoxCalidad.SelectedIndex == 0)
                    { }
                    else
                    {
                        precioBase = Convert.ToInt32(txtPrecio.Text);
                        precioFinal += (precioBase * 0.3);
                    }
                    cantidad = Convert.ToInt32(txtCantidad.Text);
                    precioFinal = precioFinal * cantidad;
                    MessageBox.Show("Artículos: " + cantidad + "\nPrecio Final: $" + precioFinal, "VENTA");
                }
                else if (validar2 == false)
                {
                    MessageBox.Show("Error al ingresar la cantidad. Compruebe por favor", "ERROR");
                }
                else if (validar1 == false)
                {
                    MessageBox.Show("Error al ingresar el precio. Compruebe por favor", "ERROR");
                }
            }
            else if (rbtnCamisa.Checked == true && cbxMangaCorta.Checked == false)
            {
                if (validar1 && validar2)
                {
                    precioFinal = Convert.ToInt32(txtPrecio.Text);

                    if (comboBoxCalidad.SelectedIndex == 0)
                    { }
                    else
                    {
                        precioBase = Convert.ToInt32(txtPrecio.Text);
                        precioFinal += (precioBase * 0.3);
                    }
                    cantidad = Convert.ToInt32(txtCantidad.Text);
                    precioFinal = precioFinal * cantidad;
                    MessageBox.Show("Artículos: " + cantidad + "\nPrecio Final: $" + precioFinal, "VENTA");
                }
                else if (validar2 == false)
                {
                    MessageBox.Show("Error al ingresar la cantidad. Compruebe por favor", "ERROR");
                }
                else if (validar1 == false)
                {
                    MessageBox.Show("Error al ingresar el precio. Compruebe por favor", "ERROR");
                }
            }
#endregion
            #region(PANTALON)
            if (rbtnPantalon.Checked == true && cbxBermuda.Checked == true)
            {
                if (validar1 && validar2)
                {
                    precioFinal = Convert.ToInt32(txtPrecio.Text);
                    precioFinal -= (precioFinal * 0.2);

                    if (comboBoxCalidad.SelectedIndex == 0)
                    { }
                    else
                    {
                        precioBase = Convert.ToInt32(txtPrecio.Text);
                        precioFinal += (precioBase * 0.3);
                    }
                    cantidad = Convert.ToInt32(txtCantidad.Text);
                    precioFinal = precioFinal * cantidad;
                    MessageBox.Show("Artículos: " + cantidad + "\nPrecio Final: $" + precioFinal, "VENTA");
                }
                else if (validar2 == false)
                {
                    MessageBox.Show("Error al ingresar la cantidad. Compruebe por favor", "ERROR");
                }
                else if (validar1 == false)
                {
                    MessageBox.Show("Error al ingresar el precio. Compruebe por favor", "ERROR");
                }
            }
            else if (rbtnPantalon.Checked == true && cbxBermuda.Checked == false)
            {
                if (validar1 && validar2)
                {
                    precioFinal = Convert.ToInt32(txtPrecio.Text);

                    if (comboBoxCalidad.SelectedIndex == 0)
                    { }
                    else
                    {
                        precioBase = Convert.ToInt32(txtPrecio.Text);
                        precioFinal += (precioBase * 0.3);
                    }
                    cantidad = Convert.ToInt32(txtCantidad.Text);
                    precioFinal = precioFinal * cantidad;
                    MessageBox.Show("Artículos: " + cantidad + "\nPrecio Final: $" + precioFinal, "VENTA");
                }
                else if (validar2 == false)
                {
                    MessageBox.Show("Error al ingresar la cantidad. Compruebe por favor", "ERROR");
                }
                else if (validar1 == false)
                {
                    MessageBox.Show("Error al ingresar el precio. Compruebe por favor", "ERROR");
                }
            }
#endregion
        }
    }
}
                   