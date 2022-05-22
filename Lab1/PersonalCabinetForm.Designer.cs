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
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 28);
            this.comboBox1.TabIndex = 0;
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
            this.SelectedDiskButton.Location = new System.Drawing.Point(176, 136);
            this.SelectedDiskButton.Name = "SelectedDiskButton";
            this.SelectedDiskButton.Size = new System.Drawing.Size(94, 29);
            this.SelectedDiskButton.TabIndex = 2;
            this.SelectedDiskButton.Text = "Выбрать";
            this.SelectedDiskButton.UseVisualStyleBackColor = true;
            // 
            // PersonalCabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 280);
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
    }
}