namespace Client
{
    partial class ClientLogin
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
            this.MaleBttn = new System.Windows.Forms.Button();
            this.FemaleBttn = new System.Windows.Forms.Button();
            this.AgeBar = new System.Windows.Forms.TrackBar();
            this.WeightBar = new System.Windows.Forms.TrackBar();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBttn = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MaleBttn
            // 
            this.MaleBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.MaleBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaleBttn.Location = new System.Drawing.Point(295, 112);
            this.MaleBttn.Name = "MaleBttn";
            this.MaleBttn.Size = new System.Drawing.Size(95, 36);
            this.MaleBttn.TabIndex = 0;
            this.MaleBttn.Text = "Man";
            this.MaleBttn.UseVisualStyleBackColor = false;
            this.MaleBttn.Click += new System.EventHandler(this.MaleBttn_Click);
            // 
            // FemaleBttn
            // 
            this.FemaleBttn.BackColor = System.Drawing.Color.AliceBlue;
            this.FemaleBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FemaleBttn.Location = new System.Drawing.Point(424, 112);
            this.FemaleBttn.Name = "FemaleBttn";
            this.FemaleBttn.Size = new System.Drawing.Size(95, 36);
            this.FemaleBttn.TabIndex = 1;
            this.FemaleBttn.Text = "Vrouw";
            this.FemaleBttn.UseVisualStyleBackColor = false;
            this.FemaleBttn.Click += new System.EventHandler(this.FemaleBttn_Click);
            // 
            // AgeBar
            // 
            this.AgeBar.BackColor = System.Drawing.Color.AliceBlue;
            this.AgeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgeBar.Location = new System.Drawing.Point(198, 178);
            this.AgeBar.Maximum = 65;
            this.AgeBar.Minimum = 15;
            this.AgeBar.Name = "AgeBar";
            this.AgeBar.Size = new System.Drawing.Size(410, 45);
            this.AgeBar.TabIndex = 4;
            this.AgeBar.Value = 15;
            this.AgeBar.Scroll += new System.EventHandler(this.AgeBar_Scroll);
            // 
            // WeightBar
            // 
            this.WeightBar.BackColor = System.Drawing.Color.AliceBlue;
            this.WeightBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WeightBar.Location = new System.Drawing.Point(198, 259);
            this.WeightBar.Maximum = 130;
            this.WeightBar.Minimum = 45;
            this.WeightBar.Name = "WeightBar";
            this.WeightBar.Size = new System.Drawing.Size(410, 45);
            this.WeightBar.TabIndex = 5;
            this.WeightBar.Value = 45;
            this.WeightBar.Scroll += new System.EventHandler(this.WeightBar_Scroll);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(624, 178);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(36, 25);
            this.AgeLabel.TabIndex = 6;
            this.AgeLabel.Text = "15";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(624, 259);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(36, 25);
            this.WeightLabel.TabIndex = 7;
            this.WeightLabel.Text = "45";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "jaar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(666, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "kg";
            // 
            // LoginBttn
            // 
            this.LoginBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBttn.Location = new System.Drawing.Point(329, 345);
            this.LoginBttn.Name = "LoginBttn";
            this.LoginBttn.Size = new System.Drawing.Size(148, 49);
            this.LoginBttn.TabIndex = 11;
            this.LoginBttn.Text = "Start";
            this.LoginBttn.UseVisualStyleBackColor = true;
            this.LoginBttn.Click += new System.EventHandler(this.LoginBttn_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.NameTextBox.Location = new System.Drawing.Point(295, 64);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(224, 22);
            this.NameTextBox.TabIndex = 12;
            this.NameTextBox.Text = "Naam";
            this.NameTextBox.Enter += new System.EventHandler(this.NameTextBox_Enter);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(258, 307);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(314, 20);
            this.ErrorMessageLabel.TabIndex = 13;
            this.ErrorMessageLabel.Text = "Voer uw gegevens in voordat u verder gaat.";
            this.ErrorMessageLabel.Visible = false;
            // 
            // ClientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.LoginBttn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.WeightBar);
            this.Controls.Add(this.AgeBar);
            this.Controls.Add(this.FemaleBttn);
            this.Controls.Add(this.MaleBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ClientLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.AgeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MaleBttn;
        private System.Windows.Forms.Button FemaleBttn;
        private System.Windows.Forms.TrackBar AgeBar;
        private System.Windows.Forms.TrackBar WeightBar;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginBttn;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}

