using Strategy_Calculator.Common;
using Strategy_Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Strategy_Calculator.ViewModels
{
    public class MainWindowViewModel : NotifyBase
    {
        private string _firstParameter;
        private string _secondParameter;
        private CommandBase _calculate;
        private string _calculateResult;
        private string _selectedOpertor;

        public string FirstParameter
        {
            get { return _firstParameter; }
            set 
            { 
                _firstParameter = value;
                this.NotifyChanged();
                Calculate.RaiseCanExecuteChanged();
                //Calculate.CanExecute(null);
            }
        }

        public string SecondParameter
        {
            get { return _secondParameter; }
            set 
            { 
                _secondParameter = value;
                this.NotifyChanged();
                Calculate.RaiseCanExecuteChanged();
            }
        }

        public string CalculateResult
        {
            get { return _calculateResult; }
            set 
            { 
                _calculateResult = value;
                this.NotifyChanged();
            }
        }

        public string SelectedOperator
        {
            get { return _selectedOpertor; }
            set 
            { 
                _selectedOpertor = value;
                this.NotifyChanged();
            }
        }



        public CommandBase Calculate
        {
            get { return _calculate; }
            set { _calculate = value; }
        }

        public MainWindowViewModel()
        {
            _calculate = new CommandBase(CalculateAction, CanCalculate);
        }

        private void CalculateAction(object parameter)
        {
            if (!String.IsNullOrWhiteSpace(this._selectedOpertor))
            {
                StrategyConcrete strategyConcrete = new StrategyConcrete(_selectedOpertor);

                this.CalculateResult = strategyConcrete.GetResult(_firstParameter, _secondParameter);
            }
        }

        private bool CanCalculate(object parameter)
        {
            bool result = false;
            result = (!String.IsNullOrWhiteSpace(this._firstParameter)) && (!String.IsNullOrWhiteSpace(this._secondParameter));
            return result;
        }

    }
}
