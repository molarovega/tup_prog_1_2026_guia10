using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contExcelente=0;
        int contBueno = 0;
        int contInsuficiente = 0;
        int contBase = 0;
        int contFULL = 0;
        int contVotaciones = 0;


        private void btnVotar_Click(object sender, EventArgs e)
        {
            Opinion();
            TipoDeProducto();
            contVotaciones++;

            ResultadosEncuesta();
        }

        void Opinion() 
        {
            if (rbExcelente.Checked)
                contExcelente++;
            
            if(rbBueno.Checked)
                contBueno++;

            if(rbInsuficiente.Checked)
                contInsuficiente++;
        }
        void TipoDeProducto() 
        {
            if(rbBase.Checked)
                contBase++;

            if (rbFULL.Checked)
                contFULL++;
        }

        void ResultadosEncuesta() 
        {
            lbTotal.Text = Convert.ToString(contVotaciones);
            lbExcelentes.Text= Convert.ToString(contExcelente);
            lbBuenos.Text= Convert.ToString(contBueno);
            lbInsuficientes.Text=Convert.ToString(contInsuficiente);
            lbBase.Text = Convert.ToString(contBase);
            lbFULL.Text = Convert.ToString(contFULL);
        }
    }
}
