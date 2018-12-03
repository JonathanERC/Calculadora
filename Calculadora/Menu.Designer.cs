namespace Calculadoa
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn2calc = new MetroFramework.Controls.MetroTile();
            this.btn2sueldo = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btn2calc
            // 
            this.btn2calc.ActiveControl = null;
            this.btn2calc.Location = new System.Drawing.Point(38, 63);
            this.btn2calc.Name = "btn2calc";
            this.btn2calc.Size = new System.Drawing.Size(100, 61);
            this.btn2calc.TabIndex = 0;
            this.btn2calc.Text = "Calculadora \r\nMatemática";
            this.btn2calc.UseSelectable = true;
            this.btn2calc.Click += new System.EventHandler(this.btn2calc_Click);
            // 
            // btn2sueldo
            // 
            this.btn2sueldo.ActiveControl = null;
            this.btn2sueldo.Location = new System.Drawing.Point(38, 130);
            this.btn2sueldo.Name = "btn2sueldo";
            this.btn2sueldo.Size = new System.Drawing.Size(100, 63);
            this.btn2sueldo.TabIndex = 0;
            this.btn2sueldo.Text = "Calculadora\r\nde Sueldo";
            this.btn2sueldo.UseSelectable = true;
            this.btn2sueldo.Click += new System.EventHandler(this.btn2sueldo_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 215);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Jonathan Rondón";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 238);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn2sueldo);
            this.Controls.Add(this.btn2calc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn2calc;
        private MetroFramework.Controls.MetroTile btn2sueldo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}