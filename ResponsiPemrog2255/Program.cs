using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2255
{
    class Program
    {
        static void Main(string[] args){
            Karyawan karyawan1 = new Karyawan("18-11-2255", "HAFIDZ TAUFIQ", 10000000);
            Karyawan karyawan2 = new Karyawan("27-05-2000", "MAS PAIJO", 5000000);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1.   {0} {1}     {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2.   {0} {1}     {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine();
            Console.WriteLine();

            karyawan1.GajiBulanan = karyawan1.GajiBulanan * 110 / 100;
            karyawan2.GajiBulanan = karyawan2.GajiBulanan * 110 / 100;

            Console.WriteLine("ASYIIIKK GAJI NAIK 10% !!!");
            Console.WriteLine();
            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1.   {0} {1}     {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2.   {0} {1}     {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.ReadKey();
        }
    }
}

      