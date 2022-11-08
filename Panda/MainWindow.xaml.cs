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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Ff.Navigate(new Panda2());
            ClassPanda1.MainFrame = Ff;
        }

        public int CountInPack { get; internal set; }
        public object Unit { get; internal set; }

        private void BntButton_Click(object sender, RoutedEventArgs e)
        {
            ClassPanda1.MainFrame.GoBack();
           

        }
        private void ContentRendered1(object sender, EventArgs e)
        {
            if (Ff.CanGoBack)
            {
                BcnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BcnBack.Visibility = Visibility.Hidden;
            }
        }

    }
}
