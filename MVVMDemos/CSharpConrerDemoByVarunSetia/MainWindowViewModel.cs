using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CSharpConrerDemoByVarunSetia
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                CheckAndEnableButton();
                OnPropertyChanged();
            }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                CheckAndEnableButton();
                OnPropertyChanged();
            }
        }

        public ICommand SubmitButtonCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel()
        {
            CheckAndEnableButton();
            PropertyChanged += MainWindowViewModel_PropertyChanged;
        }

        private void MainWindowViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Debug.WriteLine(sender.GetType() + " " + e.PropertyName);
        }

        // Create the OnPropertyChanged method to raise the event  
        // The calling member's name will be used as the parameter.  
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void CheckAndEnableButton()
        {
            bool isEnabled = false;
            string result = string.Empty;
            if (Name?.Length > 0 && PhoneNumber?.Length > 0)
            {
                isEnabled = true;
                result = string.Format("My Details are:\n{0}\n{1}\n", Name, PhoneNumber);
            }
            else
            {
                isEnabled = false;
            }
            SubmitButtonCommand = new RelayCommand((ob) => { return isEnabled; }, (ob) => { MessageBox.Show(result); });
            OnPropertyChanged("SubmitButtonCommand");
        }
    }
}
