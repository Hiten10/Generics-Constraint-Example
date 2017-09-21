using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Class3
    {
        public virtual void Do()
        {
            var list = Enumerable.Range(1, 100).ToList();
            list.ForEach(i => DoSomething(i));
            Console.WriteLine("Class3");
            var list1 = new[] {"A","B","C","D","E","F" };
            var half = list1.Where((t,i)=>i< 3).ToList();
            
        }

        public void DoIt()
        {
            dynamic obj = new {City="" };
            obj.City = "Test";
            Console.WriteLine(obj.City);
            Console.WriteLine("Class3");
        }

        public void DoSomething(int i) { }

    }

    public class Class4 : Class3
    {
        public override void Do()
        {
            Console.WriteLine("Class4");
        }

        public new void  DoIt()
        {
            Console.WriteLine("Class4");
        }
    }

    public interface IPerson
    { }
    public interface IGroup<T> where T : class, IPerson, new()
    {
         List<T> MyProperty { get; set; }
    }

    public struct Employee
    {

    }
    public struct Structure<T> where T:struct
    {
        List<T> MyProperty { get; set; }
    }

    public class Person { }
    public class Group<T> where T:Person
    {

    }

    public class Vehicle
    {
        public int MaxSpeed;
        public static string Conutry;
        public Vehicle(int maxSpeed)
        {
            this.MaxSpeed = maxSpeed;
            
        }
    }

    public class car : Vehicle
    {
        public car(int maxSpeed) : base(maxSpeed)
        {
            this.MaxSpeed = maxSpeed;
        }
        static car()
        {
            //Country = "UK";
        }
    }
}
