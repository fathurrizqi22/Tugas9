using System;
using System.Collections.Generic;
using System.Threading;
using Tugas9.Class_Anak;
using Tugas9.Class_Induk;


namespace Tugas9
{
    class Program
    {
        static void Main()
        {
            List<Karyawan> karyawan = new List<Karyawan>();

            Pilih(karyawan);
        }

        static void Pilih(List<Karyawan> karyawan)
        {
            bool status = true;

            while (status == true)
            {
                Console.Clear();
                Console.WriteLine("Menu Utama : ");
                Console.WriteLine("[1]. Tambah Data\n[2]. Hapus Data \n[3]. Tampilkan Data \n[4]. Keluar\n");
                Console.WriteLine("Masukkan Pilihan anda[1-4]: ");
                int pil = int.Parse(Console.ReadLine());

                switch (pil)
                {
                    case 1:
                        {
                            TambahData(karyawan);
                            BackToMainMenu();
                            break;
                        }
                    case 2:
                        {
                            HapusData(karyawan);
                            BackToMainMenu();
                            break;
                        }
                    case 3:
                        {
                            TampilData(karyawan);
                            BackToMainMenu();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Exit. ");
                            Thread.Sleep(500);
                            status = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Pilihan tidak ada, silahkan masukkan pilihan lain.\nPress any button");
                            Console.ReadKey();
                            Pilih(karyawan);
                            break;
                        }
                }

            }
        }


        static void TambahData(List<Karyawan> karyawan)
        {
            Console.Clear();
            Console.WriteLine("=======Menu tambah karyawan=========");
            Console.WriteLine("\nPilih tipe karyawan: ");
            Console.WriteLine("[1] Karywan Tetap \n[2] Karyawan Harian \n[3] Sales");

            Console.WriteLine("Masukkan Pilihan Anda [1-3]: ");
            int pil = int.Parse(Console.ReadLine());

            switch (pil)
            {
                case 1:
                    {
                        KaryawanTetap karyawanTetap = new KaryawanTetap();
                        Console.WriteLine("\nTambah karyawan tetap");

                        Console.Write("Masukkan NIK \t\t\t: ");
                        karyawanTetap.Nik = Console.ReadLine();

                        Console.WriteLine("Masukkan Nama \t\t\t: ");
                        karyawanTetap.Nama = Console.ReadLine();

                        Console.Write("Masukkan gaji bulanan \t\t\t: ");
                        karyawanTetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());

                        karyawan.Add(karyawanTetap);
                        break;
                    }

                case 2:
                    {
                        KaryawanHarian karyawanHarian = new KaryawanHarian();
                        Console.WriteLine("Tambah karyawan harian");

                        Console.Write("Masukkan NIK \t\t\t: ");
                        karyawanHarian.Nik = Console.ReadLine();

                        Console.Write("Masukkan Nama \t\t\t: ");
                        karyawanHarian.Nama = Console.ReadLine();

                        Console.Write("Masukkan upah perjam \t\t\t: ");
                        karyawanHarian.UpahPerJam = Convert.ToDouble(Console.ReadLine());


                        Console.Write("Masukkan jam kerja \t\t\t: ");
                        karyawanHarian.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());

                        karyawan.Add(karyawanHarian);
                        break;

                    }

                case 3:
                    {
                        Sales sales = new Sales();
                        Console.WriteLine("Tambah sales");

                        Console.Write("Masukkan NIK \t\t\t: ");
                        sales.Nik = Console.ReadLine();

                        Console.Write("Masukkan Nama \t\t\t: ");
                        sales.Nama = Console.ReadLine();

                        Console.Write("Masukkan Jumlah penjualan \t: ");
                        sales.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());


                        Console.Write("Masukkan komisi \t\t\t: ");
                        sales.Komisi = Convert.ToDouble(Console.ReadLine());

                        karyawan.Add(sales);
                        break;

                    }

                default:
                    {
                        Console.WriteLine("Pilihan tidak ada, silahkan masukan pilihan lain.\nPress any button");
                        Console.ReadKey();
                        TambahData(karyawan);
                        break;
                    }
            }
        }

        static void HapusData(List<Karyawan> karyawan)
        {
            bool ditemukan = true;

            TampilData(karyawan);
            Console.WriteLine("\nMasukan NIK yang ingin dihapus: ");
            string nik = Console.ReadLine();

            for (int i = 0; i < karyawan.Count; i++)
            {
                if (karyawan[i].Nik == nik)
                {
                    karyawan.Remove(karyawan[i]);
                    ditemukan = true;
                    break;
                }

                else
                {
                    ditemukan = false;
                }
            }

            switch (ditemukan)
            {
                case true:
                    Console.WriteLine("\nData dengan NIK = \"{0}\" berhasil dihapus", nik);
                    break;

                case false:
                    Console.WriteLine("\nData dengan NIK = \"{0}\" Tidak ditemukan", nik);
                    break;
            }

        }

        static void TampilData(List<Karyawan> karyawan)
        {
            Console.Clear();

            Console.WriteLine("=======DATA KARYAWAN======");
            Console.WriteLine("===================================================================================");
            Console.WriteLine(string.Format("| {0,-3} | {1,-15} | {2,-30} | {3,-24} |", "NO", "NIK", "NAMA", "GAJI"));
            Console.WriteLine("===================================================================================");
            for (int i = 0; i < karyawan.Count; i++)
            {
                Console.WriteLine(string.Format("| {0,-3} | {1,-15} | {2,-30} | {3,-3} | {4,-20} |", i + 1, karyawan[i].Nik, karyawan[i].Nama, "Rp.", karyawan[i].Gaji()));
            }
        }


        static void BackToMainMenu()
        {
            Console.WriteLine("\nPress any key to back to main menu.");
            Console.ReadKey();
        }
    }

}