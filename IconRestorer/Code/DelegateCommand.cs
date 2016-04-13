using System;
using System.Windows.Input;

namespace IconRestorer.Code
{
    internal class DelegateCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        public DelegateCommand(Action<object> onExecuteMethod, Predicate<object> onCanExecuteMethod = null)
        {
            execute = onExecuteMethod;
            canExecute = onCanExecuteMethod ?? ((arg) => true);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
