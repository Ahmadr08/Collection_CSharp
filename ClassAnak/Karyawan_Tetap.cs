using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Inh_Poly_Abstract_Collection.ClassInduk;

namespace Tugas_Inh_Poly_Abstract_Collection.ClassAnak
{
    public class Karyawan_Tetap : Karyawan
    {
        public override string Nama { get; set; }
        public override string NIK { get; set; }
        public double GajiBulanan { get; set; }
        public override double Gaji ()
        {
            return GajiBulanan;
        }
    }
}
