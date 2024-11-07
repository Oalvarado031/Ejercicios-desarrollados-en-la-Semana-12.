using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class TITULO : Form
    {
        public TITULO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos leidos correctamente");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double descuento = 0;
            double cantidad = int.Parse(txtCantidad.Text);
            double precio = int.Parse(txtPrecio.Text);
            double subtotal = cantidad * precio;
            txtSubtotal.Text = subtotal.ToString(); 

            if (rdb0.Checked )
            {
                descuento = 0;
            } 
            else if (rdb1.Checked )
            {
                descuento = 0.01;
            }
            else if (rdb5.Checked)
            {
                descuento = 0.05;
            } 
            else if (rdb10.Checked)
            {
                descuento = 0.1;
            }
            else if (rdb15.Checked)
            {
                descuento = 0.15;
            }
            double descuentoAplicado = subtotal * descuento;
            txtDescuento.Text = descuentoAplicado.ToString();

            double iva = subtotal * 0.15;
            txtIva.Text = iva.ToString();

            double total = (subtotal + iva) - descuentoAplicado;
            txtTotal.Text = total.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtSubtotal.Clear();
            txtDescuento.Clear();
            txtIva.Clear();
            txtTotal.Clear();
            txtNombre.Clear();
            txtCodigo.Clear();  

            rdb0.Checked = false;
            rdb1.Checked = false;
            rdb5.Checked = false;
            rdb10.Checked = false;
            rdb15.Checked = false;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: Oscar Ivan Alvarado Jiron, 07/11/2024");
            Close();    
        }
    }
}
