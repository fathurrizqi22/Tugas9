using System;
using System.Collections.Generic;
using System.Text;
using Tugas9;
using Tugas9.Class_Induk;

namespace Tugas9.Class_Anak
{
    public class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }

        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}