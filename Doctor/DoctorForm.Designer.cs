namespace Doctor
{
    partial class DoctorForm
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
            this.btnStartTest = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbbGender = new System.Windows.Forms.ComboBox();
            this.lblWrongData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(158, 125);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(75, 23);
            this.btnStartTest.TabIndex = 0;
            this.btnStartTest.Text = "Start test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.BtnStartTest_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Naam :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 39);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(62, 17);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Leeftijd :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 67);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(72, 17);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Geslacht :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(116, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(154, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(116, 39);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(154, 22);
            this.tbAge.TabIndex = 5;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(116, 97);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(154, 22);
            this.tbWeight.TabIndex = 7;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 97);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(66, 17);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Gewicht :";
            // 
            // cmbbGender
            // 
            this.cmbbGender.FormattingEnabled = true;
            this.cmbbGender.Items.AddRange(new object[] {
            "Man",
            "Vrouw",
            "Anders"});
            this.cmbbGender.Location = new System.Drawing.Point(116, 67);
            this.cmbbGender.Name = "cmbbGender";
            this.cmbbGender.Size = new System.Drawing.Size(154, 24);
            this.cmbbGender.TabIndex = 9;
            // 
            // lblWrongData
            // 
            this.lblWrongData.AutoSize = true;
            this.lblWrongData.ForeColor = System.Drawing.Color.Red;
            this.lblWrongData.Location = new System.Drawing.Point(16, 164);
            this.lblWrongData.Name = "lblWrongData";
            this.lblWrongData.Size = new System.Drawing.Size(254, 17);
            this.lblWrongData.TabIndex = 10;
            this.lblWrongData.Text = "Sommige gevens zijn verkeerd ingevult";
            this.lblWrongData.Visible = false;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 203);
            this.Controls.Add(this.lblWrongData);
            this.Controls.Add(this.cmbbGender);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnStartTest);
            this.Name = "DoctorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbbGender;
        private System.Windows.Forms.Label lblWrongData;
    }
}