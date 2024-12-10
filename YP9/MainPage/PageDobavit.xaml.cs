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
    /// Логика взаимодействия для PageDobavit.xaml
    /// </summary>
    public partial class PageDobavit : Page
    {
        private List_of_doctors _currentHosoital = new List_of_doctors();
        public PageDobavit(List_of_doctors selectedVrach)
        {
            InitializeComponent();
            if (selectedVrach != null)
                _currentHosoital = selectedVrach;

            DataContext = _currentHosoital;
        }
    }
}
