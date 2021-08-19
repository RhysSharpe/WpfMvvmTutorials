namespace LearnMvvmDemo
{
    public class EraseCommand
    {
        public ViewModel ViewModel { get; set; }

        public DelegateCommand Command { get; private set; }

        public EraseCommand()
        {
            this.Command = new DelegateCommand(this.ExecuteErase, this.CanErase);
        }

        public void ExecuteErase(object unused)
        {
            this.ViewModel.Name = string.Empty;
            this.ViewModel.Address = string.Empty;
            this.ViewModel.IsMale = true;
        }

        public bool CanErase(object unused)
        {
            return true;
        }

    }
}