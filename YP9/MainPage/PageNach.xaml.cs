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
using YP9.ApplicationData;

namespace YP9.MainPage
{
    /// <summary>
    /// Логика взаимодействия для PageNach.xaml
    /// </summary>
    public partial class PageNach : Page
    {
        public PageNach()
        {
            InitializeComponent();
        }

        private void Zapis_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageZapis ());
        }

        private void Klient_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageKlient());
        }

        private void Vrach_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageVrach());
        }
    }
}
