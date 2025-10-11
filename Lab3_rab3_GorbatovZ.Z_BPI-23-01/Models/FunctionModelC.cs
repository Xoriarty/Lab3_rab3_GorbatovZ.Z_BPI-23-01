
namespace Lab3_rab3_GorbatovZ.Z_BPI_23_01.Models
{
    public class FunctionModelC : FunctionModel
    {
        private double _a;
        private double _b;
        private int[] _c = new int[2] { 0, 1 };
        private int[] _d = new int[3] { -1, 0, 1 };
        private int _indexC;
        private int _indexD;
        public FunctionModelC(double a, int indexC, int indexD) : base("Resource/img3.png")
        {
            A = a;
            IndexC = indexC;
            IndexD = indexD;
            CalculateResult();
        }

        public double A
        {
            get { return _a; }
            set
            {
                _a = value;
                CalculateResult();
            }
        }
        public int[] C
        {
            get { return _c; }
        }
        public int[] D
        {
            get { return _d; }
        }
        public double B
        {
            get { return _b; }
            set
            {
                _b = value;
                CalculateResult();
            }
        }
        public int IndexC
        {
            get { return _indexC; }
            set
            {
                _indexC = value;
                CalculateResult();
            }
        }
        public int IndexD
        {
            get { return _indexD; }
            set
            {
                _indexD = value;
                CalculateResult();
            }
        }

        public void CalculateResult()
        {
            Result = C[IndexC] * A * A + D[IndexD] * B * B;
        }
    }
}
