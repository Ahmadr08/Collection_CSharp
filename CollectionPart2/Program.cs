using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection_Part2.ClassAnak;
using Collection_Part2.ClassInduk;

namespace Collection_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih, pilih1;

            List<Karyawan> listkaryawan = new List<Karyawan>();

            void tambahtetap(string jenis, string nik, string nama, int gajibulanan)
            {
                listkaryawan.Add(new KaryawanTetap { Jenis = jenis, NIK = nik, Nama = nama, GajiBulanan = gajibulanan });
            }

            void tambahharian(string jenis, string nik, string nama, int JmlJamKerja, int UpahPerJam)
            {
                listkaryawan.Add(new KaryawanHarian { Jenis = jenis, NIK = nik, Nama = nama, JmlJamKerja = JmlJamKerja, UpahPerJam = UpahPerJam });
            }

            void tambahsales(string jenis, string nik, string nama, int JmlPenjualan, int Komisi)
            {
                listkaryawan.Add(new Sales { Jenis = jenis, NIK = nik, Nama = nama, JmlPenjualan = JmlPenjualan, Komisi = Komisi });
            }

            void hapus()
            {
                int no = 1;
                int jml_kar = 0;

                foreach (Karyawan karyawan in listkaryawan)
                {
                    Console.WriteLine("\t{0}. Nik: {1}", no, karyawan.NIK);
                    no++;
                    jml_kar += 1;
                }

                Console.WriteLine();
                Console.Write("\tPilih Data Yang Ingin Dihapus [1-");
                Console.Write(jml_kar);
                Console.Write("] : ");
                int index = int.Parse(Console.ReadLine());
                index = index - 1;
                
                listkaryawan.RemoveAt(index);
                Console.WriteLine("\n\tData Berhasil Dihapus ");
                Console.WriteLine("\n\tTekan Enter Untuk Kembali ke Menu");
                Console.ReadLine();
                Console.Clear();
            }

            void tampil()
            {
                int no = 1;
                foreach (Karyawan karyawan in listkaryawan)
                {
                    Console.WriteLine("\n\t{0}. NIK: {1}, \tNama: {2}, \tGaji: {3}, \t{4}", no, karyawan.NIK, karyawan.Nama, karyawan.Gaji(), karyawan.Jenis);

                    no++;
                }
                Console.WriteLine("\n\tTekan Enter Untuk Kembali ke Menu");
                Console.ReadLine();
                Console.Clear();
            }
            bool keluar = false;

            while (keluar == false)
            {
                Console.Title = "Tugas Pertemuan 12 -- Inheritance, Polymorphism, Abstraction & Collection Part 2";
                Console.WriteLine("\n\t=======================");
                Console.WriteLine("\t|     Pilihan Menu    |");
                Console.WriteLine("\t=======================");
                Console.WriteLine("\t|  1. Tambah Data     |");
                Console.WriteLine("\t|  2. Hapus Data      |");
                Console.WriteLine("\t|  3. Tampilkan Data  |");
                Console.WriteLine("\t|  4. Keluar          |");
                Console.WriteLine("\t=======================");
                Console.Write("\t Masukkan Pilihan : ");
                pilih = int.Parse(System.Console.In.ReadLine());
                Console.Clear();

                if (pilih == 1)
                {
                    //case 1:
                    int GajiBulanan, JmlJamKerja, UpahPerJam, JmlPenjualan, Komisi;
                    string nama, nik, jenis;

                    //tambah
                    Console.WriteLine("\n\t========================");
                    Console.WriteLine("\t| Tambah Data Karyawan |");
                    Console.WriteLine("\t========================");
                    Console.WriteLine("\t   1. Karyawan Tetap   ");
                    Console.WriteLine("\t   2. Karyawan Harian   ");
                    Console.WriteLine("\t   3. Sales");
                    Console.WriteLine("\t========================");
                    Console.Write("\n\t Masukkan Pilihan : ");
                    pilih1 = int.Parse(System.Console.In.ReadLine());

                    if (pilih1 == 1)
                    {
                        Console.Write("\n\tNIK = ");
                        nik = Console.ReadLine();
                        Console.Write("\tNama = ");
                        nama = Console.ReadLine();
                        Console.Write("\tGaji Bulanan = ");
                        GajiBulanan = int.Parse(Console.ReadLine());
                        jenis = "\tKaryawan Tetap";
                        
                        //tambahtetap();
                        tambahtetap(jenis, nik, nama, GajiBulanan);
                        Console.WriteLine("\n\tTekan Enter Untuk Kembali ke Menu");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (pilih1 == 2)
                    {
                        Console.Write("\n\tNIK = ");
                        nik = Console.ReadLine();
                        Console.Write("\tNama = ");
                        nama = Console.ReadLine();
                        Console.Write("\tJumlah Jam Kerja = ");
                        JmlJamKerja = int.Parse(Console.ReadLine());
                        Console.Write("\tUpah Per Jam = ");
                        UpahPerJam = int.Parse(Console.ReadLine());
                        jenis = "\tKaryawan Harian";

                        //tambahharian();
                        tambahharian(jenis, nik, nama, JmlJamKerja, UpahPerJam);
                        Console.WriteLine("\n\tTekan Enter Untuk Kembali ke Menu");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (pilih1 == 3)
                    {
                        Console.Write("\n\tNIK = ");
                        nik = Console.ReadLine();
                        Console.Write("\tNama = ");
                        nama = Console.ReadLine();
                        Console.Write("\tJumlah Jual = ");
                        JmlPenjualan = int.Parse(Console.ReadLine());
                        Console.Write("\tKomisi = ");
                        Komisi = int.Parse(Console.ReadLine());
                        jenis = "\tSales";

                        //tambahsales();
                        tambahsales(jenis, nik, nama, JmlPenjualan, Komisi);
                        Console.WriteLine("\n\tTekan Enter Untuk Kembali ke Menu");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\n\tPilihan Tidak Tersedia");
                        Console.WriteLine("\tTekan Enter Untuk Kembali ke Menu");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (pilih == 2)
                {
                    hapus();
                }
                else if (pilih == 3)
                {
                    tampil();
                }
                else if (pilih == 4)
                {
                    keluar = true;
                }
                else {
                    Console.WriteLine("Pilihan tidak tersedia");
                }
                Console.ReadLine();
            }
        }
    }
}