using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTMS.LAB2
{
    public class ViewParam
    {
        public double S { get; set; }
        public double Vr { get; set; }
        public double m { get; set; }
        public double Yo { get; set; }
        public double Formul { get; set; }

        public List<double> L1 { get; set; }
        public List<double> L2 { get; set; }
        public List<double> L3 { get; set; }
        public List<double> L4 { get; set; }
        public List<double> L5 { get; set; }
        public List<double> L6 { get; set; }
        public List<double> L7 { get; set; }
        public List<double> L8 { get; set; }

        public List<double>[] Restable = new List<double>[8];
    }
}
