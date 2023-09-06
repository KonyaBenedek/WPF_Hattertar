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

namespace WpfApp1
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

        private void sliErtek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbErtek.Content = Convert.ToInt32(sliErtek.Value);
        }

        private void btnSzamol_Click(object sender, RoutedEventArgs e)
        {
            if (cbData1.SelectedItem != null && cbData2.SelectedItem != null)
            {
                if (cbData1.SelectedIndex == cbData2.SelectedIndex) //azonos
                {
                    lbAtviteli.Content = Math.Round(Convert.ToDouble(txtAdat.Text) / Convert.ToDouble(sliErtek.Value), 2);
                }
                else if (cbData1.SelectedIndex == 0 && cbData2.SelectedIndex == 1) //kb - MBps
                {
                    lbAtviteli.Content = Math.Round(Convert.ToDouble(txtAdat.Text) / Convert.ToDouble(sliErtek.Value), 2) / 1000;
                }
                else if (cbData1.SelectedIndex == 0 && cbData2.SelectedIndex == 2) //kb - GBps
                {
                    lbAtviteli.Content = Math.Round(Convert.ToDouble(txtAdat.Text) / Convert.ToDouble(sliErtek.Value), 2) / 1000000;
                }
                else if (cbData1.SelectedIndex == 1 && cbData2.SelectedIndex == 0) //mb - KBps
                {
                    lbAtviteli.Content = Math.Round(Convert.ToDouble(txtAdat.Text) / Convert.ToDouble(sliErtek.Value), 2) * 1000;
                }
                else if (cbData1.SelectedIndex == 2 && cbData2.SelectedIndex == 0) //GB - KBps
                {
                    lbAtviteli.Content = Math.Round(Convert.ToDouble(txtAdat.Text) / Convert.ToDouble(sliErtek.Value), 2) * 1000000;
                }
                else if (cbData1.SelectedIndex == 3 && cbData2.SelectedIndex == 0) //TB - KBps
                {
                    lbAtviteli.Content = Math.Round(Convert.ToDouble(txtAdat.Text) / Convert.ToDouble(sliErtek.Value), 2) * 1000000000;
                }
                else if (cbData1.SelectedIndex == 2 && cbData2.SelectedIndex == 1) //GB - MBps
                {
                    lbAtviteli.Content = Math.Round(Convert.ToDouble(txtAdat.Text) / Convert.ToDouble(sliErtek.Value), 2) * 1000;
                }
                else if (cbData1.SelectedIndex == 3 && cbData2.SelectedIndex == 1) //TB - MBps
                {
                    lbAtviteli.Content = Math.Round(Convert.ToDouble(txtAdat.Text) / Convert.ToDouble(sliErtek.Value), 2) * 1000000;
                }
                else if (cbData1.SelectedIndex == 1 && cbData2.SelectedIndex == 2) //MB - GBps
                {
                    lbAtviteli.Content = Math.Round(Convert.ToDouble(txtAdat.Text) / Convert.ToDouble(sliErtek.Value), 2) / 1000;
                }
                else if (cbData1.SelectedIndex == 1 && cbData2.SelectedIndex == 2) //TB - GBps
                {
                    lbAtviteli.Content = Math.Round(Convert.ToDouble(txtAdat.Text) / Convert.ToDouble(sliErtek.Value), 2) * 1000;
                }
            }

        }
    }
}
