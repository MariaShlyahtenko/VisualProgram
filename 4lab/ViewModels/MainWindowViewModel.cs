using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;
using AvaloniaApplication5.Models;
namespace AvaloniaApplication5.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string b;
        string oper = " ";
        private RomanNumberExtend _result;
        private RomanNumberExtend _secondValue;
        public MainWindowViewModel()
        {
            AddNum = ReactiveCommand.Create<string, string>(AddNumTo);
            ExecuteOperationCommand = ReactiveCommand.Create<string>(ExecuteOperation);
        }
        public string ShowValue
        {
            set
            {
                this.RaiseAndSetIfChanged(ref b, value);
            }
            get
            {
                return b;
            }
        }
        public ReactiveCommand<string, string> AddNum { get; }
        public ReactiveCommand<string, Unit> ExecuteOperationCommand { get; }

        private string AddNumTo(string str)
        {
            if (oper == "n")
            {
                ShowValue = str;
                oper = " ";
            }
            else
            {
                ShowValue += str;
            }
            return ShowValue;
        }
        private void ExecuteOperation(string operation)
        {
            if (RomanNumberExtend.ToInt(b) > 0)
                _secondValue = new RomanNumberExtend(b);
            RomanNumber temp;
            try
            {
                switch (oper[0])
                {
                    case '+':
                        {
                            temp = _result + _secondValue;
                            _result = new RomanNumberExtend(temp.ToString());
                            break;
                        }
                    case '*':
                        {
                            temp = _result * _secondValue;
                            _result = new RomanNumberExtend(temp.ToString());
                            break;
                        }
                    case '/':
                        {
                            temp = _result / _secondValue;
                            _result = new RomanNumberExtend(temp.ToString());
                            break;
                        }
                    case '-':
                        {
                            temp = _result - _secondValue;
                            _result = new RomanNumberExtend(temp.ToString());
                            break;
                        }
                    case ' ':
                        {
                            if (RomanNumberExtend.ToInt(b) > 0)
                                _result = new RomanNumberExtend(b);
                            break;
                        }
                    case 'n':
                        {
                            if (RomanNumberExtend.ToInt(b) > 0)
                                _result = new RomanNumberExtend(b);
                            break;
                        }
                    default:
                        break;
                }
                if (operation == "=")
                {
                    if (_result != null)
                        ShowValue = _result.ToString();
                    oper = "n";
                    _result = null;
                }
                else
                {
                    oper = operation;
                    ShowValue = "";
                }
            }
            catch (RomanNumberException ex)
            {
                ShowValue = $"{ex.Message}";
            }
        }
    }
}