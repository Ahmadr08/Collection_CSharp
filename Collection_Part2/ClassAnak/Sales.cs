using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionPart2.ClassInduk;

namespace CollectionPart2.ClassAnak
{
    public class Sales : Karyawan
    {
        public double JmlPenjualan;
        public double Komisi;
        public override double Gaji()
        {
            return JmlPenjualan * Komisi;
        }
    }
}