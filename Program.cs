using System;
using tpmodul4_103082400039;

namespace tpmodul3_103082400039
{
    class Program
    {
        static void Main(string[] args)
        {
            kodePos kode = new kodePos();

            Console.Write("Masukkan kelurahan: ");
            string kelurahan = Console.ReadLine();

            string hasil = kode.getKodePos(kelurahan);

            Console.WriteLine("Kode Pos: " + hasil);
        }
    }
}