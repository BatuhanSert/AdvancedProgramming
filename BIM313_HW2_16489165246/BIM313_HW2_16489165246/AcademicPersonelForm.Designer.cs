namespace BIM313_HW2_16489165246
{
    partial class AcademicPersonelForm
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
            this.txt_AIC = new System.Windows.Forms.TextBox();
            this.btn_CalculateSalary = new System.Windows.Forms.Button();
            this.lbl_PersonalType = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Academic Incentive Coefficient:";
            // 
            // txt_AIC
            // 
            this.txt_AIC.BackColor = System.Drawing.Color.Silver;
            this.txt_AIC.Location = new System.Drawing.Point(357, 27);
            this.txt_AIC.Name = "txt_AIC";
            this.txt_AIC.Size = new System.Drawing.Size(194, 22);
            this.txt_AIC.TabIndex = 1;
            this.txt_AIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_CalculateSalary
            // 
            this.btn_CalculateSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_CalculateSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CalculateSalary.Location = new System.Drawing.Point(357, 74);
            this.btn_CalculateSalary.Name = "btn_CalculateSalary";
            this.btn_CalculateSalary.Size = new System.Drawing.Size(194, 38);
            this.btn_CalculateSalary.TabIndex = 2;
            this.btn_CalculateSalary.Text = "Calculate Salary";
            this.btn_CalculateSalary.UseVisualStyleBackColor = false;
            this.btn_CalculateSalary.Click += new System.EventHandler(this.btn_CalculateSalary_Click);
            // 
            // lbl_PersonalType
            // 
            this.lbl_PersonalType.AccessibleName = "lbl_PersonelType";
            this.lbl_PersonalType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PersonalType.AutoSize = true;
            this.lbl_PersonalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_PersonalType.Location = new System.Drawing.Point(357, 137);
            this.lbl_PersonalType.Name = "lbl_PersonalType";
            this.lbl_PersonalType.Size = new System.Drawing.Size(0, 20);
            this.lbl_PersonalType.TabIndex = 3;
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AccessibleName = "lbl_PersonelType";
            this.lbl_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Salary.Location = new System.Drawing.Point(357, 182);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(0, 20);
            this.lbl_Salary.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(153, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Personel Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(220, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salary:";
            // 
            // AcademicPersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(567, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_PersonalType);
            this.Controls.Add(this.btn_CalculateSalary);
            this.Controls.Add(this.txt_AIC);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "AcademicPersonelForm";
            this.Text = "AcademicPersonelForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AcademicPersonelForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_AIC;
        public System.Windows.Forms.Button btn_CalculateSalary;
        public System.Windows.Forms.Label lbl_PersonalType;
        public System.Windows.Forms.Label lbl_Salary;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
    }
}