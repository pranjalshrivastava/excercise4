using System;
using System.Collections.Generic;
using System.Text;

namespace excercise4
{
    class Car3
    {
         string color = "red";

        public void method1()
        {
            Car3 myObj2 = new Car3();
            Car3 myObj3 = new Car3();
            Console.WriteLine(myObj2.color);
            Console.WriteLine(myObj3.color);
            
        }
       
    }
}
