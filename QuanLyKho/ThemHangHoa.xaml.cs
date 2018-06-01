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
    /// Interaction logic for ThemHangHoa.xaml
    /// </summary>
    public partial class ThemHangHoa : Window
    {
        public ThemHangHoa()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var them = new hanghoa();
            them.tenhh = tbten.Text.ToString();
            them.mahh = tbma.Text.ToString();
            them.slton = Int32.Parse(tbslton.Text);
            them.gia = float.Parse(tbgia.Text);
            using (var db = new QLKEntities())
            {
                db.hanghoas.Add(them);
                db.SaveChanges();
            }            
            this.Close();           
        }
    }
}
