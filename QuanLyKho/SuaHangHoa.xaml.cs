using QuanLyKho.Model;
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

namespace QuanLyKho
{
    /// <summary>
    /// Interaction logic for SuaHangHoa.xaml
    /// </summary>
    public partial class SuaHangHoa : Window
    {
        public SuaHangHoa(hanghoa a)
        {
            InitializeComponent();
            tbma.Text = a.mahh;
            tbgia.Text=a.gia.ToString();
            tbslton.Text = a.slton.ToString();
            tbten.Text = a.tenhh;
            tbma.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sua = new hanghoa();
            sua.tenhh = tbten.Text.ToString();
            sua.mahh = tbma.Text.ToString();
            sua.slton = Int32.Parse(tbslton.Text);
            sua.gia = float.Parse(tbgia.Text);
            using (var db = new QLKEntities())
            {
                var update = (from u in db.hanghoas where u.mahh == sua.mahh select u).Single();
                update.tenhh = sua.tenhh;
                update.slton = sua.slton;
                update.gia = sua.gia;
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
