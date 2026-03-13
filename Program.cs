using System;
using tpmodul4_103082400039;

namespace tpmodul3_103082400039
{
    class Program
    {
        static void Main(string[] args)
        {
            //kodePos kode = new kodePos();

            //Console.Write("Masukkan kelurahan: ");
            //string kelurahan = Console.ReadLine();

            //string hasil = kode.getKodePos(kelurahan);

            //Console.WriteLine("Kode Pos: " + hasil);

            // TABLE DRIVEN
            kodePos kode = new kodePos();

            Console.Write("Masukkan kelurahan: ");
            string kelurahan = Console.ReadLine();

            Console.WriteLine("Kode Pos: " + kode.getKodePos(kelurahan));

            Console.WriteLine();

            // STATE BASE          
            doorMachine pintu = new doorMachine();

            pintu.bukaPintu();
            pintu.kunciPintu();
 
        }
    }
}