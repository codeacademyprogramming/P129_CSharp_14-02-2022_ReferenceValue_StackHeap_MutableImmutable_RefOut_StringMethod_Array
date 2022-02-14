using System;

namespace ReferenceValueTypeStackHeapMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = a;
            //a += 7;
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //int[] arr1 = { 10, 20, 30 };
            //int[] arr2 = arr1;
            //arr2[0] = 200;
            //int[] arr3 = arr2;
            //arr3[0] = 300;
            //ChangeNum(arr1);

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);
            //Console.WriteLine(arr3[0]);

            //string stra = "Test";
            //string strb = stra;
            //stra = "Hello World";
            //Console.WriteLine(stra);
            //Console.WriteLine(strb);

            int Musa= 10;

            ChangeValue(ref Musa, out Musa);
            Console.WriteLine(Musa);
        }

        //static void ChangeValue(out int test)
        //{
        //    test = 70;
        //}

        static void ChangeValue(ref int test, out int test2)
        {
            test2 = 0;
        }

        //static void ChangeNum(int[] arr)
        //{
        //    arr[0] = 400;
        //}
    }
}
