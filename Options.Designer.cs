namespace GreyDwarfLauncher.Resources
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.adminToolsCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReinstallButton = new System.Windows.Forms.Button();
            this.StartParamsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.check1.Location = new System.Drawing.Point(12, 47);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(79, 17);
            this.check1.TabIndex = 0;
            this.check1.Text = "Отключено";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.check2.Location = new System.Drawing.Point(12, 70);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(79, 17);
            this.check2.TabIndex = 1;
            this.check2.Text = "Отключено";
            this.check2.UseVisualStyleBackColor = true;
            // 
            // adminToolsCheckBox
            // 
            this.adminToolsCheckBox.AutoSize = true;
            this.adminToolsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminToolsCheckBox.ForeColor = System.Drawing.Color.Red;
            this.adminToolsCheckBox.Location = new System.Drawing.Point(12, 93);
            this.adminToolsCheckBox.Name = "adminToolsCheckBox";
            this.adminToolsCheckBox.Size = new System.Drawing.Size(77, 17);
            this.adminToolsCheckBox.TabIndex = 2;
            this.adminToolsCheckBox.Text = "DevMode *";
            this.adminToolsCheckBox.UseVisualStyleBackColor = true;
            this.adminToolsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Опции и параметры";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Location = new System.Drawing.Point(177, 182);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(101, 34);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Применить";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ReinstallButton
            // 
            this.ReinstallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(60)))), ((int)(((byte)(18)))));
            this.ReinstallButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ReinstallButton.FlatAppearance.BorderSize = 0;
            this.ReinstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReinstallButton.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.ReinstallButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReinstallButton.Location = new System.Drawing.Point(12, 182);
            this.ReinstallButton.Name = "ReinstallButton";
            this.ReinstallButton.Size = new System.Drawing.Size(159, 34);
            this.ReinstallButton.TabIndex = 5;
            this.ReinstallButton.Text = "Переустановить";
            this.ReinstallButton.UseVisualStyleBackColor = false;
            this.ReinstallButton.Click += new System.EventHandler(this.ReinstallButton_Click);
            // 
            // StartParamsComboBox
            // 
            this.StartParamsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.StartParamsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartParamsComboBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartParamsComboBox.FormattingEnabled = true;
            this.StartParamsComboBox.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.StartParamsComboBox.Location = new System.Drawing.Point(157, 89);
            this.StartParamsComboBox.Name = "StartParamsComboBox";
            this.StartParamsComboBox.Size = new System.Drawing.Size(121, 21);
            this.StartParamsComboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(157, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во CPU:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "* - После активации этого парамета вы \r\n не сможете подключиться, но сможете\r\n иг" +
    "рать локально";
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.check3.Location = new System.Drawing.Point(157, 47);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(79, 17);
            this.check3.TabIndex = 9;
            this.check3.Text = "Отключено";
            this.check3.UseVisualStyleBackColor = true;
            this.check3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CancelButton = this.ReinstallButton;
            this.ClientSize = new System.Drawing.Size(292, 228);
            this.ControlBox = false;
            this.Controls.Add(this.check3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartParamsComboBox);
            this.Controls.Add(this.ReinstallButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminToolsCheckBox);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(250, 0);
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox adminToolsCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ReinstallButton;
        private System.Windows.Forms.ComboBox StartParamsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox check3;
    }
}