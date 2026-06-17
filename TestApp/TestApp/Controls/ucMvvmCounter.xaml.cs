using System.Windows.Controls;

namespace TestApp.Controls
{
    /// <summary>
    /// ucMvvmCounter.xaml에 대한 상호 작용 논리
    /// MVVM 화면 - DataContext(ViewModel)는 부모(MainWindow)에서 바인딩으로 주입받고, 모든 동작은 ViewModel이 담당한다.
    /// </summary>
    public partial class ucMvvmCounter : UserControl
    {
        public ucMvvmCounter()
        {
            InitializeComponent();
        }
    }
}
