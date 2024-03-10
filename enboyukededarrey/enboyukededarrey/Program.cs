namespace enboyukededarrey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15,18,25,18,55,112 };
            int boyuk = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > boyuk)
                {
                    boyuk = array[i];
                }
            }
            Console.WriteLine("en boyuk eded: " + boyuk);

        }
    }
}
