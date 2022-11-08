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
    /// Логика взаимодействия для Panda1.xaml
    /// </summary>
    public partial class Panda1 : Page
    {

        private MainWindow _Panda = new MainWindow();
        public Panda1()
        {
            InitializeComponent();
            DataContext = _Panda;
            Combo.ItemsSource = WEWEEntities.GetContext().Material.ToList();


        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_Panda.Title))
                errors.AppendLine("Укажите название материала");
            if (_Panda.CountInPack < 1 || _Panda.CountInPack > 10)
                errors.AppendLine("Количество в упаковке от 1 до 10");
            if (_Panda.Unit == null)
                errors.AppendLine("Выберите ед. изм.");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_Panda.CountInPack == 0)

                WEWEEntities.GetContext()    .Add(_Panda); 
            
        }
    }
}
