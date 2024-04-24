using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;


namespace WpfApp1
{
    abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    internal class CalcViewModel : ViewModelBase
    {
        readonly ClassCalc Calc = new();
        public string Label { get; private set; } = "0";

        public void NumCommand(object content)
        {
            var n = int.Parse((string)content);

            Calc.NumKey(n);

            Label = Calc.Result ;

            OnPropertyChanged(nameof(Label));
        }
        public void CmdCommand(object content)
        {
            switch ((string)content)
            {
                case "C":
                    // 初期化処理
                    Calc.ClrKey();
                    break;

                case ".":
                    Calc.DotKey();
                    break;

                case "/":
                    Calc.DivisionKey();
                    break;

                case "*":
                    Calc.MultiKey();
                    break;

                case "+":
                    Calc.PlusKey();
                    break;

                case "-":
                    Calc.MinusKey();
                    break;

                case "=":
                    Calc.EnterKey();
                    break;
            }

            // 計算結果の設定
            Label = Calc.Result;
            OnPropertyChanged(nameof(Label));
        }





    }
}
