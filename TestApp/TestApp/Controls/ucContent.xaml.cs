using System.Windows;
using System.Windows.Controls;

namespace TestApp.Controls
{
    /// <summary>
    /// ucContent.xaml에 대한 상호 작용 논리
    /// 버튼으로 숫자를 증가/감소하는 단순 카운터 (순수 code-behind).
    /// </summary>
    public partial class ucContent : UserControl
    {
        private int _count = 0;

        public ucContent()
        {
            InitializeComponent();
        }

        private void Btn증가_Click(object sender, RoutedEventArgs e)
        {
            _count++;
            txt숫자.Text = _count.ToString();
        }

        private void Btn감소_Click(object sender, RoutedEventArgs e)
        {
            _count--;
            txt숫자.Text = _count.ToString();
        }
    }
}
