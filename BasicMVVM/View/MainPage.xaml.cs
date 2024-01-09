using BasicMVVM.ViewModel;
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

namespace BasicMVVM.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new UserViewModel();
            Menu mainMenu = (Menu)FindResource("MainMenu");

        }
        private void Exit_Clicked(object sender, RoutedEventArgs e)
        {
            // Global exit logic here
            Close();
        }



        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        
            Close();
        }

    }
}
