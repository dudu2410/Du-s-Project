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

using QuanLyKho.myUserControl;

namespace QuanLyKho
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

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_dshh(object sender, RoutedEventArgs e)
        {
            dsHangHoa usercontrol = new dsHangHoa();
            gridUC.Children.Clear();
            gridUC.Children.Add(usercontrol);

        }

        private void Button_Nhap(object sender, RoutedEventArgs e)
        {
            ucNhap usercontrol = new ucNhap();
            gridUC.Children.Clear();
            gridUC.Children.Add(usercontrol);
        }
    }
}
