using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapTrenLop
{
    internal class BaiTapLop
    {
        //Họ và tên:Phan Mai Hoai Nhi
        //MSSV: 22115141122112
        public static void ChayChuongTrinh()
        {
            Random rd = new Random();
            string[] khoa = { "Cong nghe so", "Co Khi", "Dien tu " };
            List<Student> students = new List<Student>();

            for (int i = 1; i <= 10; i++)
            {
                students.Add(new Student()
                {
                    Id = i,
                    Ten = "SV" + i,
                    Tuoi = rd.Next(18, 25).ToString(),
                    Khoa = khoa[rd.Next(khoa.Length)],
                    Diem = Math.Round(rd.NextDouble() * 10, 2)
                });
            }
            Console.WriteLine("Danh sach sinh vien:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Ten: {student.Ten}, Tuoi: {student.Tuoi}, Khoa: {student.Khoa}, Diem: {student.Diem}");
            }
            Console.WriteLine("Tuoi lon nhat va nho nhat");
            Console.WriteLine("Tuoi lon nhat: " + students.Max(s => s.Tuoi));
            Console.WriteLine("Tuoi nho nhat: " + students.Min(s => s.Tuoi));
            Console.WriteLine("Sinh vien Khoa Cong nghe so:");
            var sv_CNS = students.Where(student => student.Khoa == "Cong Nghe So");

            Console.WriteLine("Top 10 sinh vien diem tb cao nhat:");
            var top10 = students.OrderByDescending(s => s.Diem).Take(10);
            foreach(var s in top10)
            {
                Console.WriteLine($"Id: {s.Id}, Ten: {s.Ten}, Tuoi: {s.Tuoi}, Khoa: {s.Khoa}, Diem: {s.Diem}");
            }

            Console.WriteLine("\n4. Bo qua 5 SV diem cao nhat, lay 5 SV tiep:");
            var top5 = students.OrderByDescending(s => s.Diem).Skip(5).Take(5);
                        foreach(var s in top5)
            {
                Console.WriteLine($"Ten: {s.Ten}, Diem: {s.Diem}");
            }
        }
    }
}
