using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionPart2.ClassAnak;
using CollectionPart2.ClassInduk;

namespace CollectionPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih;

            List<Karyawan> listkaryawan = new List<Karyawan>();

            void tambahtetap(string jenis, string nik, string nama, int gajibulanan)
            {
                listkaryawan.Add(new KaryawanTetap { Nama = nama, NIK = nik, Jenis = jenis, GajiBulanan = gajibulanan });
            }

            void tambahharian(string jenis, string nik, string nama, int JmlJamKerja, int UpahPerJam)
            {
                listkaryawan.Add(new KaryawanHarian { Nama = nama, NIK = nik, Jenis = jenis, JmlJamKerja = JmlJamKerja, UpahPerJam = UpahPerJam });
            }

            void tambahsales(string jenis, string nik, string nama, int JmlPenjualan, int Komisi)
            {
                listkaryawan.Add(new Sales { Nama = nama, NIK = nik, Jenis = jenis, JmlPenjualan = JmlPenjualan, Komisi = Komisi });
            }

            void hapus()
            {
                Console.Clear();
                int nik1;
                int noUrut = 1;
                int jumlah = 0;

                foreach (Karyawan karyawan in listkaryawan)
                {
                    Console.WriteLine("{0}. NIK: {1}, \tNama: {2}, \tGaji: {3}, \t{4}", noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji(), karyawan.Jenis);

                    noUrut++;
                    jumlah += 1;
                }
                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(jumlah);
                Console.Write("] : ");
                nik1 = int.Parse(Console.ReadLine());
                nik1 = nik1 - 1;
                listkaryawan.RemoveAt(nik1);
                /*int no = 1;
                int jml_kar = 0;
                foreach (Karyawan karyawan in listkaryawan)
                {
                    Console.WriteLine("{0}. Nik: {1}", no, karyawan.NIK);
                    no++;
                    jml_kar += 1;
                }
                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(jml_kar);
                Console.Write("] : ");
                int index_nik = int.Parse(Console.ReadLine());
                index_nik = index_nik - 1;

                listkaryawan.RemoveAt(index_nik);
                Console.WriteLine();
                Console.WriteLine("Data Berhasil Dihapus ");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                */
            }

            void tampil()
            {
                int no = 1;
                foreach (Karyawan karyawan in listkaryawan)
                {
                    Console.WriteLine("{0}. NIK : {1}, Nama : {2}, Gaji : {3}, {4}",
                    no, karyawan.NIK, karyawan.Nama, karyawan.Gaji(), karyawan.Jenis);

                    no++;
                }
            }
            bool keluar = false;

            while (keluar == false)
            {

                int pilih1, GajiBulanan, JmlJamKerja, UpahPerJam, JmlPenjualan, Komisi;
                string nama, nik, jenis;

                Console.Title = "Tugas Pertemuan 12 -- Inheritance, Polymorphism, Abstraction & Collection Part 2";
                Console.WriteLine("\t============");
                Console.WriteLine("\t| Pilihan Menu |");
                Console.WriteLine("\t| 1. Tambah Data |");
                Console.WriteLine("\t| 2. Hapus Data |");
                Console.WriteLine("\t| 3. Tampilkan Data |");
                Console.WriteLine("\t| 4. Keluar |");
                Console.WriteLine("\t============");
                Console.Write("\n\t Masukkan Pilihan : ");
                pilih = int.Parse(System.Console.In.ReadLine());

                if (pilih == 1)
                {
                    //case 1:

                    //tambah
                    Console.WriteLine("\n\t Tambah Data Karyawan = ");
                    Console.WriteLine("\n\t Jenis Katyawan");
                    Console.WriteLine("\t 1. Karyawan Tetap");
                    Console.WriteLine("\t 2. Karyawan Harian");
                    Console.WriteLine("\t 3. Sales");
                    Console.Write("\n\t Masukkan Pilihan :");
                    pilih1 = int.Parse(System.Console.In.ReadLine());
                    Console.Clear();

                    if (pilih1 == 1)
                    {
                        Console.Write("Nik = ");
                        nik = Console.ReadLine();
                        Console.Write("Nam = ");
                        nama = Console.ReadLine();
                        Console.Write("Gaji Bulanan = ");
                        GajiBulanan = int.Parse(Console.ReadLine());
                        jenis = "Karyawan Tetap";

                        //tambahtetap();
                        tambahtetap(nik, nama, jenis, GajiBulanan);
                    }
                    else if (pilih1 == 2)
                    {
                        Console.Write("Nik = ");
                        nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        nama = Console.ReadLine();
                        Console.Write("Jumlah Jam Kerja = ");
                        JmlJamKerja = int.Parse(Console.ReadLine());
                        Console.Write("Upah Per Jam = ");
                        UpahPerJam = int.Parse(Console.ReadLine());
                        jenis = "Karyawan Harian";

                        //tambahharian();
                        tambahharian(jenis, nik, nama, JmlJamKerja, UpahPerJam);
                    }
                    else if (pilih1 == 3)
                    {

                        Console.Write("Nik = ");
                        nik = Console.ReadLine();
                        Console.Write("Nama = ");
                        nama = Console.ReadLine();
                        Console.Write("Jumlah Jual = ");
                        JmlPenjualan = int.Parse(Console.ReadLine());
                        Console.Write("Komisi = ");
                        Komisi = int.Parse(Console.ReadLine());
                        jenis = "Sales";

                        //tambahsales();
                        tambahsales(jenis, nik, nama, JmlPenjualan, Komisi);
                    }
                    else
                    {
                        Console.WriteLine("Pilihan Tidak Tersedia");
                    }
                }
                //break;

                else if (pilih == 2)
                {
                    //case 2:
                    //hapus
                    hapus();
                    //break;
                }
                else if (pilih == 3)
                {
                    //case 3:
                    //tampil
                    tampil();
                    //break;
                }
                else if (pilih == 4)
                {
                    //case 4:
                    //keluar
                    keluar = true;
                    //break;
                }
                else { 
                    //default:
                    Console.WriteLine("Pilihan tidak tersedia");
                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                    //break;

                }
                Console.ReadLine();
            }
        }
    }
}