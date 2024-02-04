using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UIMock
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool isBusy = false;

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
                                      [CallerMemberName] string? propertyName = null,
                                      Action? onChanged = default)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged = null;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
                return;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}

