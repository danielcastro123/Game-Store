﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Reflection;

namespace inventario
{
    public partial class page1 : Form
    {
        
        private Random random;
        private int tempIndex;
        private IconButton currentBtn;
        public page1()
        {
            InitializeComponent();
         
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Form inventario = new inventario();
            inventario.Show();

            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Form MsgBox = new MsgBox();
            MsgBox.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta funcionando", "Funcionando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
