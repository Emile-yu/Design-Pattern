using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Strategy_Calculator.Common
{
    public class CommandBase : ICommand
    {

        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public CommandBase(Action<object> execute) : this(execute, null)
        {

        }

        public CommandBase(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            _execute = execute;

            if (canExecute != null)
            {
                _canExecute = canExecute;
            }
        }
        public event EventHandler CanExecuteChanged;
        //public event EventHandler CanExecuteChanged
        //{
        //    add
        //    {
        //        if (_canExecute != null)
        //        {
        //            CommandManager.RequerySuggested += value;

        //        }
        //    }
        //    remove
        //    {
        //        if (_canExecute != null)
        //        {
        //            CommandManager.RequerySuggested -= value;

        //        }
        //    }
        //}

        public bool CanExecute(object parameter)
        {
            bool result = false;
            result = _canExecute == null || _canExecute(parameter);
            return result;
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke(parameter);
        }

        protected virtual void OnCanExecuteChanged()
        {
            // ISSUE: reference to a compiler-generated field
            EventHandler eventHandler = this.CanExecuteChanged;
            eventHandler?.Invoke(this, EventArgs.Empty);
            //if (eventHandler == null)
            //    return;
            //eventHandler((object)this, EventArgs.Empty);
        }

        public void RaiseCanExecuteChanged()
        {
            this.OnCanExecuteChanged();
        }


    }
}
