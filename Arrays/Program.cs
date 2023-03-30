using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            //////1111111
            //int[] numbers = new int[] { 4, 6, 56, 87, 98, 3, 2, 44, 7, 9, 57 };
            //int index = 0;

            //for (int i = 0; i <= numbers.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] > numbers[j])
            //        {

            //            index = numbers[i];
            //            numbers[i] = numbers[j];
            //            numbers[j] = index;
            //        }
            //    }
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + ",");
            //}







            /////22222 Mellim deqiq olsun  deye double ile yazdim normalda int ile yazmisdim


            //int[] number = new int[] { 5, 4, 3, 2, 1, 9 };
            //double total = 0.0d;
            //double arithmeticMean = 0.0d;
            //foreach (int i in number)
            //{
            //    total += i;

            //    arithmeticMean = (total / number.Length);

            //}

            //Console.WriteLine(arithmeticMean);





            //////33333

            int[] number = new int[] { 3, 7, 90, 4, 234, 67, 54, 231 };
            int index = 0;

            for (int i = 0; i < number.Length / 2; i++)
            {
                index = number[i];
                number[i] = number[number.Length - i - 1];
                number[number.Length - i - 1] = index;


            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " , ");



            }







        }
    }
}


