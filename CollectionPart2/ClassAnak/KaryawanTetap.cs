using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection_Part2.ClassInduk;

namespace Collection_Part2.ClassAnak
{
    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan;
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}