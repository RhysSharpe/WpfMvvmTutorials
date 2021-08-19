using System.Windows;

namespace LearnMvvmDemo
{
    public class SaveCommand
    {
        public DelegateCommand Command { get; private set; }

        public SaveCommand()
        {
            this.Command = new DelegateCommand(this.ExecuteSave, this.CanSave);
        }

        public void ExecuteSave(object unused)
        {
            MessageBox.Show("Save executed, but not really.");
        }

        public bool CanSave(object unused)
        {
            return true;
        }
    }
}