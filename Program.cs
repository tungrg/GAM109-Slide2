using Slide2;
using System;
using System.ComponentModel;
using System.Diagnostics;

public class Program
{
    
    public static void Main(string[] args)
    {

        //var studentList = new List<Student>();
        //studentList.Add(new Student(1, "NguyenVanA", "CNTT"));
        //studentList.Add(new Student(2, "NguyenVanB", "CNTT1"));
        //studentList.Add(new Student(3, "NguyenVanC", "CNTT2"));

        //foreach (var student in studentList) {
        //    Console.WriteLine($"ID: {student.Id}," +
        //        $" Name: {student.Name}, Major: {student.Description}");
        //}
        //var listIntNullable = new List<int?>() { 1,2,3, null, 4 ,5, null ,null};
        //foreach (var item in listIntNullable) {
        //    Console.WriteLine(item);
        //}
        var listInt = new List<int>() { 1,2,3,45,5,6,7,-3,51};
        //Dinh nghia ham gia
        SapXep(listInt, delegate (int a, int b) { return a > b; });
        foreach (var i in listInt) {
            Console.WriteLine(i);
        }
        Console.WriteLine("__________________________");
        SapXep(listInt, delegate (int a, int b) { return a < b; });
        foreach (var i in listInt)
        {
            Console.WriteLine(i);
        }
    }
    //Truyen ham gia vao danh sach tham so
    public static void SapXep(List<int> list, SoSanhDelegate soSanh)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (soSanh(list[i], list[j]))
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
    }
    //Buoc 1, khai bao ham gia
    public delegate bool SoSanhDelegate(int a, int b);
    
    

    //public static void demo1()
    //{
    //    GetDetailOfParam(3);
    //    GetDetailOfParam(4.0f);
    //    GetDetailOfParam("hello");
    //}
    //public static void GetDetailOfParam(dynamic para)
    //{
    //    para = para * 2;
    //    Console.WriteLine(para);
    //    Console.WriteLine(para.GetType());
    //}
}