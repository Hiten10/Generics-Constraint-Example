using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Class1
    {
        private int x = 0;
        public Class1()
        {

        }
        public int Age { get; set; }
        public string Name { get; set; }

        public void Test() { }
        protected void Display() { }
        private string Do() { return ""; }
        public static void StaticMethod() { }
        protected internal void Help() { }

        public int Calculate()
        {
            return 6;
        }

        public string Calculate(string x)
        {
            return "";
        }
        public void Add(int a, float b)
        {

        }

        public void Add(float a, int b)
        {

        }

        public void Add(int a, int b)
        {

        }

        public T? Test<T>(T? x,T? y) where T: struct
        {
            return null;
        }

        public void Test1<T>(T? x, T? y) where T:struct
        {
            
        }
    }

    public class Class2:Class1
    {
        public new void Calculate() { }
    }
    

}
