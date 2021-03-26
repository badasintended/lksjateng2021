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
    public partial class FormPayment : Form {

        int dur = 0;
        int rate = 0;
        Vehicle vehicle;
        string plate = "";

        public FormPayment() {
            InitializeComponent();

            cboType.DataSource = Entities.VehicleType.ToList();
            cboType.DisplayMember = "name";
        }


        private void btnSubmit_Click(object sender, EventArgs e) {
            var data = new ParkingData();
            data.Vehicle = vehicle;
            data.Employee = Program.Employee;
            data.hourly_rates_id = rate;
            data.license_plate = plate;
        }

        private void txtPlate_TextChanged(object sender, EventArgs e) {
            plate = txtPlate.Text.Trim();
            vehicle = Entities.Vehicle
                .Where(v => v.license_plate.Equals(plate))
                .FirstOrDefault();

            if (vehicle != null) {
                cboType.SelectedItem = vehicle.VehicleType;
                txtOwner.Text = vehicle.Member.name;
                txtMember.Text = vehicle.Member.Membership.name;
                rate = 1000;
            } else {
                rate = 2000;
            }
        }

        private void calc() {
            dur = (int)Math.Ceiling((dtpOutDate.Value.AddHours(dtpOutDate.Value.Hour).Ticks - dtpInDate.Value.AddHours(dtpInTime.Value.Hour).Ticks) / 12000.0);
            txtDur.Text = dur.ToString();
            txtRate.Text = rate.ToString();
            txtAmn.Text = (dur * rate).ToString();
        }

        private void dtpInDate_ValueChanged(object sender, EventArgs e) {
            calc();
        }

        private void dtpInTime_ValueChanged(object sender, EventArgs e) {
            calc();

        }

        private void dtpOutDate_ValueChanged(object sender, EventArgs e) {
            calc();

        }

        private void dtpOutTime_ValueChanged(object sender, EventArgs e) {
            calc();

        }
    }
}
