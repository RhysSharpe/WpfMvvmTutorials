using MicrosoftJoshSmithDemo.Model;
using System;

namespace MicrosoftJoshSmithDemo.DataAccess
{
    /// <summary>
    /// Event arguments used by CustomerRepository's CustomerAdded event.
    /// </summary>
    public class CustomerAddedEventArgs : EventArgs
    {
        public CustomerAddedEventArgs(Customer newCustomer)
        {
            this.NewCustomer = newCustomer;
        }

        public Customer NewCustomer { get; private set; }
    }
}