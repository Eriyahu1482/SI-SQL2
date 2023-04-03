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

namespace SI_SQL2.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Safonov.xaml
    /// </summary>
    public partial class Safonov : Page
    {
        public Safonov()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataUserInfo.ItemsSource = Core1.DB.Users.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new MainPage());
        }
    }
}
