﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElFaroV1
{
    public partial class FormMozo : Form
    {
        public FormMozo()
        {
            InitializeComponent();
        }

        private void FormMozo_Load(object sender, EventArgs e)
        {

        }

        private void btnMesaA1_Click(object sender, EventArgs e)
        {
            ISMozo IS = new ISMozo();
            IS.ShowDialog();
        }
    }
}
