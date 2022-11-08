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

namespace Panda
{
    /// <summary>
    /// Логика взаимодействия для Panda2.xaml
    /// </summary>
    public partial class Panda2 : Page
    { 
        public Panda2()
        {
            InitializeComponent();
            DrGridPanda1.ItemsSource = WEWEEntities.GetContext().Material.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)

        {
            ClassPanda1.MainFrame.Navigate(new Panda1());
        }

        private void BtnAdd(object sender, RoutedEventArgs e)
        {
            ClassPanda1.MainFrame.Navigate(new Panda1());
        }

        private void BtnDelet(object sender, RoutedEventArgs e)
        {

        }
    }
}
