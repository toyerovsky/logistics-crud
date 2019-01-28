using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using PSK.Databases.LogisticsCRUD.Domain.Courier;

namespace PSK.Databases.LogisticsCRUD.Forms
{
    public partial class CourierListForm : Form
    {
        public ICourierRepository CourierRepository { get; }

        private readonly IList<int> _rowsToUpdate = new List<int>();

        public CourierListForm(ICourierRepository courierRepository)
        {
            CourierRepository = courierRepository;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var couriers = CourierRepository.GetAll().ToList();
            dataGridView.DataSource = bindingSource;
            bindingSource.DataSource = new BindingList<CourierEntity>(couriers);
            dataGridView.CellValueChanged += DataGridViewOnCellValueChanged;
        }

        private void DataGridViewOnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var rowNumber = dataGridView.CurrentCellAddress.Y;
            if (dataGridView.CurrentRow?.DataBoundItem is CourierEntity courier
                && courier.Id != 0 && _rowsToUpdate.Contains(rowNumber) == false)
            {
                _rowsToUpdate.Add(rowNumber);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                if (MessageBox.Show(
                        $@"Czy na pewno chcesz usunąć {dataGridView.SelectedRows.Count} {(dataGridView.SelectedRows.Count == 1 ? "kuriera" : "kurierów")}?",
                        @"Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        CourierRepository.Delete(row.DataBoundItem as CourierEntity);
                    }

                    bindingSource.DataSource = new BindingList<CourierEntity>(CourierRepository.GetAll().ToList());
                }
                else
                {
                    MessageBox.Show(@"Należy wybrać jednego lub więcej kurierów.");
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bindingSource.DataSource is BindingList<CourierEntity> courierList)
            {
                var entitiesToAdd = courierList.Where(x => x.Id == 0);
                foreach (var entity in entitiesToAdd)
                {
                    CourierRepository.Insert(entity);
                }

                foreach (var rowNumber in _rowsToUpdate)
                {
                    CourierRepository.Update(courierList[rowNumber]);
                }

                bindingSource.DataSource = new BindingList<CourierEntity>(CourierRepository.GetAll().ToList());
                _rowsToUpdate.Clear();
            }
        }
    }
}
