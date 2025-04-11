using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HerbalMedicinesProject.Data;

namespace HerbalMedicinesProject
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnClosRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HerbalDB herbalDB = new HerbalDB();
            Person person = new Person();

            ///مقدار دهی پارمتر هایی که کاربر وارو می کند
              person.FirstName = txtFirstName.Text.ToString();
              person.LastName = txtLastName.Text.ToString();
              person.Id = txtNationalCode.Text.ToString();
              person.Gender = cmbGender.SelectedValue?.ToString();
              person.Role = cmbRole.SelectedValue?.ToString();
              person.PhoneNumber = txtPhoneNumber.Text.ToString();
              person.Email = txtEmail.Text.ToString();
              person.BirthDate = dpBirthDate.SelectedDate.Value;
              person.PasswordHash = txtPassword.Password.ToString();
              person.Address = txtaddress.Text.ToString();
              person.Salt = "salam";/// در هش کردن باشد تغییر بدیم




            if (herbalDB.AddPerson(person))
            {
                MessageBox.Show("✅ Registration was successful !", "Registration ",MessageBoxButton.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration was unsuccessful !", "Registration ", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();
            }
        }

    }
}
