using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    
    /*class Program
    {
        class FirstClass
        {

        }
        class SecondClass
        {

        }
        static void Main(string[] args)
        {

        }
    }*/
    internal class Program
    {
        
        class Car
        {
            int carNumber;
            DateTime inTime;
            DateTime ouTime;

            public void SetInTime()
            {
                this.inTime = DateTime.Now;
            }
            public void SetOutTime()
            {
                this.ouTime = DateTime.Now;
            }
        }

        class Product
        {
            public static string MADEIN = "Korea";

            public string name = "무명";
            public int price = 1000;

            public Product()
            {

            }
        }

        class Student
        {
            public string name;
            public int grade;

            public override string ToString()
            {
                return this.name + " : " + this.grade;
            }
        }

        static void Main(string[] args)
        {
            /*Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);

            List<int> list = new List<int>();
            list.Add(274);
            list.Add(243);
            list.Add(11);
            list.Add(5);

            foreach(var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\ttime: " + item);    
            }

            Product productA = new Product();

            productA.name = "포켓몬빵";
            productA.price = 1500;
            //인스턴스 변수를 생성과 동시에 초기화 (C# 고유 문법)
            Product productB = new Product() { name = "소금빵", price = 2000 };
            Product productC = new Product() { price = 5000, name = "당근케이크" };
            Product productD = new Product() { name = "보름달" };*/

            List<Student> st1 = new List<Student>();
            st1.Add(new Student() { name = "이수연", grade = 3 });
            st1.Add(new Student() { name = "김수연", grade = 1 });

            List<Student> st2 = new List<Student>()
            {
                new Student() { name = "이수", grade = 2 },
                new Student() { name = "수연", grade = 3 }
            };

            foreach (var item in st1)
            {
                Console.WriteLine(item);
            }

            foreach (var item in st2)
            {
                Console.WriteLine(item);
            }

            Method method = new Method();
            Console.WriteLine(method.Multi(52.1, 273));
            Console.WriteLine(method.Sum(1, 100));
            Console.WriteLine(method.Multiply(1, 3));
        }
    }
}
