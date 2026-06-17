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
using TestApp.ViewModels;

namespace TestApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void BtnHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("안녕하세요!", "인사");
        }

        private void BtnNow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "현재 시각");
        }
    }
}
