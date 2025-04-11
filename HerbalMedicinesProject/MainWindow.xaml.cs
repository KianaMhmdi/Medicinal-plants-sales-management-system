using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HerbalMedicinesProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Username : Your national ID number\nPassword : The password you set during registration","Login Help",MessageBoxButton.OK,MessageBoxImage.Information);

        }

        private void btnCreatAcount_Click(object sender, RoutedEventArgs e)
        {
          var registerWindow=new RegisterWindow();
            registerWindow.ShowDialog();//غیر فعال کردن صفحه قبل


        }
    }
}