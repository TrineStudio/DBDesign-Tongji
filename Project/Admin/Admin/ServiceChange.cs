﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admin
{
    public partial class ServiceChange : Form
    {
        public ServiceChange()
        {
            InitializeComponent();
        }

        private void ServiceChange_Load(object sender, EventArgs e)
        {

        }

        private void charge_Click(object sender, EventArgs e)
        {
            ServiceRecharge serviceRechage = new ServiceRecharge();
            serviceRechage.Show();
            this.Hide();
        }

        private void balanceQuery_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Show();
            this.Hide();
        }

        private void lost_Click(object sender, EventArgs e)
        {
            ServiceCardLost serviceCardLost = new ServiceCardLost();
            serviceCardLost.Show();
            this.Hide();
        }

        private void historyQuery_Click(object sender, EventArgs e)
        {
            ServiceHistory serviceHistory = new ServiceHistory();
            serviceHistory.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
