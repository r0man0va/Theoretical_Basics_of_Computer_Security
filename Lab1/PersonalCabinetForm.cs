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
using System.Diagnostics;
using System.IO;


namespace Lab1
{
    public partial class PersonalCabinetForm : Form
    {
        private string Password, Login;
        public PersonalCabinetForm(string Password, string Login)
        {
            InitializeComponent();
            this.Password = Password;
            this.Login = Login;
            //MessageBox.Show(this.Password, this.Login);

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                comboBox1.Items.Add(d.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedState = comboBox1.SelectedItem.ToString();
            //MessageBox.Show(selectedState);
        }

        private void SelectedDiskButton_Click(object sender, EventArgs e)
        {
            string? selectedDrive = comboBox1.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(selectedDrive)) // если диск выбран и диски есть
            {
                if (UserAccessed(this.Login, selectedDrive)) // проверка, доступен ли пользователю выбранный им диск
                {
                    MessageBox.Show("У вас есть доступ к диску");
                    OpenDirectory(selectedDrive);
                }
                else
                {
                    MessageBox.Show("У вас нет доступа к диску");
                }
            }
            else 
            {
                MessageBox.Show("Диск не выбран");
            }
            
        }

        bool UserAccessed(string usersLogin, string selectedDrive) 
        {
            string accessRightsFile = @"UsersAccessRights.txt";

            using (FileStream fs = File.Open(accessRightsFile, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                StreamReader sr = new StreamReader(fs);
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    Regex regex = new Regex(@"[\w]+");
                    MatchCollection matches = regex.Matches(line);
                    if (matches[0].Value == usersLogin) //если логин в журнале имеется
                    {
                        for (int i = 1; i < matches.Count; i++)
                        {
                            if ((matches[i].Value + ":\\") == selectedDrive.ToLower())
                            {
                                //MessageBox.Show("Доступ есть");
                                return true;
                            }
                            else
                            {
                                //MessageBox.Show("Нет доступа");
                                return false;
                            }
                        }
                        //if (matches[1].Value == usersPassword)
                        //{
                        //    MessageBox.Show("Вход выполнен");
                        //    return true; // логин и пароль совпали
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Неверный пароль");
                        //    return false;
                        //}
                    }
                    //MessageBox.Show("Доступа нет 2");
                    return false;

                }
                return false;
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(Login, Password);
            changePasswordForm.Show();
        }

        void OpenDirectory(string directoryPath) 
        {
            if (Directory.Exists(directoryPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = directoryPath,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
            else 
            {
                MessageBox.Show(String.Format("{0} Директории не существует", directoryPath));
            }
        }
    }
}
