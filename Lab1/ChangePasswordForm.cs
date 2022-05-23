using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ChangePasswordForm : Form
    {
        private string Login, Password;
        public ChangePasswordForm(string Login, string Password)
        {
            InitializeComponent();
            this.Password = Password;
            this.Login = Login;
        }
    }
}
