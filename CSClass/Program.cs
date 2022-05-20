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

        static void Main(string[] args)
        {
            Car car = new Car();
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
            Product productD = new Product() { name = "보름달" };
        }
    }
}
