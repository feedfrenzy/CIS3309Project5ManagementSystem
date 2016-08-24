﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class frmManagementSystem : Form
    {
        public frmManagementSystem()
        {
            InitializeComponent();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            frmManager mform = new frmManager();
            mform.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee eform = new frmEmployee();
            eform.ShowDialog();
        }
    }
}
