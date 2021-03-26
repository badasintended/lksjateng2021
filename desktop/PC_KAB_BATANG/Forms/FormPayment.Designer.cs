
namespace PC_KAB_BATANG.Forms {
    partial class FormPayment {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpOutTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpInTime = new System.Windows.Forms.DateTimePicker();
            this.dtpInDate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAmn = new System.Windows.Forms.TextBox();
            this.txtDur = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "PAYMENT";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboType);
            this.panel1.Controls.Add(this.txtPlate);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 330);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Vehicle Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "License Plate";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(130, 51);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(200, 24);
            this.cboType.TabIndex = 13;
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(130, 23);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(200, 22);
            this.txtPlate.TabIndex = 12;
            this.txtPlate.TextChanged += new System.EventHandler(this.txtPlate_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dtpOutTime);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dtpOutDate);
            this.panel3.Location = new System.Drawing.Point(13, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 94);
            this.panel3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date";
            // 
            // dtpOutTime
            // 
            this.dtpOutTime.Checked = false;
            this.dtpOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOutTime.Location = new System.Drawing.Point(116, 57);
            this.dtpOutTime.Name = "dtpOutTime";
            this.dtpOutTime.Size = new System.Drawing.Size(200, 22);
            this.dtpOutTime.TabIndex = 3;
            this.dtpOutTime.Value = new System.DateTime(2021, 3, 23, 15, 12, 59, 0);
            this.dtpOutTime.ValueChanged += new System.EventHandler(this.dtpOutTime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "OUT";
            // 
            // dtpOutDate
            // 
            this.dtpOutDate.Location = new System.Drawing.Point(116, 29);
            this.dtpOutDate.Name = "dtpOutDate";
            this.dtpOutDate.Size = new System.Drawing.Size(200, 22);
            this.dtpOutDate.TabIndex = 2;
            this.dtpOutDate.ValueChanged += new System.EventHandler(this.dtpOutDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpInTime);
            this.panel2.Controls.Add(this.dtpInDate);
            this.panel2.Location = new System.Drawing.Point(13, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 94);
            this.panel2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "IN";
            // 
            // dtpInTime
            // 
            this.dtpInTime.Checked = false;
            this.dtpInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInTime.Location = new System.Drawing.Point(116, 62);
            this.dtpInTime.Name = "dtpInTime";
            this.dtpInTime.Size = new System.Drawing.Size(200, 22);
            this.dtpInTime.TabIndex = 1;
            this.dtpInTime.Value = new System.DateTime(2021, 3, 23, 15, 12, 59, 0);
            this.dtpInTime.ValueChanged += new System.EventHandler(this.dtpInTime_ValueChanged);
            // 
            // dtpInDate
            // 
            this.dtpInDate.Location = new System.Drawing.Point(116, 34);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(200, 22);
            this.dtpInDate.TabIndex = 0;
            this.dtpInDate.ValueChanged += new System.EventHandler(this.dtpInDate_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtMember);
            this.panel4.Controls.Add(this.txtOwner);
            this.panel4.Location = new System.Drawing.Point(408, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 106);
            this.panel4.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Member Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Owner";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(127, 46);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(185, 22);
            this.txtMember.TabIndex = 15;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(127, 18);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(185, 22);
            this.txtOwner.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.txtRate);
            this.panel5.Controls.Add(this.btnSubmit);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txtAmn);
            this.panel5.Controls.Add(this.txtDur);
            this.panel5.Location = new System.Drawing.Point(408, 158);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(345, 218);
            this.panel5.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Hourly Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(127, 47);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(185, 22);
            this.txtRate.TabIndex = 17;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(212, 139);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 37);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 17);
            this.label15.TabIndex = 23;
            this.label15.Text = "Amount to Pay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "_______________________________ X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Parking Duration";
            // 
            // txtAmn
            // 
            this.txtAmn.Location = new System.Drawing.Point(127, 100);
            this.txtAmn.Name = "txtAmn";
            this.txtAmn.Size = new System.Drawing.Size(185, 22);
            this.txtAmn.TabIndex = 18;
            // 
            // txtDur
            // 
            this.txtDur.Location = new System.Drawing.Point(127, 16);
            this.txtDur.Name = "txtDur";
            this.txtDur.Size = new System.Drawing.Size(185, 22);
            this.txtDur.TabIndex = 16;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpInTime;
        private System.Windows.Forms.DateTimePicker dtpInDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpOutTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOutDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAmn;
        private System.Windows.Forms.TextBox txtDur;
    }
}