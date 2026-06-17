using System.Windows.Input;

namespace TestApp.ViewModels
{
    /// <summary>
    /// 카운터 화면의 ViewModel. BaseViewModel을 상속받는다.
    /// Count 속성과 증가/감소 Command를 노출한다.
    /// </summary>
    public class CounterViewModel : BaseViewModel
    {
        private int _count;

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                OnPropertyChanged();
            }
        }

        public ICommand IncreaseCommand { get; }
        public ICommand DecreaseCommand { get; }

        public CounterViewModel()
        {
            IncreaseCommand = new RelayCommand(o => Count++);
            DecreaseCommand = new RelayCommand(o => Count--);
        }
    }
}
