using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CSharpCornerDemoByMujeebRahman
{
    public class MainWindowViewModel
    {
        private ICommand buttonCommand;

        public ICommand ButtonCommand
        {
            get
            {
                return buttonCommand;
            }
            set
            {
                buttonCommand = value;
            }
        }

        public MainWindowViewModel()
        {
            ButtonCommand = new RelayCommand(new Action<object>(ShowMessage));
        }

        public void ShowMessage(object obj)
        {
            MessageBox.Show(obj.ToString());
        }
    }
}
