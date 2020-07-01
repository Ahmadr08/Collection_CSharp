using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection_Part2.ClassInduk;

namespace Collection_Part2.ClassAnak
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