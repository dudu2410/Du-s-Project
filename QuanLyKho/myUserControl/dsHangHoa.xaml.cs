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
using QuanLyKho.Model;

namespace QuanLyKho.myUserControl
{
    /// <summary>
    /// Interaction logic for dsHangHoa.xaml
    /// </summary>
    public partial class dsHangHoa : UserControl
    {       
        public dsHangHoa()
        {
            InitializeComponent();
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            QLKEntities db = new QLKEntities();
            lvdsHangHoa.ItemsSource = db.hanghoas.ToList();          
        }
                

        

        private void Click_Them(object sender, RoutedEventArgs e)
        {
            ThemHangHoa a = new ThemHangHoa();
            a.ShowDialog();
            LoadDuLieu();
        }

        private void Click_Xoa(object sender, RoutedEventArgs e)
        {
            if(lvdsHangHoa.SelectedItem !=null)
            {
                var a = new hanghoa();
                a = (hanghoa)lvdsHangHoa.SelectedItem;
                using (var db = new QLKEntities())
                {
                    var delete = (from d in db.hanghoas where d.mahh == a.mahh select d).Single();
                    db.hanghoas.Remove(delete);
                    db.SaveChanges();
                }
                QLKEntities t = new QLKEntities();
                lvdsHangHoa.ItemsSource = t.hanghoas.ToList();
                MessageBox.Show("Đã xóa.");
            }           
        }

        private void Click_Sua(object sender, RoutedEventArgs e)
        {
            var a = new hanghoa();
            a = (hanghoa)lvdsHangHoa.SelectedItem;
            SuaHangHoa sua = new SuaHangHoa(a);
            sua.ShowDialog();
            LoadDuLieu();
        }
    }
}


