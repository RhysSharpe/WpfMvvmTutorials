using CSharpCornerDemoByMujeebRahman2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CSharpCornerDemoByMujeebRahman2.ViewModel
{
    class ProductViewModel
    {
        private IList<Product> products;
        private ICommand updater;

        public ProductViewModel()
        {
            products = new List<Product>
            {
                new Product() { ID = 1, Name = "Pro1", Price = 10 },
                new Product() { ID = 2, Name = "BAse2", Price = 12 }
            };
        }

        public IList<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }

        public ICommand UpdateCommad { get; set; }
        //{
        //    get
        //    {
        //        if (updater == null)
        //            updater = new Updater();

        //        return updater;
        //    }
        //    set
        //    {
        //        updater = value;
        //    }
        //}

        private class Updater : ICommand
        {
            #region ICommand Members

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }
    }
}
