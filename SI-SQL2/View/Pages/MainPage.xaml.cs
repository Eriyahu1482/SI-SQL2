using SI_SQL2.Core;
using SI_SQL2.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace SI_SQL2.View.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    Core1.DB.Users.Add(new User()
            //    {
            //        FirstName = Name.Text,
            //        LastName = Pass.Password,
            //        }
            //        );
            //}
            //catch { }
            try
            {
                User userModel = Core1.DB.Users.FirstOrDefault(g => g.FirstName == Name.Text && g.LastName == Pass.Password);
                if (userModel != null)
                {
                    switch (userModel.UserID)
                    {
                        case 1:
                            Core1.MyCore.Navigate(new Safonov());
                            break;
                            case 2:
                            break; 
                            case 3:
                            break;
                    }                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }           
        }
        private void Visible1_Click(object sender, RoutedEventArgs e)
        {
            Hidden.Visibility = Visibility.Visible;
            Visible1.Visibility = Visibility.Hidden;

            Pass.PasswordChar = '1';
        }

        private void Hidden_Click(object sender, RoutedEventArgs e)
        {
            Hidden.Visibility = Visibility.Hidden;
            Visible1.Visibility = Visibility.Visible;

            Pass.PasswordChar = '•';
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Brd.Visibility = Visibility.Visible;
        }

        private void BtnYes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnNo_Click(object sender, RoutedEventArgs e)
        {
            Brd.Visibility = Visibility.Hidden;
        }
    }
}
