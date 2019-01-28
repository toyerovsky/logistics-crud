using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using PSK.Databases.LogisticsCRUD.Domain.Courier;
using PSK.Databases.LogisticsCRUD.Domain.Vehicle;

namespace PSK.Databases.LogisticsCRUD.Forms
{
    public partial class VehicleListForm : Form
    {
        public IVehicleRepository VehicleRepository { get; }

        private readonly IList<int> _rowsToUpdate = new List<int>();

        public VehicleListForm(IVehicleRepository vehicleRepository)
        {
            VehicleRepository = vehicleRepository;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var vehicles = VehicleRepository.GetAll().ToList();
            dataGridView.DataSource = bindingSource;
            bindingSource.DataSource = new BindingList<VehicleEntity>(vehicles);
            dataGridView.CellValueChanged += DataGridViewOnCellValueChanged;
        }

        private void DataGridViewOnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var rowNumber = dataGridView.CurrentCellAddress.Y;
            if (dataGridView.CurrentRow?.DataBoundItem is VehicleEntity vehicle
                && vehicle.Id != 0 && _rowsToUpdate.Contains(rowNumber) == false)
            {
                _rowsToUpdate.Add(rowNumber);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                if (MessageBox.Show(
                        $@"Czy na pewno chcesz usunąć {dataGridView.SelectedRows.Count} {(dataGridView.SelectedRows.Count == 1 ? "pojazd" : "pojazów")}?",
                        @"Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        VehicleRepository.Delete(row.DataBoundItem as VehicleEntity);
                    }

                    bindingSource.DataSource = new BindingList<VehicleEntity>(VehicleRepository.GetAll().ToList());
                }
                else
                {
                    MessageBox.Show(@"Należy wybrać jeden lub więcej pojazdów.");
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bindingSource.DataSource is BindingList<VehicleEntity> courierList)
            {
                var entitiesToAdd = courierList.Where(x => x.Id == 0);
                foreach (var entity in entitiesToAdd)
                {
                    VehicleRepository.Insert(entity);
                }

                foreach (var rowNumber in _rowsToUpdate)
                {
                    VehicleRepository.Update(courierList[rowNumber]);
                }

                bindingSource.DataSource = new BindingList<VehicleEntity>(VehicleRepository.GetAll().ToList());
                _rowsToUpdate.Clear();
            }
        }
    }
}
