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

namespace MVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.TBoxNum1 = TBoxNum1;
            Model.TBoxNum2 = TBoxNum2;
            Model.TBlockOperation = TBlockOperation;
            Model.TBlockAnswer = TBlockAnswer;
            CBOperation.ItemsSource = Model.listOperations;
            CBOperation.SelectedIndex = 0;
        }

        private void CBOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.SelectCombo = CBOperation.SelectedIndex;
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            Model.Counting();
        }
    }
}
