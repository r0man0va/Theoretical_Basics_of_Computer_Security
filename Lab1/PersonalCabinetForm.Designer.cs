namespace Lab1
{
    partial class PersonalCabinetForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ChooseDiskLabel = new System.Windows.Forms.Label();
            this.SelectedDiskButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ChooseDiskLabel
            // 
            this.ChooseDiskLabel.AutoSize = true;
            this.ChooseDiskLabel.Location = new System.Drawing.Point(43, 81);
            this.ChooseDiskLabel.Name = "ChooseDiskLabel";
            this.ChooseDiskLabel.Size = new System.Drawing.Size(113, 20);
            this.ChooseDiskLabel.TabIndex = 1;
            this.ChooseDiskLabel.Text = "Выберите диск";
            // 
            // SelectedDiskButton
            // 
            this.SelectedDiskButton.Location = new System.Drawing.Point(481, 73);
            this.SelectedDiskButton.Name = "SelectedDiskButton";
            this.SelectedDiskButton.Size = new System.Drawing.Size(94, 29);
            this.SelectedDiskButton.TabIndex = 2;
            this.SelectedDiskButton.Text = "Выбрать";
            this.SelectedDiskButton.UseVisualStyleBackColor = true;
            this.SelectedDiskButton.Click += new System.EventHandler(this.SelectedDiskButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(192, 150);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(107, 28);
            this.ChangePasswordButton.TabIndex = 3;
            this.ChangePasswordButton.Text = "Изменить";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Location = new System.Drawing.Point(43, 150);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(133, 20);
            this.ChangePasswordLabel.TabIndex = 4;
            this.ChangePasswordLabel.Text = "Изменить пароль";
            // 
            // PersonalCabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 280);
            this.Controls.Add(this.ChangePasswordLabel);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.SelectedDiskButton);
            this.Controls.Add(this.ChooseDiskLabel);
            this.Controls.Add(this.comboBox1);
            this.Name = "PersonalCabinetForm";
            this.Text = "Личный кабинет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Label ChooseDiskLabel;
        private Button SelectedDiskButton;
        private Button ChangePasswordButton;
        private Label ChangePasswordLabel;
    }
}