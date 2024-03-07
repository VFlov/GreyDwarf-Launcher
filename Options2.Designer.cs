namespace GreyDwarfLauncher
{
    partial class Options2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options2));
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Explorer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.GamePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите папку игры";
            // 
            // Explorer
            // 
            this.Explorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Explorer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Explorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Explorer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Explorer.ForeColor = System.Drawing.SystemColors.Window;
            this.Explorer.Location = new System.Drawing.Point(393, 66);
            this.Explorer.Name = "Explorer";
            this.Explorer.Size = new System.Drawing.Size(75, 23);
            this.Explorer.TabIndex = 6;
            this.Explorer.Text = "Обзор";
            this.Explorer.UseVisualStyleBackColor = false;
            this.Explorer.Click += new System.EventHandler(this.Explorer_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 124);
            this.label3.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Location = new System.Drawing.Point(0, 226);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(480, 43);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Применить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // GamePath
            // 
            this.GamePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GamePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.GamePath.ForeColor = System.Drawing.SystemColors.Window;
            this.GamePath.Location = new System.Drawing.Point(17, 66);
            this.GamePath.Name = "GamePath";
            this.GamePath.Size = new System.Drawing.Size(357, 22);
            this.GamePath.TabIndex = 8;
            this.GamePath.Text = "...\\Valheim\\valheim.exe";
            this.GamePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Options2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(480, 270);
            this.ControlBox = false;
            this.Controls.Add(this.GamePath);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Explorer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(250, 0);
            this.Name = "Options2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Explorer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label GamePath;
    }
}