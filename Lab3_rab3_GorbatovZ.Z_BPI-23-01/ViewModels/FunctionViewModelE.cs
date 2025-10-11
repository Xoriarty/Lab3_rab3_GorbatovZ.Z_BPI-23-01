using Lab3_rab3_GorbatovZ.Z_BPI_23_01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_rab3_GorbatovZ.Z_BPI_23_01.ViewModels
{
    class FunctionViewModelE : INotifyPropertyChanged
    {
        private FunctionModelE _func;

        public FunctionViewModelE()
        {
            _func = new FunctionModelE(0, 0, 1, 1);
        }
        public string ImagePath => _func.Path;
        public double X
        {
            get { return _func.X; }
            set
            {
                if (_func.X != value)
                {
                    _func.X = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result));
                }
            }
        }
        public double Y
        {
            get { return _func.Y; }
            set
            {
                if (_func.Y != value)
                {
                    _func.Y = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result));
                }
            }
        }
        public int N
        {
            get { return _func.N; }
            set
            {
                if (_func.N != value)
                {
                    _func.N = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result));
                }
            }
        }
        public int K
        {
            get { return _func.K; }
            set
            {
                if (_func.K != value)
                {
                    _func.K = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result));
                }
            }
        }
        public double Result => _func.Result;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
