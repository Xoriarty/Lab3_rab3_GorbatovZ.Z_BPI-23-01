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
    class FunctionViewModelC : INotifyPropertyChanged
    {
        private FunctionModelC _func;

        public FunctionViewModelC()
        {
            _func = new FunctionModelC(0, 0, 0);
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
        public double B
        {
            get { return _func.B; }
            set
            {
                if (_func.B != value)
                {
                    _func.B = value;
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
        public List<int> cmbContentC
        {
            get { return _func.C.ToList(); }
        }

        public int IndexD
        {
            get { return _func.IndexD; }
            set
            {
                if (_func.IndexD != value)
                {
                    _func.IndexD = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result));
                }
            }
        }
        public List<int> cmbContentD
        {
            get { return _func.D.ToList(); }
        }

        public double Result => _func.Result;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
