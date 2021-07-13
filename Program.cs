using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<string> daftarPenjualan = new List<string>();

        static void Main(string[] args)
        {
            Penjualan saya = new Penjualan();
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            
            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }

            void TampilMenu()
            {
                Console.Clear();

                // Kode untuk menampilkan menu
                Console.WriteLine("1. Tambah Penjualan");
                Console.WriteLine("2. Hapus Penjualan");
                Console.WriteLine("3. Tampilkan Penjualan");
                Console.WriteLine("4. Keluar");

                Console.ReadKey();
            }

            void TambahPenjualan()
            {
                Console.Clear();

                // Kode untuk menambahkan penjualan ke dalam collection
                Console.WriteLine("Tambah Data Penjualan\n");
                Console.Write("Nota : ");
                saya.nota = Convert.ToString(Console.ReadLine());
                Console.Write("Tanggal : ");
                saya.tanggal = Convert.ToString(Console.ReadLine());
                Console.Write("Customer : ");
                saya.customer = Convert.ToString(Console.ReadLine());
                Console.Write("Jenis : ");
                saya.jenis = Convert.ToString(Console.ReadLine());
                Console.Write("Total nota : ");
                saya.totalNota = Convert.ToString(Console.ReadLine());

                Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
                Console.ReadKey();
            }

            void HapusPenjualan()
            {
                Console.Clear();

                // Kode untuk menghapus penjualan dari dalam collection
                Console.WriteLine("Hapus Data Penjualan\n");
                Console.Write("Nota : ");
                saya.nota = Convert.ToString(Console.ReadLine());

                if (saya.nota != saya.nota)
                {
                    Console.WriteLine("Nota tidak ditemukan");
                }
                else
                    Console.WriteLine("Data berhasil dihapus");


                Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
                Console.ReadKey();
            }

            void TampilPenjualan()
            {
                Console.Clear();
                // Kode untuk menampilkan daftar penjualan yang ada di dalam collection
                Console.WriteLine("Tampil Data Penjualan\n");

                // Membuat objek list
                List<Penjualan> list = new List<Penjualan>();
                list.Add(saya);
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}",saya.nota, saya.tanggal, saya.customer, saya.jenis, saya.totalNota);
                
                Console.WriteLine("\nTekan enter untuk kembali ke menu");
                Console.ReadKey();
            }
        }

    }
}
