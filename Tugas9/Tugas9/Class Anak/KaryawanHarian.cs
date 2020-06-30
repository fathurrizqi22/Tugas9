using System;
using System.Collections.Generic;
using System.Text;
using Tugas9;
using Tugas9.Class_Induk;

namespace Tugas9.Class_Anak
{
    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }

        public override double Gaji()
        {
            return UpahPerJam * JumlahJamKerja;
        }
    }
}