namespace PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Password = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reliability = new System.Windows.Forms.Label();
            this.buttonSetting = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Label();
            this.Setting = new System.Windows.Forms.Panel();
            this.hystory = new System.Windows.Forms.Panel();
            this.ClearHistory = new System.Windows.Forms.Button();
            this.ListOfHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.privateSymbol = new System.Windows.Forms.TextBox();
            this.checkBoxPrivateSymbol = new System.Windows.Forms.CheckBox();
            this.checkBox09 = new System.Windows.Forms.CheckBox();
            this.checkBoxsmallAZ = new System.Windows.Forms.CheckBox();
            this.checkBoxAZ = new System.Windows.Forms.CheckBox();
            this.lenght = new System.Windows.Forms.ComboBox();
            this.LenghtPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Setting.SuspendLayout();
            this.hystory.SuspendLayout();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI Variable Display", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password.Location = new System.Drawing.Point(27, 36);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(354, 49);
            this.Password.TabIndex = 0;
            this.Password.Text = "AA7`=1p`k$\".Qo>K";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.BackgroundImage = global::PasswordGenerator.Properties.Resources.refresh;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Location = new System.Drawing.Point(490, 36);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(46, 49);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Transparent;
            this.buttonCopy.BackgroundImage = global::PasswordGenerator.Properties.Resources.Copy;
            this.buttonCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopy.FlatAppearance.BorderSize = 0;
            this.buttonCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.Location = new System.Drawing.Point(425, 36);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(46, 49);
            this.buttonCopy.TabIndex = 1;
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Надежность пароля:";
            // 
            // reliability
            // 
            this.reliability.AutoSize = true;
            this.reliability.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reliability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.reliability.Location = new System.Drawing.Point(233, 101);
            this.reliability.Name = "reliability";
            this.reliability.Size = new System.Drawing.Size(111, 27);
            this.reliability.TabIndex = 4;
            this.reliability.Text = "надежный";
            // 
            // buttonSetting
            // 
            this.buttonSetting.AutoSize = true;
            this.buttonSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetting.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSetting.Location = new System.Drawing.Point(29, 164);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(171, 40);
            this.buttonSetting.TabIndex = 5;
            this.buttonSetting.Text = "Настройки";
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // historyButton
            // 
            this.historyButton.AutoSize = true;
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historyButton.Location = new System.Drawing.Point(252, 164);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(265, 40);
            this.historyButton.TabIndex = 6;
            this.historyButton.Text = "История паролей";
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.Transparent;
            this.Setting.Controls.Add(this.hystory);
            this.Setting.Controls.Add(this.privateSymbol);
            this.Setting.Controls.Add(this.checkBoxPrivateSymbol);
            this.Setting.Controls.Add(this.checkBox09);
            this.Setting.Controls.Add(this.checkBoxsmallAZ);
            this.Setting.Controls.Add(this.checkBoxAZ);
            this.Setting.Controls.Add(this.lenght);
            this.Setting.Controls.Add(this.LenghtPassword);
            this.Setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Setting.Location = new System.Drawing.Point(0, 223);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(567, 224);
            this.Setting.TabIndex = 7;
            // 
            // hystory
            // 
            this.hystory.Controls.Add(this.ClearHistory);
            this.hystory.Controls.Add(this.ListOfHistory);
            this.hystory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hystory.Location = new System.Drawing.Point(0, 0);
            this.hystory.Name = "hystory";
            this.hystory.Size = new System.Drawing.Size(567, 224);
            this.hystory.TabIndex = 16;
            // 
            // ClearHistory
            // 
            this.ClearHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearHistory.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearHistory.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClearHistory.Location = new System.Drawing.Point(-5, 180);
            this.ClearHistory.Name = "ClearHistory";
            this.ClearHistory.Size = new System.Drawing.Size(581, 51);
            this.ClearHistory.TabIndex = 1;
            this.ClearHistory.Text = "Очистить историю              ";
            this.ClearHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearHistory.UseVisualStyleBackColor = true;
            this.ClearHistory.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // ListOfHistory
            // 
            this.ListOfHistory.AutoScroll = true;
            this.ListOfHistory.Location = new System.Drawing.Point(-5, 4);
            this.ListOfHistory.Name = "ListOfHistory";
            this.ListOfHistory.Size = new System.Drawing.Size(581, 177);
            this.ListOfHistory.TabIndex = 0;
            // 
            // privateSymbol
            // 
            this.privateSymbol.BackColor = System.Drawing.SystemColors.InfoText;
            this.privateSymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.privateSymbol.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateSymbol.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.privateSymbol.Location = new System.Drawing.Point(76, 153);
            this.privateSymbol.Multiline = true;
            this.privateSymbol.Name = "privateSymbol";
            this.privateSymbol.Size = new System.Drawing.Size(367, 39);
            this.privateSymbol.TabIndex = 15;
            // 
            // checkBoxPrivateSymbol
            // 
            this.checkBoxPrivateSymbol.AutoSize = true;
            this.checkBoxPrivateSymbol.Checked = true;
            this.checkBoxPrivateSymbol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrivateSymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxPrivateSymbol.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPrivateSymbol.Location = new System.Drawing.Point(36, 164);
            this.checkBoxPrivateSymbol.Name = "checkBoxPrivateSymbol";
            this.checkBoxPrivateSymbol.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPrivateSymbol.TabIndex = 14;
            this.checkBoxPrivateSymbol.UseVisualStyleBackColor = true;
            // 
            // checkBox09
            // 
            this.checkBox09.AutoSize = true;
            this.checkBox09.Checked = true;
            this.checkBox09.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox09.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox09.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox09.Location = new System.Drawing.Point(278, 88);
            this.checkBox09.Name = "checkBox09";
            this.checkBox09.Size = new System.Drawing.Size(82, 41);
            this.checkBox09.TabIndex = 13;
            this.checkBox09.Text = "0-9";
            this.checkBox09.UseVisualStyleBackColor = true;
            // 
            // checkBoxsmallAZ
            // 
            this.checkBoxsmallAZ.AutoSize = true;
            this.checkBoxsmallAZ.Checked = true;
            this.checkBoxsmallAZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxsmallAZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxsmallAZ.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxsmallAZ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxsmallAZ.Location = new System.Drawing.Point(161, 88);
            this.checkBoxsmallAZ.Name = "checkBoxsmallAZ";
            this.checkBoxsmallAZ.Size = new System.Drawing.Size(76, 41);
            this.checkBoxsmallAZ.TabIndex = 12;
            this.checkBoxsmallAZ.Text = "a-z";
            this.checkBoxsmallAZ.UseVisualStyleBackColor = true;
            // 
            // checkBoxAZ
            // 
            this.checkBoxAZ.AutoSize = true;
            this.checkBoxAZ.Checked = true;
            this.checkBoxAZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAZ.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAZ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxAZ.Location = new System.Drawing.Point(36, 88);
            this.checkBoxAZ.Name = "checkBoxAZ";
            this.checkBoxAZ.Size = new System.Drawing.Size(85, 41);
            this.checkBoxAZ.TabIndex = 11;
            this.checkBoxAZ.Text = "A-Z";
            this.checkBoxAZ.UseVisualStyleBackColor = true;
            // 
            // lenght
            // 
            this.lenght.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lenght.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lenght.FormattingEnabled = true;
            this.lenght.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.lenght.Location = new System.Drawing.Point(161, 28);
            this.lenght.Name = "lenght";
            this.lenght.Size = new System.Drawing.Size(65, 24);
            this.lenght.TabIndex = 9;
            // 
            // LenghtPassword
            // 
            this.LenghtPassword.AutoSize = true;
            this.LenghtPassword.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LenghtPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LenghtPassword.Location = new System.Drawing.Point(32, 28);
            this.LenghtPassword.Name = "LenghtPassword";
            this.LenghtPassword.Size = new System.Drawing.Size(127, 22);
            this.LenghtPassword.TabIndex = 8;
            this.LenghtPassword.Text = "Длина пароля:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 5);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.reliability);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Генератор паролей";
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.hystory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label reliability;
        private System.Windows.Forms.Label buttonSetting;
        private System.Windows.Forms.Label historyButton;
        private System.Windows.Forms.Panel Setting;
        private System.Windows.Forms.TextBox privateSymbol;
        private System.Windows.Forms.CheckBox checkBoxPrivateSymbol;
        private System.Windows.Forms.CheckBox checkBox09;
        private System.Windows.Forms.CheckBox checkBoxsmallAZ;
        private System.Windows.Forms.CheckBox checkBoxAZ;
        private System.Windows.Forms.ComboBox lenght;
        private System.Windows.Forms.Label LenghtPassword;
        private System.Windows.Forms.Panel hystory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearHistory;
        private System.Windows.Forms.FlowLayoutPanel ListOfHistory;
    }
}

