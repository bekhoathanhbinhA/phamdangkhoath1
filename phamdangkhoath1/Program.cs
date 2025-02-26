using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phamdangkhoath1
{
    class giangvien


    {
        public string maso { get;set; }
        public string hoten { get; set; }
        public int namsinh { get; set; }
        public giangvien ()
        {
            
        }
        public giangvien (string maso, string hoten, int namsinh)
        {
            maso = maso;
            hoten = hoten;
            namsinh = namsinh;
        }
        public virtual void nhap ()
        {
            Console.WriteLine("nhập mã số giảng viên");
            Console.ReadLine();
            Console.WriteLine("nhập họ tên giảng viên");
            Console.ReadLine();
            Console.WriteLine("nhập năm sinh giảng viên");
            namsinh = int.Parse(Console.ReadLine());

        }
        public virtual int tinhluong()
        {
            return 0;
        }
        class giangvienCH : giangvien
        {
            private float hesoluong;
            public giangvienCH () :base()
            {
                hesoluong = 0;
            }
            public giangvienCH (string maso, string hoten, int namsinh, float hesoluong)
                : base(maso, hoten,namsinh)
            {
                this.hesoluong = hesoluong;
            }
            public float hesoluon
            {
                get { return hesoluong; }
                set { hesoluong = value;  }

            }
            public override void nhap()
            {
                base.nhap();
                Console.Write("nhập hệ số lương");
                hesoluong = float.Parse(Console.ReadLine());
            }
            public override int tinhluong()
            {
                return (int)(hesoluong * 2340000);
            }
            class giangvientg : giangvien
            {
                private int sotietday;
                public giangvientg () : base()
                {
                    sotietday = 0;

                }
                public giangvientg(string maso, string hoten, int namsinh, int sotietday) :base(maso, hoten, namsinh)
                {
                    this.sotietday = sotietday;

                }
                public int SoTietDay
                {
                    get { return sotietday; }
                    set { sotietday = value; }
                }
                public override void nhap()
                {
                    base.nhap();
                    Console.WriteLine("nhập số tiết dạy:");
                    sotietday = int.Parse(Console.ReadLine());
                }
                public override int tinhluong()
                {
                    return base.tinhluong();
                    {
                        return sotietday * 120000;
                    }
                } class program
                {
                    static void main ()
                    {
                        Console.WriteLine("nhập thông tin giảng viên cơ hữu:");
                        giangvienCH gvch = new giangvienCH();
                        gvch.nhap();
                        Console.WriteLine($"lương của giangviên cơ hữu : {gvch.tinhluong():N0} VND");
                        Console.WriteLine("\nhập thông tin của giáo viên thỉnh giảng:");
                        giangvientg gvtg = new giangvientg();
                        gvtg.nhap();
                        Console.WriteLine($"lương của giang viên thịnh giảng : {gvtg.tinhluong():N0} VND");
                    }
                        
                }
            }

        }
        
    }
}
