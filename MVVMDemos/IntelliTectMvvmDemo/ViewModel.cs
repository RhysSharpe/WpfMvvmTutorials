using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IntelliTectMvvmDemo
{
    //public class ViewModel : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    public string FirstName { get; set; }

    //    public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    //}

    // The commented class above requires a manual call to update the property changed:
    // viewModel.OnPropertyChanged(nameof(ViewModel.FirstName));

    // The new class below does this via the property setter
    public class ViewModel : ViewModelBase
    {
        private readonly DelegateCommand _changeNameCommand;
        public ICommand ChangeNameCommand => _changeNameCommand;
        
        public ViewModel()
        {
            _changeNameCommand = new DelegateCommand(OnChangeName, CanChangeName);
        }

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        private void OnChangeName(object commandParameter)
        {
            FirstName = "Walter";
            _changeNameCommand.InvokeCanExecuteChanged();
        }

        private bool CanChangeName(object commandParameter)
        {
            return FirstName != "Walter";
        }
    }
}
