using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsPointHierarchiesDemo.Model
{
    public class Customer : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string phone;
        private string email;

        public string FirstName
        {
            get { return firstName; }

            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string LastName
        {
            get { return lastName; }

            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    RaisePropertyChanged("LastName");
                    RaisePropertyChanged("FullName");
                }
            }
        }
        public string Phone
        {
            get { return phone; }

            set
            {
                if (phone != value)
                {
                    phone = value;
                    RaisePropertyChanged("Phone");
                }
            }
        }
        public string Email
        {
            get { return email; }

            set
            {
                if (email != value)
                {
                    email = value;
                    RaisePropertyChanged("Email");
                }
            }
        }

        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged("Id");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
