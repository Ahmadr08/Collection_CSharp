using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionPart2.ClassInduk;

namespace CollectionPart2.ClassAnak
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