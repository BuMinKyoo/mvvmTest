using WpfApp1.Common;

namespace WpfApp1.ViewModels
{
    public class CounterViewModel : BaseViewModel
    {
        private int _count;

        public CounterViewModel()
        {
            IncreaseCommand = new RelayCommand(Increase);
            DecreaseCommand = new RelayCommand(Decrease, CanDecrease);
        }

        public int Count
        {
            get { return _count; }
            private set
            {
                if (_count == value)
                {
                    return;
                }

                _count = value;
                OnPropertyChanged();
                DecreaseCommand.RaiseCanExecuteChanged();
            }
        }

        public RelayCommand IncreaseCommand { get; }

        public RelayCommand DecreaseCommand { get; }

        private void Increase()
        {
            Count++;
        }

        private void Decrease()
        {
            Count--;
        }

        private bool CanDecrease()
        {
            return Count > 0;
        }
    }
}
