using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_UIdesign.ViewModel
{
    public class ViewModelCommand: ICommand
    {
        //Fields
        private readonly Action<object> _executeAction;
        private readonly Action<object> _canexecuteAction;

        //Constructors
        public ViewModelCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _canexecuteAction = null;
        }

        public ViewModelCommand(Action<object> executeAction, Action<object> canexecuteAction)
        {
            _executeAction = executeAction;
            _canexecuteAction = canexecuteAction;
        }


        
        //Event
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
