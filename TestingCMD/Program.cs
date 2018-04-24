using System;
class ReverseArray
{
    static void Main(string[] args)
    {

        int[] arr = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter the array elements[" + i + "]:");
            arr[i] = int.Parse(Console.ReadLine());
        }
        //write your logic here
       

        Array.Reverse(arr);
 




          //end 

        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadKey();
    }
}