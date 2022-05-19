using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
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

        
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);

        }
    }
}
