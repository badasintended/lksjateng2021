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
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();

            lblWelcome.Text = "Welcome, " + Employee.name;
            lblTime.Text = DateTime.Now.ToString("dddd, dd MM yyyy, HH:mm:ss");
        }

        private void btnMember_Click(object sender, EventArgs e) {
            Hide();
            new FormMasterMember().ShowDialog();
        }

        private void btnVehicle_Click(object sender, EventArgs e) {
            Hide();
            new FormMasterVehicle().ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e) {
            Hide();
            new FormPayment().ShowDialog();
        }
    }
}
