using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMvvmDemo
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DelegateCommand SaveCommand { get; set; }
        public DelegateCommand EraseCommand { get; set; }


        private readonly Model model;

        public string Name
        {
            get
            {
                return this.model.Name;
            }
            set
            {
                if (this.model.Name != value)
                {
                    this.model.Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        public string Address
        {
            get
            {
                return this.model.Address;
            }
            set
            {
                if (this.model.Address != value)
                {
                    this.model.Address = value;
                    this.OnPropertyChanged("Address");
                }
            }
        }

        public bool IsMale
        {
            get
            {
                return this.model.IsMale;
            }
            set
            {
                if (this.model.IsMale != value)
                {
                    this.model.IsMale = value;
                    this.OnPropertyChanged("IsMale");
                }
            }
        }

        public ViewModel(Model model, DelegateCommand save, DelegateCommand erase)
        {
            this.model = model;
            SaveCommand = save;
            EraseCommand = erase;
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
