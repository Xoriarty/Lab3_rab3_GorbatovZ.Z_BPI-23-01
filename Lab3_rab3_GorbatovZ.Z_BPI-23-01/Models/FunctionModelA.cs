using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace Lab3_rab3_GorbatovZ.Z_BPI_23_01.Models
{
    public class FunctionModelA : FunctionModel
    {
        private double _a;
        private int[] _f = new int[6] { 4, 5, 6, 7, 8, 9 };
        private int _index;
        public FunctionModelA(double a, int index) : base("Resource/img1.png")
        {
            A = a;
            Index = index;
        }
        public double A
        {
            get { return _a; }
            set
            {
                _a = value;
                OnPropertyChanged(nameof(A));

            }
        }
        public List<int> F
        {
            get { return _f.ToList(); }
        }
        public int Index
        {
            get { return _index; }
            set
            {
                _index = value;
                OnPropertyChanged(nameof(Index));
            }
        }
    }
}
