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
    /// Логика взаимодействия для PageKlient.xaml
    /// </summary>
    public partial class PageKlient : Page
    {
        public PageKlient()
        {
            InitializeComponent();
            GtGridKlient.ItemsSource = hospitalEntities.GetContext().Client_list.ToList();
        }

        private void Nazad_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageNach());
        }

       

        private void Dobavit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            hospitalEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            GtGridKlient.ItemsSource = hospitalEntities.GetContext().Client_list.ToList();
        }
    }
}
