using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using PSK.Databases.LogisticsCRUD.Domain;
using PSK.Databases.LogisticsCRUD.Domain.Courier;

namespace PSK.Databases.LogisticsCRUD.Forms
{
    public partial class PackageListForm : Form
    {
        public IPackageRepository PackageRepository { get; }

        private readonly IList<int> _rowsToUpdate = new List<int>();

        public PackageListForm(IPackageRepository packageRepository)
        {
            PackageRepository = packageRepository;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var packages = PackageRepository.GetAll().ToList();
            dataGridView.DataSource = bindingSource;
            bindingSource.DataSource = new BindingList<PackageEntity>(packages);
            dataGridView.CellValueChanged += DataGridViewOnCellValueChanged;
        }

        private void DataGridViewOnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var rowNumber = dataGridView.CurrentCellAddress.Y;
            if (dataGridView.CurrentRow?.DataBoundItem is PackageEntity package
                && package.Id != 0 && _rowsToUpdate.Contains(rowNumber) == false)
            {
                _rowsToUpdate.Add(rowNumber);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                if (MessageBox.Show(
                        $@"Czy na pewno chcesz usunąć {dataGridView.SelectedRows.Count} {(dataGridView.SelectedRows.Count == 1 ? "paczkę" : "paczki")}?",
                        @"Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow customer in dataGridView.SelectedRows)
                    {
                        PackageRepository.Delete(customer.DataBoundItem as PackageEntity);
                    }

                    bindingSource.DataSource = new BindingList<PackageEntity>(PackageRepository.GetAll().ToList());
                }
                else
                {
                    MessageBox.Show(@"Należy wybrać jednego lub więcej paczek.");
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bindingSource.DataSource is BindingList<PackageEntity> packageList)
            {
                var entitiesToAdd = packageList.Where(x => x.Id == 0);
                foreach (var entity in entitiesToAdd)
                {
                    PackageRepository.Insert(entity);
                }

                foreach (var rowNumber in _rowsToUpdate)
                {
                    PackageRepository.Update(packageList[rowNumber]);
                }

                bindingSource.DataSource = new BindingList<PackageEntity>(PackageRepository.GetAll().ToList());
                _rowsToUpdate.Clear();
            }
        }
    }
}
