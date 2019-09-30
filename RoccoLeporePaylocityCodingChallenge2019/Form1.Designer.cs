namespace RoccoLeporePaylocityCodingChallenge2019
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
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblSpouse = new System.Windows.Forms.Label();
            this.txtSpouse = new System.Windows.Forms.TextBox();
            this.lblOtherDependents = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lblAns = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(12, 21);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(90, 13);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Employee Name: ";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(108, 18);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(100, 20);
            this.txtEmployee.TabIndex = 1;
            // 
            // lblSpouse
            // 
            this.lblSpouse.AutoSize = true;
            this.lblSpouse.Location = new System.Drawing.Point(12, 65);
            this.lblSpouse.Name = "lblSpouse";
            this.lblSpouse.Size = new System.Drawing.Size(77, 13);
            this.lblSpouse.TabIndex = 2;
            this.lblSpouse.Text = "Spouse Name:";
            // 
            // txtSpouse
            // 
            this.txtSpouse.Location = new System.Drawing.Point(108, 62);
            this.txtSpouse.Name = "txtSpouse";
            this.txtSpouse.Size = new System.Drawing.Size(100, 20);
            this.txtSpouse.TabIndex = 3;
            // 
            // lblOtherDependents
            // 
            this.lblOtherDependents.AutoSize = true;
            this.lblOtherDependents.Location = new System.Drawing.Point(12, 123);
            this.lblOtherDependents.Name = "lblOtherDependents";
            this.lblOtherDependents.Size = new System.Drawing.Size(94, 13);
            this.lblOtherDependents.TabIndex = 4;
            this.lblOtherDependents.Text = "Other Dependents";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(12, 180);
            this.txtOther.Multiline = true;
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(149, 101);
            this.txtOther.TabIndex = 5;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(10, 304);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 30);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(167, 183);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 13);
            this.lblAns.TabIndex = 7;
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(12, 149);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(228, 13);
            this.lblDirections.TabIndex = 8;
            this.lblDirections.Text = "Please have the names seperated by a comma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 366);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.lblOtherDependents);
            this.Controls.Add(this.txtSpouse);
            this.Controls.Add(this.lblSpouse);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label lblSpouse;
        private System.Windows.Forms.TextBox txtSpouse;
        private System.Windows.Forms.Label lblOtherDependents;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Label lblDirections;
    }
}

