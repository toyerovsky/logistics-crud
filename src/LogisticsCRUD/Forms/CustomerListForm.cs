using PSK.Databases.LogisticsCRUD.Domain.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PSK.Databases.LogisticsCRUD.Forms
{
    public partial class CustomerListForm : Form
    {
        public ICustomerRepository CustomerRepository { get; }

        private readonly IList<int> _rowsToUpdate = new List<int>();

        public CustomerListForm(ICustomerRepository customerRepository)
        {
            CustomerRepository = customerRepository;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var customers = CustomerRepository.GetAll().ToList();
            dataGridView.DataSource = bindingSource;
            bindingSource.DataSource = new BindingList<CustomerEntity>(customers);
            dataGridView.CellValueChanged += DataGridViewOnCellValueChanged;
        }

        private void DataGridViewOnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var rowNumber = dataGridView.CurrentCellAddress.Y;
            if (dataGridView.CurrentRow?.DataBoundItem is CustomerEntity customer
                && customer.Id != 0 && _rowsToUpdate.Contains(rowNumber) == false)
            {
                _rowsToUpdate.Add(rowNumber);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                if (MessageBox.Show(
                        $@"Czy na pewno chcesz usunąć {dataGridView.SelectedRows.Count} {(dataGridView.SelectedRows.Count == 1 ? "klienta" : "klientów")}?",
                        @"Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow customer in dataGridView.SelectedRows)
                    {
                        CustomerRepository.Delete(customer.DataBoundItem as CustomerEntity);
                    }

                    bindingSource.DataSource = new BindingList<CustomerEntity>(CustomerRepository.GetAll().ToList());
                }
                else
                {
                    MessageBox.Show(@"Należy wybrać jednego lub więcej klientów.");
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bindingSource.DataSource is BindingList<CustomerEntity> customerList)
            {
                var entitiesToAdd = customerList.Where(x => x.Id == 0);
                foreach (var entity in entitiesToAdd)
                {
                    CustomerRepository.Insert(entity);
                }

                foreach (var rowNumber in _rowsToUpdate)
                {
                    CustomerRepository.Update(customerList[rowNumber]);
                }

                bindingSource.DataSource = new BindingList<CustomerEntity>(CustomerRepository.GetAll().ToList());
                _rowsToUpdate.Clear();
            }
        }
    }
}
