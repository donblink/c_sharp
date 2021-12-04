using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItYourselfHour1
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithPredefinedTypes();
            ArithmeticOperator();
            RelationalLogicalOperator();
            WorkingWithNullableTypes();
            Conversions();
            LightHouse first = new LightHouse();
            LightHouse second = new LightHouse();
            int one = 10;
            int two = 20;
            Console.WriteLine("the lighthouse value is {0}", first.NumberOfLights);
            Console.WriteLine("the lighthouse value is {0}", first.RevolutionPerMinutes);
            Console.WriteLine("the one value is {0}", one);
            Console.WriteLine("the two value is {0}", two);

        }

        static void WorkingWithPredefinedTypes()
        {
            int i = 20;
            float f = 20.2f;
            string s = "hello , world ... again";
            Console.WriteLine("this is an {0} value: {1}", i.GetTypeCode(), i);
            Console.WriteLine("this is an {0} value: {1}", f.GetTypeCode(), f);
            Console.WriteLine("this is an {0} value: {1}", s.GetTypeCode(), s);
            var v = 20;
            Console.WriteLine("this is an {0} value: {1}", v.GetTypeCode(), v);
        }

        static void ArithmeticOperator()
        {
            int i = 20;
            Console.WriteLine("i ={0}", i);

            i = i + 1;
            Console.WriteLine("i ={0}", i);

            i += 2;
            Console.WriteLine("i ={0}", i);

            i -= 3;
            Console.WriteLine("i ={0}", i);

        }
        static void RelationalLogicalOperator()
        {
            int x = 20;
            int y = 10;

            Console.WriteLine("expression: {0}", x != y );
            Console.WriteLine("expression: {0}", x >= y);
            Console.WriteLine("expression: {0}", x <= y);
        }

        static void WorkingWithNullableTypes()
        {
            int x = 10;
            int? nx = null;
            
            Console.WriteLine("nx has a value ? {0}", nx.HasValue);
            Console.WriteLine("x == nx: {0}", x == nx);
            Console.WriteLine("x != nx: {0}", x != nx);


            int? nx2 = 20;
            Console.WriteLine("nx has a value ? {0}", nx2.HasValue);
            Console.WriteLine("x == nx: {0}", x == nx2);
            Console.WriteLine("x != nx: {0}", x != nx2);

            float? nx3 = null;
            Console.WriteLine("nx3 has a value ? {0}", nx3 ?? 1.3f);
            Console.WriteLine("nx3 = {0}", nx3.GetValueOrDefault());
            Console.WriteLine("nx3 = {0}", nx3.GetValueOrDefault(-2.2f));

            int? nx4 = 10;
            Console.WriteLine("nx3 has a value ? {0}", nx4 ?? -1);
            Console.WriteLine("nx3 = {0}", nx4.GetValueOrDefault());
            Console.WriteLine("nx3 = {0}", nx4.GetValueOrDefault(-2));
            
        }

        static void Conversions()
        {
            int i = 36;
            object boxed = i;
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("boxed = {0}", boxed);

            boxed = (int)boxed + 2;

            Console.WriteLine("i = {0}", i);
            Console.WriteLine("boxed = {0}", boxed);

            i = i + 1;

            Console.WriteLine("i = {0}", i);
            Console.WriteLine("boxed = {0}", boxed);
            
            i = (int) boxed;

            int? h = null;
            int? j = i;

            object jboxed = j;
            
            Console.WriteLine("h has a value? {0}", h.HasValue);
            h = jboxed as int?;
            Console.WriteLine("h has a value? {0}", h.Value);


        }
    }
}
