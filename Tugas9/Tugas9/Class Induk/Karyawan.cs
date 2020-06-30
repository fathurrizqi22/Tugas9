using System;
using System.Collections.Generic;
using System.Text;
using Tugas9;

namespace Tugas9.Class_Induk
{
    public abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
}