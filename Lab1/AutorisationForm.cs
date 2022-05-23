using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab1
{
    public partial class AutorisationForm : Form
    {
        public AutorisationForm()
        {
            InitializeComponent();
        }

        /// проверка пароля
        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LoginTextBox.Text)) //если строка для ввода логина пуста
            {
                MessageBox.Show("Введите логин", "Ошибка");
                return;
            }
            if (String.IsNullOrEmpty(PasswordTextBox.Text)) //если строка для ввода пароля пуста
            {
                MessageBox.Show("Введите пароль", "Ошибка");
                return;
            }

            // если строки Логин и Пароль не были пусты, то запамянаю 
            string UsersLogin = LoginTextBox.Text;
            string UsersPassword = PasswordTextBox.Text;

            if (Login(UsersLogin, UsersPassword))
            {
                this.Hide();
                PersonalCabinetForm newPersonalCabinetForm = new PersonalCabinetForm(UsersPassword, UsersLogin);
                newPersonalCabinetForm.Show();
            }
            else MessageBox.Show(String.Format("Какой-то текст про попытки"));
        }

        bool Login(string usersLogin, string usersPassword) // проверка пароля
        {
            string CurrentFile = @"LoginPasswords.txt";
            string UsersData = usersLogin + " " + usersPassword;

            using (FileStream fs = File.Open(CurrentFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                StreamWriter sw = new StreamWriter(fs);
                
                if (fs.Length == 0)
                {
                    sw.WriteLine(UsersData);
                    sw.Flush();
                    MessageBox.Show("Вы были зарегистрированыы");
                    return true;
                }
                else
                {
                    StreamReader sr = new StreamReader(fs);
                    
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Regex regex = new Regex(@"[\w]+");
                        MatchCollection matches = regex.Matches(line);
                        if (matches[0].Value == usersLogin) //если логин в журнале имеется
                        {
                            if (matches[1].Value == usersPassword)
                            {
                                MessageBox.Show("Вход выполнен");
                                return true; // логин и пароль совпали
                            }
                            else
                            {
                                MessageBox.Show("Неверный пароль");
                                return false;
                            }
                        }
                                
                    }
                }

                sw.WriteLine(UsersData);
                //sw.Flush();
                MessageBox.Show("Вы были зарегистрированыы");
                return true;
                //1. есть ли такой логин? да - совпаадет пароль? - да - верно новое окно Личный кабинет;
                //                                               -нет-окно Ошибка
                //                       -нет - добавить логи и пароль
                
            }
                
            MessageBox.Show("Неверный пароль!", "Ошибка");

            return false;
        }

        
    }
}
