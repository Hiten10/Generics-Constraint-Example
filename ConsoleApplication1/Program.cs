using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication1
{
    class Program
    {        
        public static string x;
        private static readonly Object O = new object();
        static void Main(string[] args)
        {
            int[] q = { 0, 1, 2, 3, 4 };
            int[] r = { 5, 6, 7, 8, 9 };
            int[] res = MergedArray(q,r);
            foreach (int item in res)
            {
                Console.WriteLine(item.ToString());
            }
            Class3 three = new Class4();
            three.Do();
            three.DoIt();
            int[] a = { 1, 2, 3, 4, 5 };
            int[] p = { 3, 4, 1, 8, 9 };
            int[] result = DoIntersection(a, p);
            Test test = new Test();//new Test("Hitendra Kumar", 35);
            test.DisplayName();
            PrintPiramid(7);
            int factorial = Factorial(6, 1);
            WriteLine($"Factorial value of given number is :{factorial}");
            WriteLine($"Calling Expression Bodied Method: {Test(5)} ");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int total = 0;
            total = RecursiveMethod(0, arr, 0);
            Console.WriteLine(total);

            Console.WriteLine(CheckSquareRoot<Boolean>(25));
            int[] array = { 1, 2, 3, 4, 5 };
            Array.ForEach(array, i => Console.WriteLine(i));
            Class1 c = new Class1();
            c.Add(3f, 3);
            c.Add(8, 7f);
            string x = "kkk";
            Class1 c1 = new Class2();
            c1.Calculate();
            ((Class2)c1).Calculate();
            c1.Add(8, 9);
            c1.Test<int>(null, 5);
            using (BaseDisposable b = new ChildClassA())
            {

            }

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn { ColumnName = "Name", DataType = typeof(string) });
            dt.Columns.Add(new DataColumn { ColumnName = "Age", DataType = typeof(int) });
            DataRow dr = dt.NewRow();
            dr["Name"] = "Hitendra";
            dr["Age"] = 35;
            dt.Rows.Add(dr);
            //DataRow dr = new DataRow(new DataColumn { ColumnName="Name", DataType=typeof(string)}));

            var row = dt.AsEnumerable().ToList();
            SomeMethod(dt);
            row.ForEach(d => Console.WriteLine(d["Name"] + "" + d["Age"]));

        }

        static void SomeMethod(DataTable dt)
        {
            dt.Rows[0]["Name"] = "Jitendra";
            dt.Rows[0]["Age"] = 29;

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr["Name"]);
                Console.WriteLine(dr["Age"]);
            }
        }

        static T CheckSquareRoot<T>(int num)
        {
            int flag = 0;
            if ((Math.Sqrt(num)) % 1 == 0)
            {
                flag = 1;
            }
            //if(typeof(T) == typeof(string))
            //{
            return (T)Convert.ChangeType(flag, typeof(T));
            //}

            //return default(T);
        }
        
        static double SquareRoot(int number) 
        {
            double t;
 
            double squareRoot = number / 2;
 
            do 
            {
                t = squareRoot;
                squareRoot = (t + (number / t)) / 2;
            } while ((t - squareRoot) != 0);
 
            return squareRoot;
        }

        static int RecursiveMethod(int counter, int[] x, int sum)
        {
            sum = sum + x[counter];
            counter++;
            //if (counter>=x.Length)
            //{
            //    return sum;
            //}

            return (counter >= x.Length) ? sum : RecursiveMethod(counter, x, sum);

            //return RecursiveMethod(counter, x, sum);
        }

        static int Factorial(int num, int factorialValue)
        {
            factorialValue = factorialValue * num;
            num--;
            if (num == 1)
            {
                return factorialValue;
            }

            return Factorial(num, factorialValue); }

        static int Test(int x) => x * 6;

        static void PrintPiramid(int num)
        {
            int count = num-1;
            for(int i=1; i <= num; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    //Write(" ");
                    Write(" ");
                }
                count--;
                for (int j = 1; j<=2*i-1; j++)
                {
                    //Write(" ");
                    Write("*");
                }
                WriteLine();
            }

            count = 1;
            for (int i = 1; i <=num-1; i++)
            {
                for (int j = 1; j <=count; j++)
                {
                    //Write(" ");
                    Write(" ");
                }

                for (int j = 1; j <=2*(num-i)-1; j++)
                {
                    //Write(" ");
                    Write("*");
                }
                WriteLine(" ");
            }
        }

        static int[] DoIntersection(int[] array1,int[] array2)
        {
            int[] result = new int[array1.Length];
            int counter = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array2.Contains(array1[i]))
                {
                    result[counter] = array1[i];
                    counter++;
                }
            }
            return result;
        }

        static int[] MergedArray(int[] array1,int[] array2)
        {
            if ((array1 != null && array2!=null) && (array1.Length>0 && array2.Length > 0))
            {
                int index1 = 0;
                int index2 = 0;
                int totalLength = array1.Length + array2.Length;
                int[] mergedArray = new int[totalLength];
                for (int i = 0; i < totalLength; i++)
                {
                    if (index1 < (array1.Length-1))
                    {
                        index1++;
                    }
                    else
                    {
                        index2++;
                    }
                    if (array1[index1]<array2[index2])
                    {
                        mergedArray[i] = array1[index1];
                       
                    }
                    else
                    {
                        mergedArray[i] = array2[index2];
                        index2++;
                    }
                }
                return mergedArray;
            }

            return null;
        }
        
    static string GeneratePassword(int lowercase, int uppercase, int numerics, int special) 
    {
    string lowers = "abcdefghijklmnopqrstuvwxyz";
    string uppers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string number = "0123456789";
    string specials = "!@^&%$#*{+}-=?_";  

    Random random = new Random();

    string generated = "!";
    for (int i = 1; i <= lowercase; i++)
        generated = generated.Insert(
            random.Next(generated.Length), 
            lowers[random.Next(lowers.Length - 1)].ToString()
        );

    for (int i = 1; i <= uppercase; i++)
        generated = generated.Insert(
            random.Next(generated.Length), 
            uppers[random.Next(uppers.Length - 1)].ToString()
        );

    for (int i = 1; i <= numerics; i++)
        generated = generated.Insert(
            random.Next(generated.Length), 
            number[random.Next(number.Length - 1)].ToString()
        );
        
    for (int i = 1; i <= special; i++)
        generated = generated.Insert(
            random.Next(generated.Length), 
            specials[random.Next(specials.Length - 1)].ToString()
        );

    return generated;

}
}

    class Test:BaseClass
    {
        string x = "global";
        private readonly string t = "xxx";
        public Test(string name, int age) : base(name)
        {

        }
        public Test()
        {

        }
        public string Method()
        {
            string t = "ppp";
            //int t = 1;
            string x = "local";
            x = this.x;
            return x;
            x = "";
        }
    }

    class BaseClass
    {
        private readonly string _name;
        public BaseClass(string name)
        {
            _name = name;
        }
        public BaseClass()
        {

        }
        public void DisplayName() => WriteLine($"My name is {_name}.");
    }
}
