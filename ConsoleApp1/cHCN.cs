using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class cHCN
    {
        private double Dai, Rong;

        public cHCN(double dai=0, double rong=0)
        {
            Dai = dai;
            Rong = rong;
        }
        //tao region xac dinh vung xu ly code
        #region Properties
        public double Dai1 { get => Dai; set => Dai = value; }
        public double Rong1 { get => Rong; set => Rong = value; }
        public double CV { get => (Rong+Dai)*2; }
        public double DT { get => (Rong * Dai); }
        #endregion
        public override string ToString()
        {
            return String.Format("{0}:{1}",Dai,Rong);
        }
    }
}
