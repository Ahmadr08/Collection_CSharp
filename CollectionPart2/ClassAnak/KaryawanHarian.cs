using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection_Part2.ClassInduk;

namespace Collection_Part2.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {
        public double JmlJamKerja;
        public double UpahPerJam;
        public override double Gaji()
        {
            return JmlJamKerja * UpahPerJam;
        }
    }
}