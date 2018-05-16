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

        //public class hanghoa
        //{
        //    public hanghoa()
        //    {
        //        mahh = "";
        //        tenhh = "";
        //        slton = 0;
        //        gia = 0;
        //    }
        //    public string mahh { get; set; }
        //    public string tenhh { get; set; }
        //    public int slton { get; set; }
        //    public double gia { get; set; }

        //}
        public dsHangHoa()
        {
            InitializeComponent();
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            QLKEntities db = new QLKEntities();
            lvdsHangHoa.ItemsSource = db.hanghoas.ToList();
           
            //var a = DataProvider.Ins.DB.hanghoas.ToList();
            //List <hanghoa> b= new List<hanghoa>();
          

            //lvdsHangHoa.ItemsSource = ;
        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lvdsHangHoa_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}


