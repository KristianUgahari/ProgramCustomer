using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar");
            // TODO: tuliskan logika Anda di sini ...

        }

        static void TambahCustomer()
        {
            Customer Tmb = new Customer();

            Console.Clear();
            Console.Write("Kode Customer : ");
            Tmb.KodeCustomer = Console.ReadLine();
            Console.Write("Nama Customer : ");
            Tmb.NamaCustomer = Console.ReadLine();
            Console.Write("Total Piutang : ");
            Tmb.TotalPiutang = Console.ReadLine();

            daftarCustomer.Add(Tmb);
            // TODO: tuliskan logika Anda di sini ...

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Customer");
            Console.WriteLine();
            Console.Write("Kode Customer : ");
            string search = Console.ReadLine();
			
			int index = 0;
            foreach(Customer Tmb in daftarCustomer)
            {
                if(Tmb.KodeCustomer == search)
                {
                    Console.WriteLine("Kode Customer Berhasil Di Hapus");
                    break;
                }
                else if(Tmb.KodeCustomer != search)
                {
                    Console.WriteLine("Kode Customer Tidak Ditemukan");
                    break;
                }
				index++;
                
               
            }
            daftarCustomer.RemoveAt(index);
            // TODO: tuliskan logika Anda di sini ...

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();
            int index = 0;
            foreach (Customer Tmb in daftarCustomer)
            {
                Console.WriteLine("{0}. {1}, {2}, {3} ",index+1, Tmb.KodeCustomer, Tmb.NamaCustomer, Tmb.TotalPiutang);
                index++;
            }
            // TODO: tuliskan logika Anda di sini ...

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
