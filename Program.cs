using Slide2;
using System;
using System.ComponentModel;
using System.Diagnostics;

public class Program
{
    
    public static void Main(string[] args)
    {

        var studentList = new List<Student>();
        studentList.Add(new Student(1, "NguyenVanA", "CNTT"));
        studentList.Add(new Student(2, "NguyenVanB", "CNTT1"));
        studentList.Add(new Student(3, "NguyenVanC", "CNTT2"));

        foreach (var student in studentList) {
            Console.WriteLine($"ID: {student.Id}," +
                $" Name: {student.Name}, Major: {student.Description}");
        }

    }

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