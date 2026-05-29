using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        int Excelente=0;
        int Bueno=0;
        int Insuficiente=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            Comprobar();

            lbTotal.Text= Convert.ToString(Excelente+Bueno+Insuficiente);
            lbExcelentes.Text=Convert.ToString(Excelente);
            lbBuenos.Text=Convert.ToString(Bueno);
            lbInsuficientes.Text = Convert.ToString(Insuficiente);
        }

        void Comprobar() 
        {
            if (rbExcelente.Checked)
            {
                Excelente++;
            }
            if (rbBueno.Checked) 
            {
                Bueno++;
            }
            if (rbInsuficiente.Checked)
            {
                Insuficiente++;
            }
        }




    }
}
