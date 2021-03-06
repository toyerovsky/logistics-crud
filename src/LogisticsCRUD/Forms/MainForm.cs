﻿using Autofac;
using System;
using System.Windows.Forms;

namespace PSK.Databases.LogisticsCRUD.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Jest {DateTime.Now.ToString("D")}\nWybierz sekcję aplikacji";
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            var customersForm = Program.Container.Resolve<CustomerListForm>();
            customersForm.Show();
        }

        private void couriersButton_Click(object sender, EventArgs e)
        {
            var customersForm = Program.Container.Resolve<CourierListForm>();
            customersForm.Show();
        }

        private void complaintsButton_Click(object sender, EventArgs e)
        {
            var complaintForm = Program.Container.Resolve<ComplaintListForm>();
            complaintForm.Show();
        }

        private void packagesButton_Click(object sender, EventArgs e)
        {
            var packagesForm = Program.Container.Resolve<PackageListForm>();
            packagesForm.Show();
        }

        private void vehiclesButton_Click(object sender, EventArgs e)
        {
            var vehiclesForm = Program.Container.Resolve<VehicleListForm>();
            vehiclesForm.Show();
        }
    }
}
