using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static PC_KAB_BATANG.Program;

namespace PC_KAB_BATANG.Forms {
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();

            lblError.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            lblError.Text = "";

            Employee = null;

            int id;
            if (!Int32.TryParse(txtId.Text, out id)) {
                lblError.Text = "Employee id must be integer";
                return;
            }

            var bytes = Sha256.ComputeHash(Encoding.UTF8.GetBytes(txtPassword.Text));
            var builder = new StringBuilder();

            foreach (byte b in bytes) {
                builder.Append(b.ToString("x2"));
            }

            string password = builder.ToString();

            var employee = Entities.Employee
                .Where(v => v.id == id)
                .FirstOrDefault();

            if (employee == null) {
                lblError.Text = "Invalid ID";
                return;
            }

            if (!employee.password.Equals(password)) {
                lblError.Text = "Wrong Password";
                return;
            }

            Employee = employee;

            Hide();
            new FormMain().ShowDialog();
            Close();
        }
    }
}
