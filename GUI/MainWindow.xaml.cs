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
using System.Data;
using System.Threading;
using BUS;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BUS.TiepNhanDaiLyBUS userBUS;
        public MainWindow()
        {
            DataTable temp = new DataTable();
            DataTable temp2 = new DataTable();
            InitializeComponent();
           
            
            
            
            //temp = userBUS.FillComboBox("QUAN", "MaQuan");
            //temp.AcceptChanges();
            //quan_ui.ItemsSource = temp.AsDataView();
            //temp2 = userBUS.FillComboBox("LOAIDAILY", "MaLoaiDaiLy");
            //loaidaily_ui.ItemsSource = temp2.AsDataView();

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            userBUS = new BUS.TiepNhanDaiLyBUS();

        }
    }
}
