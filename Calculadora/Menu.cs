﻿using System;
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
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btn2calc_Click(object sender, EventArgs e)
        {
            Calculadora _ver = new Calculadora();
            _ver.Show();
        }

        private void btn2sueldo_Click(object sender, EventArgs e)
        {
            Form2 _ver = new Form2();
            _ver.Show();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
