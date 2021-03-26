using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_KAB_BATANG.DB;

using static PC_KAB_BATANG.Program;

namespace PC_KAB_BATANG.Forms {
    public partial class FormMasterVehicle : Form {

        bool inInput = false;
        bool isUpdate = false;
        Vehicle vehicle = null;

        public FormMasterVehicle() {
            InitializeComponent();

            cboSearch.Items.Add("Owner Name");
            cboSearch.Items.Add("License Plate");
            cboSearch.SelectedIndex = 1;

            clear();
            input(false);
        }

        private void clear() {
            lblError.Text = "";

            dataGridView1.DataSource = Entities.Vehicle
                .Where(v => v.deleted_at == null)
                .ToList();

            txtPlate.Clear();
            cboType.DataSource = Entities.VehicleType.ToList();
            cboType.DisplayMember = "name";

            txtOwner.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtOwner.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtOwner.AutoCompleteCustomSource.AddRange(Entities.Member.ToList().Select(v => v.name).ToArray());
            txtOwner.Clear();

            txtNote.Clear();
        }

        private void input(bool v) {
            btnInsert.Enabled
                = btnUpdate.Enabled
                = btnDelete.Enabled
                = !v;


            btnSubmit.Enabled
                = btnCancel.Enabled
                = cboType.Enabled
                = txtPlate.Enabled
                = txtNote.Enabled
                = v;

            inInput = v;
        }

        private void FormMasterVehicle_Load(object sender, EventArgs e) {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            var byOwner = cboSearch.SelectedIndex == 1;
            var text = txtSearch.Text.Trim();

            dataGridView1.DataSource = Entities.Vehicle
                .Where(v => byOwner ? v.Member.name.Contains(text) : v.license_plate.Contains(text))
                .ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            if (inInput) return;

            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[idDataGridViewTextBoxColumn.Index].Value);

            vehicle = Entities.Vehicle
                .Where(v => v.id == id)
                .FirstOrDefault();

            txtPlate.Text = vehicle.license_plate;
            cboType.SelectedItem = vehicle.VehicleType;
            txtOwner.Text = vehicle.Member.name;
            txtNote.Text = vehicle.notes;

            if (vehicle.last_updated_at != null) {
                lblHistory.Text = "This record is last modified at " + vehicle.last_updated_at?.ToString("yyyy-MM-dd, HH:mm:ss");
            } else {
                lblError.Text = "";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            isUpdate = false;
            clear();
            input(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            isUpdate = true;
            input(true);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Delete vehicle " + vehicle.license_plate + "?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                vehicle.deleted_at = DateTime.Now;
                Entities.SaveChanges();
            }
            clear();
            input(false);
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            lblError.Text = "";

            var vehicle = isUpdate
                ? this.vehicle
                : new Vehicle();

            var plate = txtPlate.Text.Trim();
            var owner = txtOwner.Text.Trim();

            if (plate.Length == 0) {
                lblError.Text = "Fill the license plate";
                return;
            }

            if (owner.Length == 0) {
                lblError.Text = "Fill the owner name";
                return;
            }

            var member = Entities.Member.Where(v => v.name.Equals(owner)).FirstOrDefault();

            vehicle.VehicleType = (VehicleType)cboType.SelectedItem;
            vehicle.license_plate = plate;
            vehicle.Member = member;
            vehicle.notes = txtNote.Text;

            if (isUpdate) {
                vehicle.last_updated_at = DateTime.Now;
            } else {
                vehicle.created_at = DateTime.Now;
                Entities.Vehicle.Add(vehicle);
            }
            Entities.SaveChanges();

            clear();
            input(false);
        }

        private void btnCancel_Click(object sender, EventArgs e) {

        }
    }
}
