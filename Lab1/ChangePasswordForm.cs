using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Lab1
{
    public partial class ChangePasswordForm : Form
    {
        private string Login, Password;

        private void ConfirmChangingButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NewPasswordTextBox.Text)) // если строка Новый пароль пуста
            {
                MessageBox.Show("Вы не ввели новый пароль", "Ошибка");
            }
            if (String.IsNullOrEmpty(OldPasswordTextBox.Text)) // если строка Старый пароль пуста
            {
                MessageBox.Show("Вы не ввели текущий\\старый пароль", "Ошибка"); 
            }
            if (OldPasswordTextBox.Text != Password && !String.IsNullOrEmpty(OldPasswordTextBox.Text)) // если введеный текущий\старый пароль не совпадает с текущим\старым из txt
            {
                MessageBox.Show("Вы ввели не верный текущий\\старый пароль", "Ошибка");
            }
            if (NewPasswordTextBox.Text == Password) // если в строку Новый пароль введен апроль, что уже использ
            {
                MessageBox.Show("Введеный новый пароль уже используется", "Ошибка");
            }
            if (OldPasswordTextBox.Text == Password) // если можно сменить пароль
            {
                ChangePassword(Login, NewPasswordTextBox.Text, OldPasswordTextBox.Text);
                MessageBox.Show("Пароль был изменен","Внимание");
                this.Hide();
            }
        }

        private void ChangePassword(string userLogin, string newPassword, string oldPassword) 
        {
            string currentFile = @"LoginPasswords.txt";
            string userData = userLogin + " " + oldPassword;
            string newUserData = userLogin + " " + newPassword;

            
            StreamReader sr = new StreamReader(currentFile);

            string content = sr.ReadToEnd();
            sr.Close();

            content = Regex.Replace(content, userData, newUserData);

            StreamWriter sw = new StreamWriter(currentFile);
            sw.Write(content);
            sw.Close(); 
            
        }

        public ChangePasswordForm(string Login, string Password)
        {
            InitializeComponent();
            this.Password = Password;
            this.Login = Login;
        }
        //строка Новый пароль пуста - сообщ об ошибке
        // строка Старый пароль пуста - сообщ об ошибке - учет кол-ва попыток
        //старый пароль введен верно? - да - сменить старый на новый
        //                          - нет - минус попытка - сообщ предупрждение
        //                                  попытки закончи? - нет - сообщ предупреждение - минус попытка
        //                                                   - да - сообщ о запрете смены пароля - закрыть окно смены пароля

    }
}
