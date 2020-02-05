using System;
using System.Collections.Generic;
using System.Text;

namespace excercise4
{
    class Car1
    {
        string color = "red";
        static void Main(string[] args)
        {
            Car1 myObj = new Car1();
            Console.WriteLine(myObj.color);
            Car3 myObj4 = new Car3();
            myObj4.method1();
            MyClass obj5 = new MyClass();
            obj5.fullThrottle();
            Car4 obj7 = new Car4();
            obj7.method2();
        }
    }
}
