using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Inh_Poly_Abstract_Collection.ClassAnak;
using Tugas_Inh_Poly_Abstract_Collection.ClassInduk;

namespace Tugas_Inh_Poly_Abstract_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Pertemuan 11 -- Inheritance, Polymorphism, Abstraction & Collection";
            Console.WriteLine("Tugas Collection");
            Console.WriteLine("");

            //membuat objek karyawan
            Karyawan_Tetap karyawantetap = new Karyawan_Tetap();
            karyawantetap.NIK = "123-345-567";
            karyawantetap.Nama = "John Krasinski";
            karyawantetap.GajiBulanan = 5000000;

            Karyawan_Harian karyawanharian = new Karyawan_Harian();
            karyawanharian.NIK = "123-321-346";
            karyawanharian.Nama = "Hakim Werner";
            karyawanharian.JmlJamKerja = 8;
            karyawanharian.UpahPerJam = 15000;

            Sales sales = new Sales();
            sales.NIK = "123-333-347";
            sales.Nama = "Timo Ziyech";
            sales.JmlPenjualan = 30;
            sales.Komisi = 50000;

            //objek class collection
            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int no = 1;
            
            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. NIK : {1}, Nama : {2}, Gaji : {3:N0}",
                no, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                no++;
            }
            Console.ReadKey();

        }
    }
}
