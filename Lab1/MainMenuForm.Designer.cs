namespace Lab1
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AutorisationButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AutorisationButton
            // 
            this.AutorisationButton.Location = new System.Drawing.Point(153, 35);
            this.AutorisationButton.Name = "AutorisationButton";
            this.AutorisationButton.Size = new System.Drawing.Size(158, 45);
            this.AutorisationButton.TabIndex = 0;
            this.AutorisationButton.Text = "Авторизация";
            this.AutorisationButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(153, 96);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(158, 46);
            this.AboutButton.TabIndex = 1;
            this.AboutButton.Text = "О программе";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 203);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.AutorisationButton);
            this.Name = "MainMenuForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private Button AutorisationButton;
        private Button AboutButton;

  
    }
}