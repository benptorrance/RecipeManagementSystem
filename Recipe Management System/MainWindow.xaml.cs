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

namespace Recipie_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int success;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void loginClick(object sender, RoutedEventArgs e)
        {
            Window1 login = new Window1();
            success = 0;
            if (success == 1) {
                this.Hide();
                login.ShowDialog();
                this.Show();
            }
            if (success > 1)
            {

            }
            if (success < 1)
            {

            }
        }
    }
}
