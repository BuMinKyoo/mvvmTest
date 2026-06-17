using System.Windows.Controls;

namespace TestApp.Controls
{
    /// <summary>
    /// ucMvvmCounter.xaml에 대한 상호 작용 논리
    /// MVVM 화면 - code-behind에는 로직이 없고, DataContext의 ViewModel이 모든 동작을 담당한다.
    /// </summary>
    public partial class ucMvvmCounter : UserControl
    {
        public ucMvvmCounter()
        {
            InitializeComponent();
        }
    }
}
