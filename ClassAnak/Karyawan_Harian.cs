using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Inh_Poly_Abstract_Collection.ClassInduk;

namespace Tugas_Inh_Poly_Abstract_Collection.ClassAnak
{
    class Karyawan_Harian : Karyawan
    {
        public override string Nama { get; set; }
        public override string NIK { get; set; }
        public double JmlJamKerja { get; set; }
        public double UpahPerJam { get; set; }
        public override double Gaji()
        {
            return JmlJamKerja * UpahPerJam;
        }
    }
}
