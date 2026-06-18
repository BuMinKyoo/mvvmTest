using System.Windows;
using System.Windows.Controls;
using TestApp.ViewModels;

namespace TestApp.Controls
{
    /// <summary>
    /// ucContent.xaml에 대한 상호 작용 논리
    /// 순수 code-behind 카운터. 단, 데이터는 MVVM 화면(ucMvvmCounter)과 같은
    /// CounterViewModel 인스턴스를 공유한다. (데이터 교환 시나리오)
    ///
    /// 주의: 이 화면은 비하인드 방식이라 PropertyChanged를 구독하지 않는다.
    /// 따라서 공유 데이터가 "다른 화면(MVVM)에서" 바뀌면 이 화면은 그 변화를 알지 못해
    /// 표시가 갱신되지 않는다(stale). 이것이 MVVM ↔ 순수 비하인드 데이터 교환의 문제다.
    /// </summary>
    public partial class ucContent : UserControl
    {
        private CounterViewModel _vm;

        public ucContent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// MVVM 화면과 공유할 ViewModel을 주입받는다. (단일 진실 공급원)
        /// </summary>
        public void AttachCounter(CounterViewModel vm)
        {
            _vm = vm;
            UpdateDisplay();
        }

        private void BtnIncrease_Click(object sender, RoutedEventArgs e)
        {
            if (_vm == null)
            {
                return;
            }

            // 공유 데이터를 setter로 변경 → MVVM 화면은 바인딩으로 자동 갱신됨
            _vm.Count++;
            // 이 화면은 비하인드라 직접 갱신해 줘야 한다
            UpdateDisplay();
        }

        private void BtnDecrease_Click(object sender, RoutedEventArgs e)
        {
            if (_vm == null)
            {
                return;
            }

            _vm.Count--;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            txtCount.Text = _vm.Count.ToString();
        }
    }
}
