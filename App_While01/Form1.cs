using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_While01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num = 1;
            listNumeros.Items.Clear();
            while (num <= 20)
            {
                listNumeros.Items.Add(num);
                num++;
            }
            txtCantidad.Text = (num - 1).ToString("n0");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int num = 100;
            int cont = 0;
            listNumeros.Items.Clear();
            while (num >= 2)
            {
                cont++;
                listNumeros.Items.Add(num);
                num-=2;
            }
            txtCantidad.Text = (cont).ToString("n0");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int num = 1,cont = 0;
            listNumeros.Items.Clear();
            while (num <= 99)
            {
                cont++;
                listNumeros.Items.Add(num);
                num++;
                num++;
            }
            txtCantidad.Text = (cont).ToString("n0");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
