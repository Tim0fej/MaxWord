using MaxWord.ViewModel;
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

namespace MaxWord
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            DataContext = new StartWindowViewModel();
        }

        private void Button_CreateFile(object sender, RoutedEventArgs e)
        {

        }

        private void Button_OpenFile(object sender, RoutedEventArgs e)
        {

        }

        private void Button_OpenFolder(object sender, RoutedEventArgs e)
        {

        }
    }
}
