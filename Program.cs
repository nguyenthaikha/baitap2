using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC 1: ax + b = 0 ===");

            // 1. Nhập và chuyển đổi kiểu dữ liệu cho hệ số a
            Console.Write("Nhập hệ số a: ");
            double a = double.Parse(Console.ReadLine());

            // 2. Nhập và chuyển đổi kiểu dữ liệu cho hệ số b
            Console.Write("Nhập hệ số b: ");
            double b = double.Parse(Console.ReadLine());

            // 3. Rẽ nhánh xử lý các trường hợp của phương trình
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"Phương trình có nghiệm x = {x}");
            }
        }
    }
}
