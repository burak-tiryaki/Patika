//using System;
namespace Csharp;
class Program
{
    static void Main(string[] args)
    {
        byte a=1;
        sbyte b=2;

        short c=3;
        ushort d=4;

        Int16 i1 = 1;
        int i2 = 2;
        Int32 i3= 3;
        Int64 i4= 4;
        uint i5 = 5;

        long l1 = 6;
        ulong l2 = 7;

        float f1 = 8;
        double d1 = 9.1;
        decimal de = 10;

        char tek = 'Y';
        string str = "burak";

        bool T = true;
        
        DateTime dt = DateTime.Now;

        object o1 = "sting";
        object o2 = 'C';
        object o3 = 4;
        object o4 = 4.5;

        string str1 = string.Empty;  // Boş tanımlamak için.
        string ad = "Burak";
        string soyad = "Tiryaki";
        string tamIsim =ad + " " + soyad;  // string birleştirme.

        int ii1 =1;
        int ii2 =2;
        int ii3 = ii1 + ii2;

        bool bool1= true;

        string str20="20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString();
        System.Console.WriteLine(yeniDeger);

        int intDeger = int20 + Convert.ToInt32(str20);
        System.Console.WriteLine(intDeger);

        int int22 = int20 + int.Parse(str20);
        System.Console.WriteLine(int22);

        string dt2 = DateTime.Now.ToString("dd.MM.yyyy");
        System.Console.WriteLine(dt2);

        string dt3 = DateTime.Now.ToString("dd/MM/yyyy");
        System.Console.WriteLine(dt3);

        string dtHour = DateTime.Now.ToString("HH:mm");
        System.Console.WriteLine(dtHour);

    }
}
