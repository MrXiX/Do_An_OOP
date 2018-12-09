using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Đồ_Án_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyNhanVat lienminh = new QuanLyNhanVat();
            do
            {
                Console.Clear();
                InMenu();
                Console.WriteLine("Chon thao tac:");
                int chon;
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        lienminh.XuatListNhanVat();
                        break;
                    case 1:

                        Console.WriteLine("Chon cach nhap:");
                        Console.WriteLine("1.Nhap tu file (Khuyen khich).");
                        Console.WriteLine("2.Nhap tren man hinh Console.");
                        int c = int.Parse(Console.ReadLine());
                        if (c == 1)
                        {
                            lienminh.NhapfileNhanVat();
                            Console.WriteLine("Thanh cong!");
                            break;
                        }
                        if (c == 2)
                        {
                            lienminh.Nhap();
                            break;
                        }
                        Console.WriteLine("Ban chon sai!");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Chon cach nhap:");
                        Console.WriteLine("1.Nhap tu file (Khuyen khich).");
                        Console.WriteLine("2.Nhap tren man hinh Console.");

                        int c2 = int.Parse(Console.ReadLine());
                        if (c2 == 1)
                        {
                            lienminh.NhapfileKyNang();
                            Console.WriteLine("Thanh cong!");
                            break;
                        }
                        if (c2 == 2)
                        {
                            lienminh.NhapListKyNang();
                            break;
                        }
                        Console.WriteLine("Ban chon sai!");
                        Console.ReadKey();
                        break;
                    case 3:


                        Console.WriteLine("Chon cach nhap:");
                        Console.WriteLine("1.Nhap tu file (Khuyen khich).");
                        Console.WriteLine("2.Nhap tren man hinh Console.");

                        int c3 = int.Parse(Console.ReadLine());
                        if (c3 == 1)
                        {
                            lienminh.NhapfileTrangBi();
                            Console.WriteLine("Thanh cong!");
                            break;
                        }
                        if (c3 == 2)
                        {
                            lienminh.NhapListTrangBi();
                            break;
                        }
                        Console.WriteLine("Ban chon sai!");
                        Console.ReadKey();
                        break;
                    case 4:
                        lienminh.SapXepQuickSort();
                        Console.WriteLine("Sap xep thanh cong!");
                        break;
                    case 5:
                        string s = Console.ReadLine();
                        lienminh.TimTenNV(s);
                        break;
                    case 6:
                        int level = int.Parse(Console.ReadLine());
                        lienminh.TimLevel(level);
                        break;
                    case 7:
                        lienminh.TimLevelMax();
                        break;
                    case 8:
                        lienminh.TimLevelMin();
                        break;
                    case 9:
                        Console.WriteLine("Chon thao tac:");
                        Console.WriteLine("1.Doi ten Nhan vat.");
                        Console.WriteLine("2.Doi level Nhan vat.");
                        int c9 = int.Parse(Console.ReadLine());
                        if (c9 == 1)
                        {
                            lienminh.XuatCB();
                            Console.WriteLine("Chon STT nhan vat:");
                            int stt = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap ten thay the:");
                            string ten = Console.ReadLine();
                            lienminh.ThayDoiTen(stt, ten);
                            Console.WriteLine("Thay doi thanh cong!");
                            break;
                        }

                        if (c9 == 2)
                        {
                            lienminh.XuatCB();
                            Console.WriteLine("Chon STT nhan vat:");
                            int stt = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap level thay the:");
                            int lv = int.Parse(Console.ReadLine());
                            lienminh.ThayDoiLevel(stt, lv);
                            Console.WriteLine("Thay doi thanh cong!");
                            break;
                        }

                        Console.WriteLine("Ban chon sai!!!");
                        break;

                    default:
                        {
                            Console.WriteLine("Ban chon sai!");
                            break;
                        }
                }

                Console.WriteLine("Nhan ESC de thoat!!!");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static void InMenu()
        {
            Console.WriteLine("1.Nhap danh sach nhan vat.");
            Console.WriteLine("2.Nhap danh sach ky nang.");
            Console.WriteLine("3.Nhap danh sach trang bi.");
            Console.WriteLine("4.Sap xep Nhan vat.");
            Console.WriteLine("5.Tim nhan vat theo ten.");
            Console.WriteLine("6.Tim nhan vat theo Level");
            Console.WriteLine("7.Tim Nhan vat Level cao nhat.");
            Console.WriteLine("8.Tim Nhan vat Level thap nhat.");
            Console.WriteLine("9.Chinh sua Thong tin Nhan vat.");
            Console.WriteLine("0.Xuat danh sach nhan vat.");
        }

    }
}
