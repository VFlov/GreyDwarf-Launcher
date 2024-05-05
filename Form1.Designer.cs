namespace GreyDwarfLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button3 = new System.Windows.Forms.Button();
            this.ModOff = new System.Windows.Forms.Label();
            this.ModOn = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.optionswindow = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transparentLabel2 = new WinFormsControls.TransparentLabel();
            this.transparentLabel1 = new WinFormsControls.TransparentLabel();
            this.button1 = new WinFormsControls.TransparentLabel();
            this.label1 = new WinFormsControls.TransparentLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(549, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 36);
            this.button3.TabIndex = 23;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ModOff
            // 
            this.ModOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModOff.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.ModOff.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ModOff.Image = global::GreyDwarfLauncher.Properties.Resources.orange_control_28;
            this.ModOff.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ModOff.Location = new System.Drawing.Point(80, 5);
            this.ModOff.Name = "ModOff";
            this.ModOff.Size = new System.Drawing.Size(68, 25);
            this.ModOff.TabIndex = 21;
            this.ModOff.Text = " ModsOff";
            this.ModOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModOff.Click += new System.EventHandler(this.ModOff_Click);
            // 
            // ModOn
            // 
            this.ModOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModOn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.ModOn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ModOn.Image = global::GreyDwarfLauncher.Properties.Resources.green_control_22;
            this.ModOn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ModOn.Location = new System.Drawing.Point(9, 5);
            this.ModOn.Name = "ModOn";
            this.ModOn.Size = new System.Drawing.Size(68, 25);
            this.ModOn.TabIndex = 20;
            this.ModOn.Text = "ModsOn ";
            this.ModOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModOn.Click += new System.EventHandler(this.ModOn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::GreyDwarfLauncher.Properties.Resources.discord_small_white1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(680, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Discord";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Firebrick;
            this.exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.White;
            this.exitbutton.Image = global::GreyDwarfLauncher.Properties.Resources.exit_small_white;
            this.exitbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitbutton.Location = new System.Drawing.Point(778, 0);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitbutton.Size = new System.Drawing.Size(90, 36);
            this.exitbutton.TabIndex = 15;
            this.exitbutton.Text = "Выйти";
            this.exitbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // optionswindow
            // 
            this.optionswindow.BackColor = System.Drawing.Color.OrangeRed;
            this.optionswindow.FlatAppearance.BorderSize = 0;
            this.optionswindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionswindow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.optionswindow.ForeColor = System.Drawing.Color.White;
            this.optionswindow.Image = global::GreyDwarfLauncher.Properties.Resources.options_small_white;
            this.optionswindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionswindow.Location = new System.Drawing.Point(589, 0);
            this.optionswindow.Name = "optionswindow";
            this.optionswindow.Size = new System.Drawing.Size(91, 36);
            this.optionswindow.TabIndex = 14;
            this.optionswindow.Text = "Опции";
            this.optionswindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optionswindow.UseVisualStyleBackColor = false;
            this.optionswindow.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(0, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 77);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(868, 489);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // transparentLabel2
            // 
            this.transparentLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transparentLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.transparentLabel2.Location = new System.Drawing.Point(495, 467);
            this.transparentLabel2.Name = "transparentLabel2";
            this.transparentLabel2.Size = new System.Drawing.Size(131, 32);
            this.transparentLabel2.TabIndex = 22;
            this.transparentLabel2.TabStop = false;
            this.transparentLabel2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transparentLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.transparentLabel1.Location = new System.Drawing.Point(12, 467);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(232, 32);
            this.transparentLabel1.TabIndex = 7;
            this.transparentLabel1.TabStop = false;
            this.transparentLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.transparentLabel1.Click += new System.EventHandler(this.transparentLabel1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(587, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 72);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "TEXT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(201, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 4;
            this.label1.TabStop = false;
            this.label1.Text = "TEXT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(868, 525);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.transparentLabel2);
            this.Controls.Add(this.ModOff);
            this.Controls.Add(this.ModOn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.optionswindow);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GreyDwarf Launcher v.0.1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private WinFormsControls.TransparentLabel label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private WinFormsControls.TransparentLabel transparentLabel1;
        private System.Windows.Forms.Button optionswindow;
        private System.Windows.Forms.Button exitbutton;
        private WinFormsControls.TransparentLabel button1;
        private System.Windows.Forms.Label ModOn;
        private System.Windows.Forms.Label ModOff;
        private WinFormsControls.TransparentLabel transparentLabel2;
        private System.Windows.Forms.Button button3;
    }
}

