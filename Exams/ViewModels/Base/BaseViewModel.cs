using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Exams.ViewModels.Base
{
    internal abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region Реализация интерфейса INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if(Equals(field, value))
            {
                return false;
            }
            else
            {
                field = value;
                OnPropertyChanged(propertyName);
                return true;
            }
        }
    }
}
