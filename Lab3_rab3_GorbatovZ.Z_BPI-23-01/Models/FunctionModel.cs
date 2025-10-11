using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab3_rab3_GorbatovZ.Z_BPI_23_01.Models
{
    public abstract class FunctionModel : INotifyPropertyChanged
    {
        private string _path;
        private double _result;
        public FunctionModel(string path)
        {
            Path = path;
        }
        public string Path
        {
            get { return _path; }
            set
            { _path = value; }
        }
        public double Result
        {
            get { return _result; }
            set
            { 
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

