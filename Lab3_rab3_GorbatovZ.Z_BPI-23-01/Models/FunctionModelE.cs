using System;

namespace Lab3_rab3_GorbatovZ.Z_BPI_23_01.Models
{
    public class FunctionModelE : FunctionModel
    {
        private double _x;
        private double _y;
        private int _n;
        private int _k;
        public FunctionModelE(double x, double y, int n, int k) : base("Resource/img5.png")
        {
            X = x;
            Y = y;
            N = n;
            K = k;
            CalculateResult();
        }

        public double X
        {
            get { return _x; }
            set
            {
                _x = value;
                CalculateResult();
            }
        }
        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                CalculateResult();
            }
        }
        public int N
        {
            get { return _n; }
            set
            {
                _n = value;
                CalculateResult();
            }
        }
        public int K
        {
            get { return _k; }
            set
            {
                _k = value;
                CalculateResult();
            }
        }

        public void CalculateResult()
        {
            double SumN = 0;
            for (int i = 1; i <= N; i++)
            {
                double SumK = 0;
                for (int j = 1; j <= K; j++) SumK += (Math.Sin(X) * Math.Pow(X, i) + Math.Cos(Y) * Math.Pow(Y, i)) / (i * j);
                SumN += SumK;
            }
            Result = SumN;
        }
    }
}
