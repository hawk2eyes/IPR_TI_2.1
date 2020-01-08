namespace Doctor
{
    partial class SpecialistForm
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
            this.PatientCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WarmingUpCheck = new System.Windows.Forms.CheckBox();
            this.AstrandTestCheck = new System.Windows.Forms.CheckBox();
            this.CoolingDownCheck = new System.Windows.Forms.CheckBox();
            this.GetDataBttn = new System.Windows.Forms.Button();
            this.HistoricListView = new System.Windows.Forms.ListView();
            this.refreshBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PatientCombo
            // 
            this.PatientCombo.FormattingEnabled = true;
            this.PatientCombo.Location = new System.Drawing.Point(11, 47);
            this.PatientCombo.Name = "PatientCombo";
            this.PatientCombo.Size = new System.Drawing.Size(182, 21);
            this.PatientCombo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecteer een patient:";
            // 
            // WarmingUpCheck
            // 
            this.WarmingUpCheck.AutoSize = true;
            this.WarmingUpCheck.Location = new System.Drawing.Point(15, 85);
            this.WarmingUpCheck.Name = "WarmingUpCheck";
            this.WarmingUpCheck.Size = new System.Drawing.Size(85, 17);
            this.WarmingUpCheck.TabIndex = 2;
            this.WarmingUpCheck.Text = "Warming Up";
            this.WarmingUpCheck.UseVisualStyleBackColor = true;
            // 
            // AstrandTestCheck
            // 
            this.AstrandTestCheck.AutoSize = true;
            this.AstrandTestCheck.Location = new System.Drawing.Point(15, 108);
            this.AstrandTestCheck.Name = "AstrandTestCheck";
            this.AstrandTestCheck.Size = new System.Drawing.Size(86, 17);
            this.AstrandTestCheck.TabIndex = 3;
            this.AstrandTestCheck.Text = "Astrand Test";
            this.AstrandTestCheck.UseVisualStyleBackColor = true;
            // 
            // CoolingDownCheck
            // 
            this.CoolingDownCheck.AutoSize = true;
            this.CoolingDownCheck.Location = new System.Drawing.Point(15, 131);
            this.CoolingDownCheck.Name = "CoolingDownCheck";
            this.CoolingDownCheck.Size = new System.Drawing.Size(90, 17);
            this.CoolingDownCheck.TabIndex = 4;
            this.CoolingDownCheck.Text = "Cooling down";
            this.CoolingDownCheck.UseVisualStyleBackColor = true;
            // 
            // GetDataBttn
            // 
            this.GetDataBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDataBttn.Location = new System.Drawing.Point(11, 167);
            this.GetDataBttn.Name = "GetDataBttn";
            this.GetDataBttn.Size = new System.Drawing.Size(178, 35);
            this.GetDataBttn.TabIndex = 5;
            this.GetDataBttn.Text = "Haal historische gegevens op";
            this.GetDataBttn.UseVisualStyleBackColor = true;
            // 
            // HistoricListView
            // 
            this.HistoricListView.HideSelection = false;
            this.HistoricListView.Location = new System.Drawing.Point(396, 28);
            this.HistoricListView.Name = "HistoricListView";
            this.HistoricListView.Size = new System.Drawing.Size(236, 391);
            this.HistoricListView.TabIndex = 6;
            this.HistoricListView.UseCompatibleStateImageBehavior = false;
            // 
            // refreshBttn
            // 
            this.refreshBttn.Location = new System.Drawing.Point(172, 23);
            this.refreshBttn.Name = "refreshBttn";
            this.refreshBttn.Size = new System.Drawing.Size(20, 20);
            this.refreshBttn.TabIndex = 7;
            this.refreshBttn.UseVisualStyleBackColor = true;
            // 
            // SpecialistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 452);
            this.Controls.Add(this.refreshBttn);
            this.Controls.Add(this.HistoricListView);
            this.Controls.Add(this.GetDataBttn);
            this.Controls.Add(this.CoolingDownCheck);
            this.Controls.Add(this.AstrandTestCheck);
            this.Controls.Add(this.WarmingUpCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientCombo);
            this.Name = "SpecialistForm";
            this.Text = "Specialist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PatientCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox WarmingUpCheck;
        private System.Windows.Forms.CheckBox AstrandTestCheck;
        private System.Windows.Forms.CheckBox CoolingDownCheck;
        private System.Windows.Forms.Button GetDataBttn;
        private System.Windows.Forms.ListView HistoricListView;
        private System.Windows.Forms.Button refreshBttn;
    }
}

