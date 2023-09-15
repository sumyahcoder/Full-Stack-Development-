using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace W55
{//CHP 6

    //;IST IS GENERIC CLASS BECAUSE IT ACCEPTS ALL  DATA TYPES
    internal class Program
    {
        public class Student
        {
            internal int Id { get; set; }
            internal string Name { get; set; }    
            internal string Phone_number { get; set; } 

            public Student(int id,string name, string phone_number)
            {
                Id = id;
                Name = name;
                Phone_number = phone_number;
            }   
            public Student()
            {

            }
            public void Print()//you can access the method only through the print method --> security
            {
                Console.WriteLine("id :"+Id +" ,"+" name : "+Name +", "+ "Phonenumber :"+Phone_number);
            }
            public override string ToString()
            {
                return $"Student Id: {Id}, Name: {Name}, Phone: {Phone_number}";
            }
        }




        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();//we can put any data type in the array list
            arraylist.Add(1);
            arraylist.Add("sumyah");
            arraylist.Add(1.5);
            arraylist.Add(true);
            arraylist.Add('a');

            arraylist.Add(new Student() { Id = 1, Name = "sarah", Phone_number = "050 4566554" });


            //the items of type of primitve got printed eaily in the for each however the object printed the address of the object not the values
            foreach(var item in arraylist)
            {
               
             
                    Console.WriteLine(item);//toString is already implemented in the primitive data types
            }

            //List<Student> studentlist = new List<Student>();
            
            //Student s1=new Student(4,"hamda","050 5556666");//student no1
        
            //studentlist.Add(s1);
            //studentlist.Add(new Student() { Id = 1, Name = "srah", Phone_number = "050 4566554" });//student no2
            //studentlist.Add(new Student() { Id = 2, Name = "hoor", Phone_number = "050 5999999" });//student no3
            //studentlist.Add(new Student() { Id = 3, Name = "salama", Phone_number = "050 5999999" });//student no4
            



            //foreach (Student student in studentlist)
            //{
            //    student.Print();    
            //}

            ////1-Syntax :  List<datatype> listname = new List<datatype>();

            ////2-ways to declare a list
            //List<int> numbers = new List<int>();

            ////List<int> number = new List<int>(4);
            //List<int> numbe = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //3-ways to add items to a list
            //// 1-add is used 
            //numbers.Add(1);
            //numbers.Add(2);
            ////2- insert
            //3-   numbe[0] = 1;



            //printing or iterating through the list use for loop  or for each
            //foreach is better because it doesnt store any value in memory(memory efficient)

            // //foreach(int i in numbers)
            // //{
            // //    Console.WriteLine(i);
            // //}


            //When you use var in this context, the C# compiler infers the data type of 
            //    the variable based on the type of elements in the collection being iterated over.
            List<int> numb = new List<int>();
            //numb.Add(1);
            //numb.Add(2);
            //numb.Add(3);

            //foreach (var item in numb)
            //{
            //   Console.WriteLine(item);
            //}
            // numbers.Insert(1, 10);

            // foreach (int i in numbers)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("))))))))))");
            // numbers.Add(1);
            // numbers.Add(2);
            // numbers.Add(3); 
            //  numbers.Add(4);
            //     numbers.Add(5);
            // //REMOVE 
            // //numbers.Remove(10);//by item value
            // //numbers.RemoveAt(1);//by index
            // List<int> numbe = new List<int>();
            // Console.WriteLine("))))))))))");
            // numbe.Add(1);
            //         numbe.Add(2);
            //         numbe.Add(3);
            // Console.WriteLine("))))))))))");    
            // foreach (int i in numbe)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("))))))))))");
            // //numbe.Clear();
            // numbe[0] = 1;
            // Console.WriteLine(numbe[0]);
            // Console.WriteLine("**********");
            //// numbers.RemoveRange(0, 2);//by range

            // foreach (int i in numbers)
            // {
            //     Console.WriteLine(i);
            // }
        } }
}
