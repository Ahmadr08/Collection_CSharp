using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionPart2.ClassInduk;

namespace CollectionPart2.ClassAnak
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