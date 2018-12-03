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

namespace Calculadoa
{
    public partial class Calculadora : MetroFramework.Forms.MetroForm
    {
        double num1, num2, result, a, b, c;
        string op;
        public Calculadora()
        {
            InitializeComponent();
        }

        //funciones generales I

        public void numero1()
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "1";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "1";
            }
        }

        public void numero2()
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "2";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "2";
            }
        }

        public void numero3()
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "3";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "3";
            }
        }

        public void numero4()
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "4";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "4";
            }
        }

        public void numero5()
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "5";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "5";
            }
        }

        public void numero6()
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "6";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "6";
            }
        }

        public void numero7()
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "7";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "7";
            }
        }

        public void numero8()
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "8";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "8";
            }
        }

        public void numero9()
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "9";
            }
            else
            {
                txtvalor.Text = txtvalor.Text + "9";
            }
        }

        public void numero0()
        {
            if (txtvalor.Text.Length == 0)
            {
                txtvalor.Text = "0";
            }
            else if (txtvalor.Text.Substring(0) != "0")
            {
                txtvalor.Text = txtvalor.Text + "0";
            }
        }

        public void punto()
        {
            if (txtvalor.Text == "")
            {
                txtvalor.Text = "0.";
            }
            //else
            //{
            //    txtvalor.Text = txtvalor.Text + ".";
            //}
            if (txtvalor.Text.Contains("."))
            {
                btnpunto.Enabled = false;
            }
            else
            {
                txtvalor.Text = txtvalor.Text + ".";
            }
        }

        public void suma()
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "+";
        }

        public void resta()
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "-";
        }

        public void multiplicar()
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "*";
        }

        public void dividir()
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "/";
        }

        public void limpiar()
        {
            txtvalor.Clear();
            btnpunto.Enabled = true;
        }

        public void borrar()
        {
            if (txtvalor.Text == "")
            {
                btnpunto.Enabled = true;
                return;
            }
            else
            {
                txtvalor.Text = txtvalor.Text.Remove(txtvalor.Text.Length - 1, 1);
            }
            btnpunto.Enabled = !txtvalor.Text.Contains(".") && txtvalor.Text != "";
        }

        public void imprimir()
        {
            //Codigo para hacer el cuadro de guardado
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Cálculo.txt";
            savefile.Filter = "Text files (*.txt)|*.txt";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.WriteLine(
                        "El primer valor fue: " + num1 + Environment.NewLine +
                        "El segundo valor fue: " + num2 + Environment.NewLine +
                        "El operador utilizado fue: " + op + Environment.NewLine +
                        "El resultado fue: " + result
                        );
                //Esto abre el archivo una vez guardado
                System.Diagnostics.Process.Start(savefile.FileName);
            }
        }

        public void calcular()
        {
            if (txtvalor.Text == "" || txtvalor.Text == "Por favor introducir los valores.")
            {
                txtvalor.Text = "Por favor introducir los valores.";
            }
            else
            {
                num2 = Convert.ToDouble(txtvalor.Text);
                if (op == "+")
                {
                    result = (num1 + num2);
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "-")
                {
                    result = (num1 - num2);
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "*")
                {
                    result = (num1 * num2);
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "/")
                {
                    if (num2 == 0)
                    {
                        txtvalor.Text = "No se puede dividir entre cero.";
                    }
                    else
                    {
                        result = (num1 / num2);
                        txtvalor.Text = Convert.ToString(result);
                        num1 = result;
                    }
                }
                if (op == "%")
                {
                    result = ((num1 * num2)/100);
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "1/x")
                {
                    result = (num1*1/num2);
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "raiz")
                {
                    if (num2 >= 0)
                    {
                        result = (Math.Sqrt(num1*num2));
                        txtvalor.Text = Convert.ToString(result);
                        num1 = result;
                    }
                    else
                    {
                        txtvalor.Text = "La raíz de números negativos es imaginaria.";
                    }
                }
                if (op == "xy")
                {
                    result = (Math.Pow(num1,num2));
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "log")
                {
                    result = (Math.Log10(num2*num1));
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "xy")
                {
                    result = (Math.Pow(num1*num2, -1));
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                //if (op == "pi")
                //{
                //    result = (Math.PI);
                //    txtvalor.Text = Convert.ToString(result);
                //    num1 = result;
                //}
                //if (op == "e")
                //{
                //    result = (Math.E);
                //    txtvalor.Text = Convert.ToString(result);
                //    num1 = result;
                //}
                if (op == "exp")
                {
                    result = (Math.Exp(num2*num1));
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "yraizx")
                {
                    if (num1 <= 0)
                    {
                        txtvalor.Text = "La raíz de números negativos es imaginaria.";
                    }
                    else
                    {
                        double a = 1, c = a/num2;
                        result = (Math.Pow(num1, c));
                        txtvalor.Text = Convert.ToString(result);
                        num1 = result;
                    }
                }
                if (op == "10x")
                {
                    result = (Math.Pow(10, num2*num1));
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "fac")
                {
                    result = 1;
                    for (b = 1; b <= num1*num2; b++)
                    {
                        result = result * b;
                    }
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "tan")
                {
                    result = (num1 * Math.Tan(num2));
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "sen")
                {
                    result = (num1 * Math.Sin(num2));
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "cos")
                {
                    result = (num1 * Math.Cos(num2));
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "tanm1")
                {
                    result = (num1 * Math.Atan(num2));
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "senm1")
                {
                    result = (num1 * Math.Asin(num2));
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (op == "cosm1")
                {
                    result = (num1 * Math.Acos(num2));
                    txtvalor.Text = Convert.ToString(result);
                    num1 = result;
                }
            }
        }

        //funciones generales T

        private void btn1_Click_2(object sender, EventArgs e)
        {
            numero1();
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            numero2();
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            numero3();
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            numero4();
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            numero5();
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            numero6();
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            numero7();
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            numero8();
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            numero9();
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            numero0();
        }

        private void btnsum_Click_1(object sender, EventArgs e)
        {
            suma();
        }

        private void btnrest_Click_1(object sender, EventArgs e)
        {
            resta();
        }

        private void btnmult_Click_1(object sender, EventArgs e)
        {
            multiplicar();
        }

        private void btndiv_Click_1(object sender, EventArgs e)
        {
            dividir();
        }

        private void btnborrar_Click_1(object sender, EventArgs e)
        {
            borrar();
        }

        private void btnprint_Click_1(object sender, EventArgs e)
        {
            imprimir();
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnpunto_Click_1(object sender, EventArgs e)
        {
            punto();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtvalor_Leave(object sender, EventArgs e)
        {
            txt1valor.Text = txtvalor.Text;
            txtvalor.Text = txt1valor.Text;
        }

        private void txt1valor_Enter(object sender, EventArgs e)
        {
            txt1valor.Text = txtvalor.Text;
            txtvalor.Text = txt1valor.Text;
        }

        private void txtvalor_Enter(object sender, EventArgs e)
        {
            txt1valor.Text = txtvalor.Text;
            txtvalor.Text = txt1valor.Text;
        }

        private void txt1valor_Leave(object sender, EventArgs e)
        {
            txt1valor.Text = txtvalor.Text;
            txtvalor.Text = txt1valor.Text;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            txtvalor.Focus();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {
            txt1valor.Focus();
        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {
            txt1valor.Text = txtvalor.Text;
            txtvalor.Text = txt1valor.Text;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            numero1();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            numero2();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            numero3();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            numero4();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            numero5();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            numero6();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            numero7();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            numero8();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            numero9();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            numero0();
        }

        private void btn1punto_Click(object sender, EventArgs e)
        {
            punto();
        }

        private void btn1sum_Click(object sender, EventArgs e)
        {
            suma();
        }

        private void btn1rest_Click(object sender, EventArgs e)
        {
            resta();
        }

        private void btn1mult_Click(object sender, EventArgs e)
        {
            multiplicar();
        }

        private void btn1div_Click(object sender, EventArgs e)
        {
            dividir();
        }

        private void btn1clear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn1borrar_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void btn1print_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void txt1valor_TextChanged(object sender, EventArgs e)
        {
            txt1valor.Text = txtvalor.Text;
            txtvalor.Text = txt1valor.Text;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {

        }

        private void btnpunto_Click(object sender, EventArgs e)
        {

        }

        private void btncalc_Click_1(object sender, EventArgs e)
        {

        }

        private void btnmult_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }

        private void btnrest_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

        }

        private void btnsum_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btn1porciento_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "%";
        }

        private void btn11x_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "1/x";
        }

        private void btn1raiz_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "raiz";
        }

        private void btn1log_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "log";
        }

        private void btn1xy_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "xy";
        }

        private void btn1xm1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "xm1";
        }

        private void btn1pi_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "3.14159265359";
            //op = "pi";
        }

        private void btn1e_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "2.71828182846";
            //op = "e";
        }

        private void btn1exp_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "exp";
        }

        private void btn1mon_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = Convert.ToString(0 - Convert.ToDouble(txt1valor.Text));
            //op = "mon";
        }

        private void btn1tan_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "tan";
        }

        private void btn1cos_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "cos";
        }

        private void btn1sen_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "sen";
        }

        private void btn1senm1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "senm1";
        }

        private void btn1cosm1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "cosm1";
        }

        private void btn1tanm1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "tanm1";
        }

        private void btn1yraizx_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "yraizx";
        }

        private void btn110x_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "10x";
        }

        private void btnnfac_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = "";
            op = "fac";
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
