using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CSharpCornerDemoByMujeebRahman
{
    /***
     * 
     * When the user clicks on buttons, the application reacts and satisfies the user's requests.
     * This works because of bindings that were established on the Command property of Button displayed in the UI.
     * The command object acts as an adapter that makes it easy to consume a ViewModel's functionality from a view declared in XAML.
            Command="{Binding ButtonCommand}" 
            CommandParameter="Hello World!"
     * 
     */

    public class RelayCommand : ICommand
    {
        private Action<object> _action;

        public RelayCommand(Action<object> action)
        {
            _action = action;
        }

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (parameter != null)
            {
                _action(parameter);
            }
            else
            {
                _action("Hello World");
            }
        }

        #endregion
    }
}
