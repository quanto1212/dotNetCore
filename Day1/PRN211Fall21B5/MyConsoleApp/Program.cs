
using ConsoleApp2;
using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();//goi duoc vi Product la public class
            //ConsoleApp2.InternalProduct p1 = new ConsoleApp2.InternalProduct();
            //ko goi duoc InternalProduct vi no la internal, chi goi duoc trong cung 1 project


            Student s = new Student();//khai bao bien s thuoc type Student
            s.Id = 10;//loi goi toi setter
            s.Name = "ChiLP";
            Console.WriteLine(s.Id + "-" + s.Name); //loi goi toi getter

            Student s1 = new SEStudent(12, "ABC", "C#");
            s1.Display();//?

            Student s2 = new Student(13, "DEF");
            //s2.Display();
            Console.WriteLine(s2);//s2.ToString()

            Student s3 = new Student();
            s3.Input();
            s3.Display();
        }
    }

    class Student  //dinh nghia 1 type
    {
        int id;  //private field
        protected string name;

        public Student()
        { }

        public Student(int i, string n)
        {
            Id = i;
            Name = n;
        }
        

        public int Id  //public property
        {
            get { return id; } //getter
            set { id = value; } //setter
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //DateTime dob;
        //public DateTime Dob
        //{
        //    get { return dob; }
        //    set { dob = value; }
        //}
        //viet tat thanh:

        public DateTime Dob { get; set; }
        //Dob van la 1 public property, get/set du lieu cho 1 field ngam dinh dc .net tao ra, ten la gi ta ko can quan tam
        
        virtual public void Display()
        {
            Console.WriteLine($"Student: {Id} - {Name}");
        }



        virtual public void Input()
        {
            Console.WriteLine("Input student's info:");
            Console.WriteLine("Id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Student: {Id} - {Name}";
        }
    }

    class SEStudent: Student  //SEStudent ke thua Student
    {
        public string Skill { get; set; }

        public SEStudent(int i, string n, string skill):base(i, n)//loi goi toi ham tao 2 tham so cua lop cha
        {
            Skill = skill;
        }

        public void Fun1()
        {
            this.name = "ChiLP";
        }

        override public void Display()
        {
            base.Display();  //goi ham Display cua lop cha
            Console.WriteLine($"Skill: {Skill}");
        }

        override public void Input()
        {
            base.Input();
            Console.WriteLine("Skill:");
            Skill = Console.ReadLine();
        }
    }
}
