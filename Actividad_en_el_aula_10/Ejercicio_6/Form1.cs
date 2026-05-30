using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            lbResultado.Text = VerificarRespuesta();
        }

        string VerificarRespuesta() 
        {
            string NoSiempreSeDebeInicializar;
            string NuncaDebeInicializarse;
            string SiempreDebeInicializarse;


            if (chbNoSiempreSeDebeInicializar.Checked)
                NoSiempreSeDebeInicializar = "Incorrecto -> No siempre se debe inicializar. Es verdadero\r\n";
            
            else
                NoSiempreSeDebeInicializar = "Correcto -> No siempre se debe inicializar. Es falso\r\n";
            
            if (chbNuncaDebeInicializarse.Checked)
                NuncaDebeInicializarse = "Incorrecto -> Nunca Debe Inicializarse. Es verdadero\r\n";

            else
                NuncaDebeInicializarse = "Correcto -> Nunca Debe Inicializarse. Es falso\r\n";

            
            if (chbSiempreDebeInicializarse.Checked)
                SiempreDebeInicializarse = "Correcto -> Siempre Debe Inicializarse. Es verdadero\r\n";
            else
                SiempreDebeInicializarse = "Incorrecto -> Siempre Debe Inicializarse. Es falso\r\n";

            return NoSiempreSeDebeInicializar + NuncaDebeInicializarse + SiempreDebeInicializarse;
        }
    }
}
