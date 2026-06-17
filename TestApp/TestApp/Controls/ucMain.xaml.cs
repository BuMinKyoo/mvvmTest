using System.Windows.Controls;

namespace TestApp.Controls
{
    /// <summary>
    /// ucMain.xaml에 대한 상호 작용 논리
    /// 툴바 + 좌/중/우 3분할 골격 (순수 code-behind).
    /// 각 패널 자리에 추후 MVVM UserControl을 하나씩 끼워넣는다.
    /// </summary>
    public partial class ucMain : UserControl
    {
        public ucMain()
        {
            InitializeComponent();
        }
    }
}
