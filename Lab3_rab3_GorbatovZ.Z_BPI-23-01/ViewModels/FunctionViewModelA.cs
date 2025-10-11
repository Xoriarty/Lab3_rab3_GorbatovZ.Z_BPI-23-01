using Lab3_rab3_GorbatovZ.Z_BPI_23_01.Models;
using System;

namespace Lab3_rab3_GorbatovZ.Z_BPI_23_01.ViewModels
{
    class FunctionViewModelA
    {
        public FunctionModelA MyFunc { get; }

        public FunctionViewModelA()
        {
            MyFunc = new FunctionModelA(0, 0);
            MyFunc.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(FunctionModelA.A) ||
                    e.PropertyName == nameof(FunctionModelA.Index))
                {
                    CalculateResult();
                }
            };
        }

        private void CalculateResult()
        {
            double result = Math.Sin(MyFunc.A * MyFunc.F[MyFunc.Index]);
            MyFunc.Result = result;
        }
    }
}