using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using PSK.Databases.LogisticsCRUD.Domain;
using PSK.Databases.LogisticsCRUD.Domain.Complaint;
using PSK.Databases.LogisticsCRUD.Domain.Courier;
using PSK.Databases.LogisticsCRUD.Domain.Vehicle;

namespace PSK.Databases.LogisticsCRUD.Forms
{
    public partial class ComplaintListForm : Form
    {
        public IComplaintRepository ComplaintRepository { get; }

        private readonly IList<int> _rowsToUpdate = new List<int>();

        public ComplaintListForm(IComplaintRepository complaintRepository)
        {
            ComplaintRepository = complaintRepository;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var complaint = ComplaintRepository.GetAll().ToList();
            dataGridView.DataSource = bindingSource;
            bindingSource.DataSource = new BindingList<ComplaintEntity>(complaint);
            dataGridView.CellValueChanged += DataGridViewOnCellValueChanged;
        }

        private void DataGridViewOnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var rowNumber = dataGridView.CurrentCellAddress.Y;
            if (dataGridView.CurrentRow?.DataBoundItem is ComplaintEntity complaint
                && complaint.Id != 0 && _rowsToUpdate.Contains(rowNumber) == false)
            {
                _rowsToUpdate.Add(rowNumber);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                if (MessageBox.Show(
                        $@"Czy na pewno chcesz usunąć {dataGridView.SelectedRows.Count} {(dataGridView.SelectedRows.Count == 1 ? "paczkę" : "paczek")}?",
                        @"Potwierdzenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        ComplaintRepository.Delete(row.DataBoundItem as ComplaintEntity);
                    }

                    bindingSource.DataSource = new BindingList<ComplaintEntity>(ComplaintRepository.GetAll().ToList());
                }
                else
                {
                    MessageBox.Show(@"Należy wybrać jedną lub więcej paczek.");
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bindingSource.DataSource is BindingList<ComplaintEntity> vehicleList)
            {
                var entitiesToAdd = vehicleList.Where(x => x.Id == 0);
                foreach (var entity in entitiesToAdd)
                {
                    ComplaintRepository.Insert(entity);
                }

                foreach (var rowNumber in _rowsToUpdate)
                {
                    ComplaintRepository.Update(vehicleList[rowNumber]);
                }

                bindingSource.DataSource = new BindingList<ComplaintEntity>(ComplaintRepository.GetAll().ToList());
                _rowsToUpdate.Clear();
            }
        }
    }
}
