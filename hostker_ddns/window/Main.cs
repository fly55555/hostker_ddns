﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostker_ddns.window
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void DNS_Manage_Button_Click(object sender, EventArgs e)
        {
            var dns_manage = new DNS_Manage();
            dns_manage.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
