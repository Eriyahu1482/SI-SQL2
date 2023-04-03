using SI_SQL2.Core;
using SI_SQL2.Model;
using SI_SQL2.View.Pages;
using System.Windows;

namespace SI_SQL2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Core1.DB = new Entities();

            Core1.MyCore = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}
