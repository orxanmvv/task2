namespace arreyinikincienboyukededi
{
    using System;

    class Program
    {
        static void Main()
        {
           
            int[] array = { 1, 6, 5, 8, 9 };

          
            int max = array[0];
            int secondMax = array[1];

            
            for (int i = 2; i < array.Length; i++)
            {
                
                if (array[i] > max)
                {
                    secondMax = max;
                    max = array[i];
                }
               
                else if (array[i] > secondMax)
                {
                    secondMax = array[i];
                }
            }

            
            Console.WriteLine("Arrayin en boyuk ikinci elementi: " + secondMax);
        }
    }

}
