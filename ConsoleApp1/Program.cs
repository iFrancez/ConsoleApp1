//crtl+c thoat khoi chuong trinh khi dang chay
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] agrs)
        {

            Console.Write("Nhap ho va ten: ");
            /*
            Luong    TRAn Ngoc    Khiet  
            */
            string hoten = Console.ReadLine();
            Console.WriteLine("Ten viet dung:" + getHT(hoten));
            Console.ReadKey();
        }
        static string getHT(string s)
        {
            string output= "";
            List<string> lst = s.ToLower().Split(' ').Where(p => p != "").ToList();
            //ten dep day du
            //for(int i=0;i<lst.Count;i++)
            //{
            //    lst[i] = lst[i][0].ToString().ToUpper() + lst[i].Substring(1, lst[i].Length-1);
            //}
            //output = string.Join(" ", parts);
            //return output;
            //theo de
            string email = "";
            for (int i = 0; i < lst.Count-1; i++)
            {
                email += lst[i][0].ToString().ToUpper();
            }
            email = lst[lst.Count - 1] + email;
            return email;
        }
        static void MinmaxSumg()
        {
            List<int> Isinput = new List<int>();
            Random rd = new Random();
            Console.WriteLine("Nhap so luong n =");
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Isinput.Add(rd.Next(10, 99));
            }
            //xuat mang
            Console.WriteLine(string.Join(" ", Isinput));
            //tinh tong
            Console.WriteLine("Tong la " + Isinput.Sum());
            Console.WriteLine("Min = " + Isinput.Min());
            Console.WriteLine("Max = " + Isinput.Max());
        }
        static void Ptbac1()
        {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Nhap he so phuong trinh ax+b=0");
                double a, b;
                int count = 3;
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    count--;
                    if (count == 0) return;
                    Console.WriteLine("Input is not in double format. Try again!");
                }
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Input is not in double format. Try again!");
                }
                //kiem tra gia tri
                //case a=0 b=0 => vo so nghiem x
                if (a == 0 && b == 0) Console.WriteLine("Vo so nghiem x");
                //case a=0 b!=0 =>vo nghiem x
                if (a == 0 && b != 0) Console.WriteLine("Vo nghiem x");
                //case a#0 =>x=-b/a (b=0 => x=0)
                if (a != 0) Console.WriteLine("Co nghiem la " + (-b / a));
                Console.ReadKey();
            }   
    }
}
