using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;
using MetroFramework;

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
            txt3deducciones.Clear();
            txt3horasnormales.Clear();
            txt3pagonormal.Clear();
            txt3sueldobruto.Clear();
            txt3sueldoneto.Clear();
            chk3bonificacion.Checked = false;
        }

        private void btn3calcular_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int horasextras, horasnormales;
            double pagohnormal, pagohextra, sueldobruto, sueldoneto, impuesto, bonificacion;
            Boolean marcado;
            //Entrada de datos
            //if (txt3horasnormales.Text == "" || txt3pagonormal.Text == "")
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Favor completar todos los campos antes de continuar.", "Calculadora de Sueldo");
            //}
            horasnormales = Convert.ToInt32(txt3horasnormales.Text);
            pagohnormal = Convert.ToDouble(txt3pagonormal.Text);
            marcado = Convert.ToBoolean(chk3bonificacion.Checked);
            //Inicializar
            bonificacion = 0;
            sueldoneto = 0;
            pagohextra = 0;
            horasextras = 0;
            impuesto = 0;
            //Evaluar bonificación
            if (marcado == true)
            {
                if (horasnormales >= 9)
                {
                    horasextras = horasnormales - 8;
                    pagohextra = (pagohnormal * 0.35) + bonificacion;
                    bonificacion = ((horasextras * pagohextra) * 0.10);
                }
                else
                {
                    horasextras = 0;
                    pagohextra = 0;
                    bonificacion = 0;
                }
            }
            //Proceso
            sueldobruto = (horasnormales * pagohnormal) + (horasextras * pagohextra) + pagohextra + bonificacion;

            if (sueldobruto >= 216.7812552083334 && sueldobruto <= 325.1713541666666)
            {
                impuesto = ((sueldobruto * 15) / 100);
                sueldoneto = sueldobruto - impuesto;
            }
            else if (sueldobruto >= 325.171359375 && sueldobruto <= 451.6265625)
            {
                impuesto = ((sueldobruto * 20) / 100);
                sueldoneto = sueldobruto - impuesto;
            }
            else if (sueldobruto >= 451.6265677083334)
            {
                impuesto = ((sueldobruto * 25) / 100);
                sueldoneto = sueldobruto - impuesto;
            }
            //Salida
            txt3sueldobruto.Text = "RD$ " + Convert.ToString(sueldobruto);
            txt3bonificacion.Text = "RD$ " + Convert.ToString(bonificacion);
            txt3deducciones.Text = "RD$ " + Convert.ToString(impuesto);
            txt3sueldoneto.Text = "RD$ " + Convert.ToString(sueldoneto);
        }
    }
}
