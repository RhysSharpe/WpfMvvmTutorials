using RIPTutorialMvvmDemo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RIPTutorialMvvmDemo.ViewModel
{
    /***
     * The class must implement the INotifyPropertyChanged interface,
     * declare a PropertyChangedEventHandler event, and create a method to raise the event.
     * Next, declare a field and a corresponding property, making sure to call the OnPropertyChanged()
     * method in the property's set accessor.
     * The constructor in the below example is being used to demonstrate that the Model provides the data to the ViewModel.
     */

    // Implements INotifyPropertyChanged interface to support bindings
    public class HelloWorldViewModel : INotifyPropertyChanged
    {
        private string helloString;

        public event PropertyChangedEventHandler PropertyChanged;

        public string HelloString
        {
            get
            {
                return helloString;
            }
            set
            {
                helloString = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Raises OnPropertychangedEvent when property changes
        /// </summary>
        /// <param name="name">String representing the property name</param>
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public HelloWorldViewModel()
        {
            HelloWorldModel helloWorldModel = new HelloWorldModel();
            helloString = helloWorldModel.ImportantInfo;
        }
    }
}
