using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestApp.ViewModels
{
    /// <summary>
    /// 모든 ViewModel의 기반 클래스.
    /// INotifyPropertyChanged를 구현해 View에 변경 통지를 보낸다.
    /// </summary>
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 속성 변경을 View에 통지한다.
        /// </summary>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
