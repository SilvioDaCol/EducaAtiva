﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameLearning
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void telaInicial_Load(object sender, EventArgs e)
        {
            
                this.Top = 0;
                this.Left = 0;
                this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
                this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            
        }

        private void logoMaior_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Close();
            Form login = new Form();
            Application.Run(login);
        }
    }
}
