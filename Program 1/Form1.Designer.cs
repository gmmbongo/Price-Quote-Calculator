namespace Program_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtCarType = new System.Windows.Forms.TextBox();
            this.txtWorkHours = new System.Windows.Forms.TextBox();
            this.txtPartsCost = new System.Windows.Forms.TextBox();
            this.txtStaffAssigned = new System.Windows.Forms.TextBox();
            this.txtSeniorCitizen = new System.Windows.Forms.TextBox();
            this.getQuoteBtn = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Smiths Auto Repair!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Work Hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parts Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Staff Assigned:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Senior Citizen? (0 or 1):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Cost:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(256, 99);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(144, 26);
            this.txtClientName.TabIndex = 8;
            this.txtClientName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCarType
            // 
            this.txtCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarType.Location = new System.Drawing.Point(256, 139);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(144, 26);
            this.txtCarType.TabIndex = 9;
            // 
            // txtWorkHours
            // 
            this.txtWorkHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkHours.Location = new System.Drawing.Point(256, 176);
            this.txtWorkHours.Name = "txtWorkHours";
            this.txtWorkHours.Size = new System.Drawing.Size(144, 26);
            this.txtWorkHours.TabIndex = 10;
            this.txtWorkHours.TextChanged += new System.EventHandler(this.txtWorkHours_TextChanged);
            // 
            // txtPartsCost
            // 
            this.txtPartsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartsCost.Location = new System.Drawing.Point(256, 212);
            this.txtPartsCost.Name = "txtPartsCost";
            this.txtPartsCost.Size = new System.Drawing.Size(144, 26);
            this.txtPartsCost.TabIndex = 11;
            this.txtPartsCost.TextChanged += new System.EventHandler(this.txtPartsCost_TextChanged);
            // 
            // txtStaffAssigned
            // 
            this.txtStaffAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffAssigned.Location = new System.Drawing.Point(256, 251);
            this.txtStaffAssigned.Name = "txtStaffAssigned";
            this.txtStaffAssigned.Size = new System.Drawing.Size(144, 26);
            this.txtStaffAssigned.TabIndex = 12;
            this.txtStaffAssigned.TextChanged += new System.EventHandler(this.txtStaffAssigned_TextChanged);
            // 
            // txtSeniorCitizen
            // 
            this.txtSeniorCitizen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeniorCitizen.Location = new System.Drawing.Point(256, 289);
            this.txtSeniorCitizen.Name = "txtSeniorCitizen";
            this.txtSeniorCitizen.Size = new System.Drawing.Size(144, 26);
            this.txtSeniorCitizen.TabIndex = 13;
            // 
            // getQuoteBtn
            // 
            this.getQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuoteBtn.Location = new System.Drawing.Point(102, 339);
            this.getQuoteBtn.Name = "getQuoteBtn";
            this.getQuoteBtn.Size = new System.Drawing.Size(187, 37);
            this.getQuoteBtn.TabIndex = 14;
            this.getQuoteBtn.Text = "Get Quote!";
            this.getQuoteBtn.UseVisualStyleBackColor = true;
            this.getQuoteBtn.Click += new System.EventHandler(this.getQuoteBtn_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(171, 399);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(118, 23);
            this.lblTotalCost.TabIndex = 15;
            this.lblTotalCost.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.getQuoteBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 459);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.getQuoteBtn);
            this.Controls.Add(this.txtSeniorCitizen);
            this.Controls.Add(this.txtStaffAssigned);
            this.Controls.Add(this.txtPartsCost);
            this.Controls.Add(this.txtWorkHours);
            this.Controls.Add(this.txtCarType);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quote Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtCarType;
        private System.Windows.Forms.TextBox txtWorkHours;
        private System.Windows.Forms.TextBox txtPartsCost;
        private System.Windows.Forms.TextBox txtStaffAssigned;
        private System.Windows.Forms.TextBox txtSeniorCitizen;
        private System.Windows.Forms.Button getQuoteBtn;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

