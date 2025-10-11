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
    class FunctionViewModelD : INotifyPropertyChanged
    {
        private FunctionModelD _func;

        public FunctionViewModelD()
        {
            _func = new FunctionModelD(0, 0, 0);
        }
        public string ImagePath => _func.Path;
        public double A
        {
            get { return _func.A; }
            set
            {
                if (_func.A != value)
                {
                    _func.A = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result));
                }
            }
        }
        public int D
        {
            get { return _func.D; }
            set
            {
                if (_func.D != value)
                {
                    _func.D = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result));
                }
            }
        }
        public int IndexC
        {
            get { return _func.IndexC; }
            set
            {
                if (_func.IndexC != value)
                {
                    _func.IndexC = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result));
                }
            }
        }
        public List<int> cmbContent
        {
            get { return _func.C.ToList(); }
        }

        public double Result => _func.Result;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
