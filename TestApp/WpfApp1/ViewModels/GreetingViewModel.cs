using System.Windows.Input;
using WpfApp1.Common;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class GreetingViewModel : BaseViewModel
    {
        private string _greetingMessage;

        public GreetingViewModel()
        {
            Person = new PersonModel { Name = "홍길동" };
            MakeGreetingCommand = new RelayCommand(MakeGreeting);
            MakeGreeting();
        }

        public PersonModel Person { get; }

        public string GreetingMessage
        {
            get { return _greetingMessage; }
            private set
            {
                if (_greetingMessage == value)
                {
                    return;
                }

                _greetingMessage = value;
                OnPropertyChanged();
            }
        }

        public ICommand MakeGreetingCommand { get; }

        private void MakeGreeting()
        {
            GreetingMessage = string.Format("안녕하세요, {0}님!", Person.Name);
        }
    }
}
