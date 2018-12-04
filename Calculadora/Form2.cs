using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoa
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn4salir_Click(object sender, EventArgs e)
        {

        }

        private void btn4calcular_Click(object sender, EventArgs e)
        {

        }

        private void btn4nuevo_Click(object sender, EventArgs e)
        {

        }

        private void btn3nuevo_Click(object sender, EventArgs e)
        {
            txt3bonificacion.Clear();
            //txt3horasextras.Clear();
            txt3horasnormales.Clear();
            //txt3pagohora.Clear();
            txt3pagonormal.Clear();
            txt3sueldobruto.Clear();
            txt3sueldoneto.Clear();
            chk3bonificacion.Checked = false;
        }

        private void btn3calcular_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int horasextras, horasnormales;
            double pagohnormal, pagohextra, sueldobruto, sueldoneto, bonificacion;
            Boolean marcado;
            //Entrada de datos
            horasnormales = Convert.ToInt32(txt3horasnormales.Text);
            horasextras = 0;
            pagohnormal = Convert.ToDouble(txt3pagonormal.Text);
            pagohextra = 0;
            marcado = Convert.ToBoolean(chk3bonificacion.Checked);
            //Inicializar
            bonificacion = 0;
            //Proceso
            sueldobruto = 0;
            sueldoneto = 0;
            //Evaluar bonificación
            if (marcado == true)
            {
                if (horasnormales >= 9)
                {
                    horasextras = horasnormales - 8;
                    pagohextra = (pagohnormal * 0.35) + ((horasextras * pagohextra) * 0.10);
                    //pagohextra = (pagohnormal * 0.10)*horasextras;
                    //bonificacion = sueldobruto * pagohextra;
                    sueldobruto = (horasnormales * pagohnormal) + (horasextras * pagohextra);
                }
            }

                if (sueldobruto > 216.7812552083334 && sueldobruto < 325.1713541666666)
                {
                    double a = ((sueldobruto * 15) / 100);
                    sueldoneto = sueldobruto - a;
                }
                else if (sueldobruto > 325.171359375 && sueldobruto < 451.6265625)
                {
                    double b = ((sueldobruto * 20) / 100);
                    sueldoneto = sueldobruto - b;
                }
                else if (sueldobruto >= 451.6265677083334)
                {
                    double c = ((sueldobruto * 25) / 100);
                    sueldoneto = sueldobruto - c;
                }
                sueldobruto = (horasnormales * pagohnormal) + pagohextra;
                //sueldoneto = sueldobruto + pagohextra;
                //sueldoneto = sueldobruto + bonificacion;
                bonificacion = ((horasextras * pagohextra) * 0.10);
            //Salida
            txt3sueldobruto.Text = "RD$ " + Convert.ToString(sueldobruto);
            txt3bonificacion.Text = "RD$ " + Convert.ToString(bonificacion);
            txt3sueldoneto.Text = "RD$ " + Convert.ToString(sueldoneto);
        }
    }
}
