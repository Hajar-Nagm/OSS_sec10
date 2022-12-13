using System;
namespace Hajar;
public abstract class Person{

    public string Name;
    public int Age;

    public Person(string name, int age ){
        Name=name;
        Age=age;
    }

    public abstract void Print(){
        
    }
}

public class Student :Person{
    public int Year;
    public float Gpa;
    public Student (string name,int age,float gpa ):base(name,age){
        Year=year;
        Gpa=gpa;
    }
    public override void Print(){
        Console.WriteLine($"My name is{Name},my age is{Age},and gpa is {Gpa}");
    }
}
public class Database{
    public Person[] People=new Person[50];

    public void AddStudent(Student student){
        People[currentIndex++]=student;
    }
    public void AddStaff(Staff staff){
        People[currentIndex++]=staff;
    }
}

public class Staff :Person{

public double Salary;
public int JoinYear;
public ctor (string name,int age,double salary ,int joinyear):base(name,age){
Salary=salary;
JoinYear=joinyear;
}
public override void Print(){
        Console.WriteLine($"My name is{Name},my age is{Age},and my salary is {Salary}");
    }

}
public  class Program{

private static void Main(){
    Console.WriteLine("enter a number 1)student 2)staff 3)print all peaple")
    int x=Convert.ToInt32(Console.Readline());
    var database=new DataBase();
    switch (x)
    {
        case 1:
        Console.Write("Name: ");
        var name=Console.Readline();
        Console.Write("Age: ");
        var age =Convert.ToInt32(Console.Readline());
        Console.Write("Gpa: ");
        var gpa = Convert.ToString(Console.Readline);
        var student =new Student(name,age,year,gpa);
        database.AddStudent(student);
        break;
        
        case 2:
        Console.Write("Name: ");
        var name=Console.Readline();
        Console.Write("Age: ");
        var age =Convert.ToInt32(Console.Readline());
        Console.Write("Salary: ");
        var salary = Convert.ToDouble(Console.Readline);
        Console.Write("JoinYear: ");
        var joinyear = Convert.ToInt32(Console.Readline);
        var staff =new Staff(name,age,salary,joinyear);
        database.AddStaff(staff);
        break;
        case 3:
        Print();
        break;
    }


}
}
