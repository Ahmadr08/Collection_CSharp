using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Inh_Poly_Abstract_Collection.ClassInduk
{
    public abstract class Karyawan
    {
        public abstract string Nama { get; set; }
        public abstract string NIK { get; set; }
        public abstract double Gaji();
    }
}
