using System;

namespace CubeSimulator
{
    public static class Data
    {
        public const double pRedRtoE = 0.06;
        public const double pRedEtoU = 0.02;
        public const double pRedUtoL = 0.006;
        public const double pBlackRtoE = 0.15;
        public const double pBlackEtoU = 0.035;
        public const double pBlackUtoL = 0.014;
        public const double pAdditionalRtoE = 0.048;
        public const double pAdditionalEtoU = 0.02;
        public const double pAdditionalUtoL = 0.005;

        public const int cRedSingle = 1200;
        public const int cRedSix = 1000;
        public const int cRedDoubleSix = 900;
        public const int cBlackSingle = 2200;
        public const int cBlackSix = 11000 / 6;
        public const int cBlackDoubleSix = 1650;
        public const int cAdditionalSingle = 2400;
        public const int cAdditionalSilver = 1980;
        public const int cAdditionalGold = 1890;

        public static double CalcCdf(double p, int n)
        {
            return (1 - Math.Pow((1 - p), n));
        }
    }
}
