using System.Windows.Controls;
using TestApp.ViewModels;

namespace TestApp.Controls
{
    /// <summary>
    /// ucMvvmCounter.xaml에 대한 상호 작용 논리
    /// MVVM 화면 - code-behind에서 ViewModel을 DataContext로 연결하고, 모든 동작은 ViewModel이 담당한다.
    /// </summary>
    public partial class ucMvvmCounter : UserControl
    {
        public ucMvvmCounter()
        {
            InitializeComponent();
            DataContext = new CounterViewModel();
        }
    }
}
