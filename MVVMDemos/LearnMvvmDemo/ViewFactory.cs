using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMvvmDemo
{
    public class ViewFactory
    {
        public ViewInfrastructure Create()
        {
            SaveCommand saveCommand = new SaveCommand();
            EraseCommand eraseCommand = new EraseCommand();

            Model model = new Model() { Name = "Test Name", Address = "123 Test Address", IsMale = true };
            ViewModel viewModel = new ViewModel(model, saveCommand.Command, eraseCommand.Command);
            View view = new View();

            eraseCommand.ViewModel = viewModel;

            return new ViewInfrastructure(view, viewModel, model);
        }
    }
}
