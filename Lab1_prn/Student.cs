using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1_prn
{
    internal class Student
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Major { get; set; }

        List<Student> students;
        public Student()
        {
        }

        public Student(int code, string name, int year, string major)
        {
            Code = code;
            Name = name;
            Year = year;
            Major = major;
        }

        public override string ToString()
        {
            return $"Student: {Code}, {Name}, {Year}, {Major}";
        }

        public void search()
        {
            List<Student> std = new List<Student>
            {
            new Student(8, "Duc Tien", 2002, "AI"),
            new Student(1, "An Thuyen", 2002, "SE"),
            new Student(9, "Thanh Thao", 2002, "SE"),
            new Student(4, "Minh Hieu", 2001, "GD"),
            new Student(5, "truong", 2000, "DIG"),
            new Student(6, "Minh", 1998, "GD"),
            new Student(7, "Hang", 2005, "GD")
            };
            std.Display("List of students: ");
            Console.WriteLine();

            int option;
            do
            {
                Console.WriteLine("1. Tim kiem sinh vien theo code.");
                Console.WriteLine("2. Tim kiem sinh vien theo ten day du.");
                Console.WriteLine("3. Tim kiem sinh vien co chua mot string nao do.");
                Console.WriteLine("4. Tim kiem sinh vien theo nganh hoc.");
                Console.WriteLine("5. Tim kiem sinh vien theo nam sinh.");
                Console.WriteLine("6. Tim kiem sinh vien theo nam sinh va nganh hoc.");
                Console.WriteLine("7. Sap xep sinh vien theo bang chu cai.");
                Console.WriteLine("8. Sap xep sinh vien theo code.");
                Console.WriteLine("0. Exit.");
                Console.Write("Option: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1://
                        Console.Write("Nhap code cua sinh vien: ");
                        int c = int.Parse(Console.ReadLine());
                        Console.Write($"\nSinh vien theo code la {c}: ");
                        std.FirstOrDefault(x => x.Code == c).Display();
                        Console.WriteLine();
                        break;

                    case 2://
                        Console.Write("Nhap ten day du cua sinh vien: ");
                        string y = Console.ReadLine().ToLower();
                        std.Where(x => x.Name.ToLower().Equals(y)).ToList().Display("\nTim sinh vien theo ten: \n");
                        break;

                    case 3://
                        Console.Write("Nhap 1 chuoi bat ki nao do: ");
                        y = Console.ReadLine().ToLower();
                        std.Where(x => x.Name.ToLower().Contains(y)).ToList().Display("\nTim sinh vien co chua mot string nao do: \n");
                        break;

                    case 4://
                        Console.Write("Nhap nganh hoc cua sinh vien: ");
                        y = Console.ReadLine().ToLower();
                        std.Where(x => x.Major.ToLower().Equals(y)).ToList().Display("\nTim sinh vien theo nganh hoc: \n");
                        break;

                    case 5://
                        Console.Write("Nhap nam sinh cua sinh vien: ");
                        int year = int.Parse(Console.ReadLine());
                        std.Where(x => x.Year == year).ToList().Display("\nTim sinh vien theo nam sinh: \n");
                        break;

                    case 6://
                        Console.Write("Nhap nam sinh: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nhap nganh: ");
                        y = Console.ReadLine().ToLower();
                        std.Where(x => x.Year == year && x.Major.ToLower().Equals(y))
                            .ToList().Display("\nTim sinh vien theo nganh hoc va nam sinh: \n");
                        break;

                    case 7:
                        var orderByName = from s in std
                                          orderby s.Name
                                          select s;
                        Console.WriteLine("\nSap xep theo ten sinh vien theo bang chu cai: \n");
                        foreach (var s in orderByName)
                        {
                            Console.WriteLine(s);
                        }
                        break;

                    case 8:
                        //var sortId = from s in std
                        //             orderby s.Code descending
                        //             select s;
                        //Console.WriteLine("\nSap xep theo code sinh vien giam dan: ");
                        //foreach (var s in sortId)
                        //{
                        //    Console.WriteLine(s);
                        //}

                        var find = from s in std
                                   where s.Year % 2 == 0

                                   select s;
                        Console.WriteLine("\nSap xep theo code sinh vien giam dan: ");
                        foreach (var s in find)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Nhap lai");
                        break;
                }
            } while (option <= 8 && option > 0); 
        }
    }
}
