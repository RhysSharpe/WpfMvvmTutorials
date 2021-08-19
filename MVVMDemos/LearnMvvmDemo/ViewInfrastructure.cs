using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMvvmDemo
{
    public class ViewInfrastructure
    {
        public View View { get; private set; }

        public ViewModel ViewModel { get; private set; }

        public Model Model { get; private set; }

        public ViewInfrastructure(View view, ViewModel viewModel, Model model)
        {
            this.View = view;
            this.ViewModel = viewModel;
            this.Model = model;
        }
    }
}
