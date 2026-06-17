namespace TestApp.ViewModels
{
    /// <summary>
    /// MainWindow의 상위 ViewModel.
    /// 화면에서 사용하는 하위 ViewModel들을 프로퍼티로 노출하고,
    /// 각 View는 DataContext 바인딩으로 해당 하위 ViewModel을 주입받는다.
    /// </summary>
    public class MainViewModel
    {
        public MainViewModel()
        {
            Counter = new CounterViewModel();
        }

        public CounterViewModel Counter { get; }
    }
}
