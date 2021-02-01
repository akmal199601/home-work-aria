using System;

namespace ARIYA
{
    class Program
    {
        static void Main(string[] args)
        {
            public static class ArrayHelper
        {
            public static string Pop(ref string[] akmal1)
            {
                string mas = [akmal1.Length - 1];
                Array.Resize(ref akmal1, akmal1.Length - 1);
                return mas;
            }
            public static int Pop(ref int[] akmal2)
            {
                int mas1 = akmal2[akmal2.Length - 1];
                Array.Resize(ref akmal2, akmal2.Length - 1);
                return mas1;
            }
            public static double Pop(ref double[] akmal3)
            {
                double mas2 = akmal3[akmal3.Length - 1];
                Array.Resize(ref akmal3, akmal3.Length - 1);
                return mas2;
            }
            public static decimal Pop(ref decimal[] akmal4)
            {
                decimal mas3 = akmal4[akmal4.Length - 1];
                Array.Resize(ref akmal4, akmal4.Length - 1);
                return mas3;
            }
            public static float Pop(ref float[] akmal5)
            {
                float mas4 = akmal5[akmal5.Length - 1];
                Array.Resize(ref akmal5, akmal5.Length - 1);
                return mas4;
            }

            public static int Push(ref string[] arr, string rar)
            {

                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = rar;
                return arr.Length;

            }
            public static int Push(ref int[] arr1, int rar1)
            {

                Array.Resize(ref arr1, arr1.Length + 1);
                arr1[arr1.Length - 1] = rar1;
                return arr1.Length;

            }
            public static double Push(ref double[] arr2, double rar2)
            {
                Array.Resize(ref arr2, arr2.Length + 1);
                arr2[arr2.Length - 1] = rar2;
                return arr2.Length;

            }
            public static decimal Push(ref decimal[] arr3, decimal rar3)
            {
                Array.Resize(ref arr3, arr3.Length + 1);
                arr3[arr3.Length - 1] = rar3;
                return arr3.Length;
            }
            public static float Push(ref float[] arr4, float rar4)
            {
                Array.Resize(ref arr4, arr4.Length);
                arr4[arr4.Length - 1] = rar4;
                return arr4.Length;
            }
            public static string Shift(ref string[] arr5)
            {
                string arr = arr5[0];
                for (int i = 0; i < arr5.Length - 1; i++)
                {
                    arr5[i] = arr5[i + 1];
                }
                Array.Resize(ref arr5, arr5.Length - 1);
                return arr;
            }
            public static int Shift(ref int[] arrarr)
            {
                int arr1 = arrarr[0];
                for (int i = 0; i < arrarr.Length - 1; i++)
                {
                    arrarr[i] = arrarr[i + 1];
                }
                Array.Resize(ref arrarr, arrarr.Length - 1);
                return arr1;
            }
            public static double Shift(ref double[] arrarr2)
            {
                double arr2 = arrarr2[0];
                for (int i = 0; i < arrarr2.Length - 1; i++)
                {
                    arrarr2[i] = arrarr2[i + 1];
                }
                Array.Resize(ref arrarr2, arrarr2.Length - 1);
                return arr2;
            }
            public static decimal Shift(ref decimal[] arrarr3)
            {
                decimal arr3 = arrarr3[0];
                for (int i = 0; i < arrarr3.Length - 1; i++)
                {
                    arrarr3[i] = arrarr3[i + 1];
                }
                Array.Resize(ref arrarr3, arrarr3.Length - 1);
                return arr3;
            }
            public static float Shift(ref float[] arrarr4)
            {
                float arr4 = arrarr4[0];
                for (int i = 0; i < arrarr4.Length - 1; i++)
                {
                    arrarr4[i] = arrarr4[i + 1];
                }
                Array.Resize(ref arrarr4, arrarr4.Length - 1);
                return arr4;
            }
            public static int UnShift(ref string[] newaddelement, string aelemnt)
            {
                Array.Resize(ref newaddelement, newaddelement.Length + 1);
                for (int i = newaddelement.Length - 1; i >= 1; i--)
                {
                    newaddelement[i] = newaddelement[i - 1];
                }
                newaddelement[0] = aelemnt;
                return newaddelement.Length - 1;
            }
            public static int UnShift(ref int[] newaddelement, int aelemnt)
            {
                Array.Resize(ref newaddelement, newaddelement.Length + 1);
                for (int i = newaddelement.Length - 1; i >= 1; i--)
                {
                    newaddelement[i] = newaddelement[i - 1];
                }
                newaddelement[0] = aelemnt;
                return newaddelement.Length - 1;
            }
            public static double UnShift(ref double[] newaddelement, double aelemnt)
            {
                Array.Resize(ref newaddelement, newaddelement.Length + 1);
                for (int i = newaddelement.Length - 1; i >= 1; i--)
                {
                    newaddelement[i] = newaddelement[i - 1];
                }
                newaddelement[0] = aelemnt;
                return newaddelement.Length - 1;
            }
            public static decimal UnShift(ref decimal[] newaddelement, decimal aelemnt)
            {
                Array.Resize(ref newaddelement, newaddelement.Length + 1);
                for (int i = newaddelement.Length - 1; i >= 1; i--)
                {
                    newaddelement[i] = newaddelement[i - 1];
                }
                newaddelement[0] = aelemnt;
                return newaddelement.Length - 1;
            }
            public static float UnShift(ref float[] newaddelement, float aelemnt)
            {
                Array.Resize(ref newaddelement, newaddelement.Length + 1);
                for (int i = newaddelement.Length - 1; i >= 1; i--)
                {
                    newaddelement[i] = newaddelement[i - 1];
                }
                newaddelement[0] = aelemnt;
                return newaddelement.Length - 1;
            }


        }
        class Program
        {
            static void Main(string[] args)
            {
                string[] mas = new string[] { "akmal", "akmal1", "akmal2" };
                string massive = ArrayHelper.Pop(ref mas);
                Console.WriteLine($" POP = { massive}");

                int[] mas1 = new int[] { 1, 2, 3 };
                int massive1 = ArrayHelper.Pop(ref mas1);
                Console.WriteLine($" POP = { massive1}");

                double[] mas2 = new double[] { 1.2, 1.3, 1.4 };
                double massive2 = ArrayHelper.Pop(ref mas2);
                Console.WriteLine($" POP = { massive2}");

                decimal[] mas3 = new decimal[] { 1.0m, 2.1m, 3.2m };
                decimal akmalmas = ArrayHelper.Pop(ref mas3);
                Console.WriteLine($" POP = { massive3}");

                float[] mas4 = new float[] { 1.1f, 2.2f, 3.3f };
                float massive4 = ArrayHelper.Pop(ref mas4);
                Console.WriteLine($" POP = { massive4}");
                //

                string[] arr = new string[] { "aki", "aki1", "aki2" };
                int rar = ArrayHelper.Push(ref arr, "akmaljon");
                Console.WriteLine("String Push MEARRAY = " + rar);

                int[] arr122 = new int[] { 1, 2, 3 };
                int rar1 = ArrayHelper.Push(ref arr122, 4);
                Console.WriteLine("Int Push = " + rar1);

                double[] arr123 = new double[] { 1.1, 1.2, 1.3 };
                double rar2 = ArrayHelper.Push(ref arr123, 1.4);
                Console.WriteLine("Double Push = " + rar2);

                decimal[] arr1234 = new decimal[] { 1.1m, 1.2m, 1.3m, 1.4m };
                decimal rar3 = ArrayHelper.Push(ref arr1234, 1.5m);
                Console.WriteLine("Decimal Push = " + rar3);

                float[] arr12345 = new float[] { 5.1f, 5.2f, 5.3f };
                float rar4 = ArrayHelper.Push(ref arr12345, 5.4f);
                Console.WriteLine("Float Push = " + rar4);

                //

                string[] marr = new string[] { "me", "me1", "me2" };
                Console.WriteLine(ArrayHelper.Shift(ref marr));
                int[] marrr = new int[] { 4, 5, 6 };
                Console.WriteLine(ArrayHelper.Shift(ref marrr));
                double[] marrrr = new double[] { 7.1, 7.2, 7.3 };
                Console.WriteLine(ArrayHelper.Shift(ref marrrr));
                decimal[] marrrrr = new decimal[] { 8.1m, 8.2m, 8.3m };
                Console.WriteLine(ArrayHelper.Shift(ref marrrrr));
                float[] marrrrrr = new float[] { 9.1f, 9.2f, 9.3f };
                Console.WriteLine(ArrayHelper.Shift(ref marrrrrr));
                //
                string[] newarray = new string[] { "12", "13", "14" };
                int newelemstr = ArrayHelper.UnShift(ref newarray, "C");
                Console.WriteLine($"Unshift string: {newelemstr}");

                int[] arrayint = new int[] { 1, 2, 3, 4, 5 };
                int newelemint = ArrayHelper.UnShift(ref arrayint, 6);
                Console.WriteLine($"Unshift int: {newelemint}");


                double[] arraydouble = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
                double newelemdbl = ArrayHelper.UnShift(ref arraydouble, 6.6);
                Console.WriteLine($"Unshift double {newelemdbl}");


                decimal[] arraydecimal = new decimal[] { 5.505m, 4.404m, 3.303m, 2.202m, 1.101m };
                decimal newelembl = ArrayHelper.UnShift(ref arraydecimal, 0.101m);
                Console.WriteLine($"Unshift decimal: {newelembl}");

                float[] arrayfloat = new float[] { 5.5f, 4.4f, 3.3f, 2.2f, 1.1f };
                float newelemfloat = ArrayHelper.UnShift(ref arrayfloat, 0.1f);
                Console.WriteLine($"Unshift float: {newelemfloat}");

            }
        }
}
