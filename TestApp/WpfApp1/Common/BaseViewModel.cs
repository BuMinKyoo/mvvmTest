using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1.Common
{
    /// <summary>
    /// 모든 ViewModel이 공통으로 사용하는 기반 클래스입니다.
    /// INotifyPropertyChanged 구현과 속성 변경 알림 헬퍼를 제공합니다.
    /// </summary>
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 지정한 속성의 변경 알림을 발생시킵니다.
        /// </summary>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
