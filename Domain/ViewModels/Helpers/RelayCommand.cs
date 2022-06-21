using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Todo.Core.Helpers
{
    public class RelayCommand : ICommand
    {

        private Action maction;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public RelayCommand(Action action)
        {
            maction = action;
        }

        public void Execute(object parameter)
        {
            maction();
            
        }
    }
}
