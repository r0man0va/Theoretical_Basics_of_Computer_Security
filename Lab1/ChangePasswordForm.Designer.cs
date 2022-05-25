namespace Lab1
{
    partial class ChangePasswordForm
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
            this.EnterSignLabel = new System.Windows.Forms.Label();
            this.EnterNewPasswordLabel = new System.Windows.Forms.Label();
            this.EnterOldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.OldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmChangingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterSignLabel
            // 
            this.EnterSignLabel.AutoSize = true;
            this.EnterSignLabel.Location = new System.Drawing.Point(241, 62);
            this.EnterSignLabel.Name = "EnterSignLabel";
            this.EnterSignLabel.Size = new System.Drawing.Size(68, 20);
            this.EnterSignLabel.TabIndex = 0;
            this.EnterSignLabel.Text = "Введите:";
            // 
            // EnterNewPasswordLabel
            // 
            this.EnterNewPasswordLabel.AutoSize = true;
            this.EnterNewPasswordLabel.Location = new System.Drawing.Point(76, 120);
            this.EnterNewPasswordLabel.Name = "EnterNewPasswordLabel";
            this.EnterNewPasswordLabel.Size = new System.Drawing.Size(112, 20);
            this.EnterNewPasswordLabel.TabIndex = 1;
            this.EnterNewPasswordLabel.Text = "Новый пароль";
            // 
            // EnterOldPasswordLabel
            // 
            this.EnterOldPasswordLabel.AutoSize = true;
            this.EnterOldPasswordLabel.Location = new System.Drawing.Point(72, 182);
            this.EnterOldPasswordLabel.Name = "EnterOldPasswordLabel";
            this.EnterOldPasswordLabel.Size = new System.Drawing.Size(116, 20);
            this.EnterOldPasswordLabel.TabIndex = 2;
            this.EnterOldPasswordLabel.Text = "Старый пароль";
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(220, 125);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(125, 27);
            this.NewPasswordTextBox.TabIndex = 3;
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.Location = new System.Drawing.Point(220, 182);
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.Size = new System.Drawing.Size(125, 27);
            this.OldPasswordTextBox.TabIndex = 4;
            // 
            // ConfirmChangingButton
            // 
            this.ConfirmChangingButton.Location = new System.Drawing.Point(220, 249);
            this.ConfirmChangingButton.Name = "ConfirmChangingButton";
            this.ConfirmChangingButton.Size = new System.Drawing.Size(94, 29);
            this.ConfirmChangingButton.TabIndex = 5;
            this.ConfirmChangingButton.Text = "Изменить";
            this.ConfirmChangingButton.UseVisualStyleBackColor = true;
            this.ConfirmChangingButton.Click += new System.EventHandler(this.ConfirmChangingButton_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 355);
            this.Controls.Add(this.ConfirmChangingButton);
            this.Controls.Add(this.OldPasswordTextBox);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.EnterOldPasswordLabel);
            this.Controls.Add(this.EnterNewPasswordLabel);
            this.Controls.Add(this.EnterSignLabel);
            this.Name = "ChangePasswordForm";
            this.Text = "Изменение пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EnterSignLabel;
        private Label EnterNewPasswordLabel;
        private Label EnterOldPasswordLabel;
        private TextBox NewPasswordTextBox;
        private TextBox OldPasswordTextBox;
        private Button ConfirmChangingButton;
    }
}