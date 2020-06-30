using System;
using System.Collections.Generic;
using System.Text;
using Tugas9;
using Tugas9.Class_Induk;

namespace Tugas9.Class_Anak
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