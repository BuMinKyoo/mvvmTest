namespace WpfApp1.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Greeting = new GreetingViewModel();
            Counter = new CounterViewModel();
        }

        public GreetingViewModel Greeting { get; }

        public CounterViewModel Counter { get; }

    }
}
