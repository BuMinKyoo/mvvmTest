using System.ComponentModel;
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
    /// 비하인드 방식이지만 공유 ViewModel의 PropertyChanged를 추가로 구독하므로,
    /// 다른 화면(MVVM)에서 데이터가 바뀌어도 이 화면이 함께 갱신된다.
    /// (구독하지 않으면 MVVM에서 바뀐 값이 이 화면에 반영되지 않는 stale 문제가 생긴다)
    /// </summary>
    public partial class ucContent : UserControl
    {
        private CounterViewModel _vm;

        public ucContent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// MVVM 화면과 공유할 ViewModel을 주입받고, 변경 알림을 구독한다. (단일 진실 공급원)
        /// </summary>
        public void AttachCounter(CounterViewModel vm)
        {
            _vm = vm;
            //_vm.PropertyChanged += Vm_PropertyChanged;
            UpdateDisplay();
        }

        /// <summary>
        /// 공유 데이터(Count)가 어디서 바뀌든(비하인드/MVVM) 이 화면을 따라 갱신한다.
        /// </summary>
        //private void Vm_PropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    if (e.PropertyName == nameof(CounterViewModel.Count))
        //    {
        //        UpdateDisplay();
        //    }
        //}

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
