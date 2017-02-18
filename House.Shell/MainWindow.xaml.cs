using House.Login.Views;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace House.Shell
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            verifyUser();
            InitializeComponent();

        }

        private void verifyUser()
        {
            House.Login.Views.LoginView loginWindows = new LoginView();
            if (!loginWindows.ShowDialog() == true)
            {
                Application.Current.Shutdown();
            }
            else
            {


            }

        }
    }
}
