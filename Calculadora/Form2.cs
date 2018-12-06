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
            txt3horasextras.Clear();
            txt3pagoextra.Clear();
            txt3deducciones.Clear();
            txt3horasnormales.Clear();
            txt3pagonormal.Clear();
            txt3sueldobruto.Clear();
            txt3sueldoneto.Clear();
            chk3bonificacion.Checked = false;
        }

        public void calcular()
        {
            //Declarar variables
            int horasextras = 0;
            int horasnormales = 0;
            double pagohnormal = 0;
            double bonificacion = 0;
            double pagohextra, sueldobruto, sueldoneto, impuesto;
            Boolean marcado;
            //Condicionar Errores
            try
            {
                horasnormales = Convert.ToInt32(txt3horasnormales.Text);
                pagohnormal = Convert.ToDouble(txt3pagonormal.Text);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Verifique si los valores introducidos en los campo son válidos o si dejo algún campo en blanco.", "Calculadora de Sueldo");
            }

            marcado = Convert.ToBoolean(chk3bonificacion.Checked);
            //Inicializar
            sueldoneto = 0;
            pagohextra = 0;
            impuesto = 0;
            //Evaluar bonificación

            if (marcado == true)
            {
                if (horasnormales >= 9)
                {
                    horasextras = horasnormales - 8;
                    pagohextra = ((horasextras * pagohnormal) * 1.35D);
                    bonificacion = ((pagohextra) * 0.10D);
                }
                else
                {
                    pagohextra = 0;
                    bonificacion = 0;
                }
            }

            horasextras = horasnormales - 8;

            if (horasextras < 0)
            {
                horasextras = 0;
            }

            //Proceso
            sueldobruto = (horasnormales * pagohnormal) + (horasextras * pagohextra) + bonificacion;

            if (sueldobruto >= 216.7812552083334D && sueldobruto <= 325.1713541666666D)
            {
                impuesto = ((sueldobruto * 15) / 100);
                sueldoneto = sueldobruto - impuesto;
            }
            else if (sueldobruto >= 325.171359375D && sueldobruto <= 451.6265625D)
            {
                impuesto = ((sueldobruto * 20) / 100);
                sueldoneto = sueldobruto - impuesto;
            }
            else if (sueldobruto >= 451.6265677083334D)
            {
                impuesto = ((sueldobruto * 25) / 100);
                sueldoneto = sueldobruto - impuesto;
            }
            else
            {
                sueldoneto = sueldobruto;
            }
            //Salida
            txt3sueldobruto.Text = "RD$ " + Convert.ToString(sueldobruto);
            txt3bonificacion.Text = "RD$ " + Convert.ToString(bonificacion);
            txt3deducciones.Text = "RD$ " + Convert.ToString(impuesto);
            txt3sueldoneto.Text = "RD$ " + Convert.ToString(sueldoneto);
            txt3pagoextra.Text = "RD$ " + Convert.ToString(pagohextra); ;
            txt3horasextras.Text = Convert.ToString(horasextras) + " Hrs";
        }
        private void btn3calcular_Click(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
