using Quartets.ModelLogic;
using System.Windows.Input;

namespace Quartets.ViewModels
{
    internal class MainPageVM
    {
        private readonly User user = new User();
        public ICommand RegisterCommand { get; }
        public MainPageVM()
        {
            RegisterCommand = new Command(Register, CanRegister);
        }

        private void Register(object obj)
        {
            user.Register();
        }

        public bool CanRegister(object arg)
        {
            return !string.IsNullOrWhiteSpace(user.Name);
        }



        public string Name
        {
            get => user.Name;
            set
            {
                user.Name = value;
                ((Command)RegisterCommand)?.ChangeCanExecute();


            }
        }

    }
}
