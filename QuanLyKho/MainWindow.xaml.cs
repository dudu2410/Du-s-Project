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

        private void Button_dshh(object sender, RoutedEventArgs e)
        {
            SetAllColor();
            Bdshh.Background = Brushes.Brown;
            dsHangHoa usercontrol = new dsHangHoa();
            gridUC.Children.Clear();
            gridUC.Children.Add(usercontrol);

        }

        private void Button_Nhap(object sender, RoutedEventArgs e)
        {
            SetAllColor();
            Bnh.Background = Brushes.Brown;
            ucNhap usercontrol = new ucNhap();
            gridUC.Children.Clear();
            gridUC.Children.Add(usercontrol);
        }      
       

        private void Bxh_Xuat(object sender, RoutedEventArgs e)
        {
            SetAllColor();
            Bxh.Background = Brushes.Brown;
            dsHangHoa usercontrol = new dsHangHoa();
            gridUC.Children.Clear();
            gridUC.Children.Add(usercontrol);

        }

        private void Button_KH(object sender, RoutedEventArgs e)
        {
            SetAllColor();
            Bkh.Background = Brushes.Brown;
            dsHangHoa usercontrol = new dsHangHoa();
            gridUC.Children.Clear();
            gridUC.Children.Add(usercontrol);
        }

        private void Button_Kho(object sender, RoutedEventArgs e)
        {
            SetAllColor();
            Bk.Background = Brushes.Brown;
            dsHangHoa usercontrol = new dsHangHoa();
            gridUC.Children.Clear();
            gridUC.Children.Add(usercontrol);
        }

        private void Button_TK(object sender, RoutedEventArgs e)
        {
            SetAllColor();
            Btk.Background = Brushes.Brown;
            dsHangHoa usercontrol = new dsHangHoa();
            gridUC.Children.Clear();
            gridUC.Children.Add(usercontrol);
        }

        private void Button_Us(object sender, RoutedEventArgs e)
        {
            SetAllColor();
            Bus.Background = Brushes.Brown;
            dsHangHoa usercontrol = new dsHangHoa();
            gridUC.Children.Clear();
            gridUC.Children.Add(usercontrol);
        }

        public void SetAllColor()
        {
            Bdshh.Background = Brushes.BlueViolet;
            Bnh.Background = Brushes.BlueViolet;
            Bxh.Background = Brushes.BlueViolet;
            Bk.Background = Brushes.BlueViolet;
            Btk.Background = Brushes.BlueViolet;
            Bkh.Background = Brushes.BlueViolet;
            Bus.Background = Brushes.BlueViolet;
            Bt.Background = Brushes.BlueViolet;
        }
    }
}
