
namespace PC_KAB_BATANG.Forms {
    partial class FormMain {
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
            this.btnMember = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "MANDHEG PARKING SYSTEM";
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(92, 119);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(127, 38);
            this.btnMember.TabIndex = 7;
            this.btnMember.Text = "Master Member";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(92, 163);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(127, 38);
            this.btnVehicle.TabIndex = 8;
            this.btnVehicle.Text = "Master Vehicle";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(92, 206);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(127, 38);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "Parking Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(46, 17);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "label1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 17);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "label2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 279);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnVehicle);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.label3);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTime;
    }
}