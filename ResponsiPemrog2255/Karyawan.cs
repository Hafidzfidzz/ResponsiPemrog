using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2255
{
    class Karyawan
    {
        public String Nik, Nama;
        public int GajiBulanan;

        public Karyawan(String nik, String nama, int gaji)
        {

            if (gaji < 0)
            {
                gaji = 0;
            }

            Nik = nik;
            Nama = nama;
            GajiBulanan = gaji;
        }

    }
}
