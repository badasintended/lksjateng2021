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
    public partial class FormMasterMember : Form {

        bool inInput = false;
        bool isUpdate = false;
        Member member = null;

        public FormMasterMember() {
            InitializeComponent();

            clear();
            input(false);
        }

        private void clear() {
            lblError.Text = "";

            dataView.DataSource = Entities.Member
                .Where(v => v.deleted_at == null)
                .ToList();

            txtName.Clear();
            cboType.DataSource = Entities.Membership
                .Where(v => v.id != 1)
                .ToList();
            cboType.DisplayMember = "name";
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dtpBirth.Value = DateTime.Now;
            rdoMale.Checked = rdoFemale.Checked = false;
        }

        private void input(bool v) {
            btnInsert.Enabled
                = btnUpdate.Enabled
                = btnDelete.Enabled
                = !v;


            btnSubmit.Enabled
                = btnCancel.Enabled
                = txtAddress.Enabled
                = cboType.Enabled
                = txtName.Enabled
                = txtEmail.Enabled
                = txtPhone.Enabled
                = txtAddress.Enabled
                = dtpBirth.Enabled
                = rdoFemale.Enabled
                = rdoMale.Enabled
                = v;

            inInput = v;
        }

        private void FormMasterMember_Load(object sender, EventArgs e) {
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            if (inInput) return;

            var id = Convert.ToInt32(dataView.Rows[e.RowIndex].Cells[idDataGridViewTextBoxColumn.Index].Value);

            member = Entities.Member
                .Where(v => v.id == id)
                .FirstOrDefault();

            txtName.Text = member.name;
            cboType.SelectedItem = member.Membership;
            txtEmail.Text = member.email;
            txtPhone.Text = member.phone_number;
            txtAddress.Text = member.address;
            dtpBirth.Value = member.date_of_birth;

            rdoFemale.Checked = member.gender.Equals("Female");
            rdoMale.Checked = !rdoFemale.Checked;

            if (member.last_updated_at != null) {
                lblHistory.Text = "This record is last modified at " + member.last_updated_at?.ToString("yyyy-MM-dd, HH:mm:ss");
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
            var result = MessageBox.Show("Delete member " + member.name + "?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                member.deleted_at = DateTime.Now;
                Entities.SaveChanges();
            }
            clear();
            input(false);
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            lblError.Text = "";

            var member = isUpdate
                ? this.member
                : new Member();

            var name = txtName.Text.Trim();
            var email = txtEmail.Text.Trim();
            var phone = txtPhone.Text.Trim();
            var address = txtAddress.Text.Trim();

            if (name.Length == 0) {
                lblError.Text = "Fill the name";
                return;
            }

            if (email.Length == 0) {
                lblError.Text = "Fill the name";
                return;
            }

            if (phone.Length == 0) {
                lblError.Text = "Fill the name";
                return;
            }

            if (address.Length == 0) {
                lblError.Text = "Fill the name";
                return;
            }

            if (!rdoFemale.Checked && !rdoFemale.Checked) {
                lblError.Text = "Select one gender";
                return;
            }

            member.Membership = (Membership)cboType.SelectedItem;
            member.name = txtName.Text;
            member.email = txtEmail.Text;
            member.phone_number = txtPhone.Text;
            member.address = txtAddress.Text;
            member.date_of_birth = dtpBirth.Value;
            member.gender = rdoFemale.Checked
                ? "Female"
                : "Male";

            if (isUpdate) {
                member.last_updated_at = DateTime.Now;
            } else {
                member.created_at = DateTime.Now();
                Entities.Member.Add(member);
            }
            Entities.SaveChanges();

            clear();
            input(false);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            clear();
            input(false);
        }
    }
}
