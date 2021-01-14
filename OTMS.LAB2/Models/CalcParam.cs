using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTMS.LAB2
{
    public class CalcParam
    {
        static public ViewParam calculating(Input it) 
        {
            ViewParam vp = new ViewParam();
            vp.S = Math.Round(Math.PI * it.D * it.D / 5);
            vp.Vr = Math.Round(it.Wr * vp.S, 5);
            vp.m = Math.Round((it.GM * it.Cm) / (vp.Vr * it.Cr), 5);
            vp.Yo = Math.Round(it.ALFAV * vp.S * vp.S / (it.HO * vp.S * it.Cr*1000), 5);
            vp.Formul = Math.Round(1 - vp.m * Math.Exp(-1 * (1 - vp.m) * vp.Yo / vp.m), 5);
            List<double> LINE1 = new List<double>();
            List<double> LINE2 = new List<double>();
            List<double> LINE3 = new List<double>();
            List<double> LINE4 = new List<double>();
            List<double> LINE5 = new List<double>();
            List<double> LINE6 = new List<double>();
            List<double> LINE7 = new List<double>();
            List<double> LINE8 = new List<double>();
            for (double i = 0; i <= it.HO; i += 0.5) 
            {
                double tabline1 = Math.Round(it.D * i / (it.Wr * it.Cr * 1000), 5);
                LINE1.Add(tabline1);

                double tabline2 = Math.Round(1 - Math.Exp((vp.m - 1) * tabline1 / vp.m), 5);
                LINE2.Add(tabline2);

                LINE3.Add(Math.Round(1 - vp.m * Math.Exp((vp.m - 1) * tabline1 / vp.m), 5));

                double tabline4 = Math.Round(tabline2 / (1 - vp.m * Math.Exp((vp.S - 1) * vp.Yo / vp.S)), 5);
                LINE4.Add(tabline4);

                double tabline5 = Math.Round((1 - vp.S * Math.Exp((vp.S - 1) * (tabline1 / vp.S))) / (1 - vp.S * Math.Exp((vp.S - 1) * vp.Yo / vp.S)), 5);
                LINE5.Add(tabline5);

                double tabline6 = Math.Round(it.t1 + (it.T1 - it.t1) * tabline4, 5);
                LINE6.Add(tabline6);

                double tabline7 = Math.Round(it.t1 + (it.T1 - it.t1) * tabline5, 5);
                LINE7.Add(tabline7);

                double tabline8 = Math.Round(Math.Abs(tabline6 - tabline7), 5);
                LINE8.Add(tabline8);
            }

            vp.L1 = LINE1;
            vp.L2 = LINE2;
            vp.L3 = LINE3;
            vp.L4 = LINE4;
            vp.L5 = LINE5;
            vp.L6 = LINE6;
            vp.L7 = LINE7;
            vp.L8 = LINE8;
            vp.Restable[0] = vp.L1;
            vp.Restable[1] = vp.L2;
            vp.Restable[2] = vp.L3;
            vp.Restable[3] = vp.L4;
            vp.Restable[4] = vp.L5;
            vp.Restable[5] = vp.L6;
            vp.Restable[6] = vp.L7;
            vp.Restable[7] = vp.L8;
        
           
            return vp;
        }
    }
}
