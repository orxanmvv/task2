namespace tekvecutededlerarrey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrey = { 15, 16, 17, 18, 19, 20 };
            int tek = 0;
            int cut = 0;
            for (int i = 0; i < arrey.Length; i++)
                
            {
                if (arrey[i] % 2 == 0)
                {
                    cut++;
                }
                else
                {
                    tek++;
                }

            }
            Console.WriteLine("tek ededler:" + tek);
            Console.WriteLine("cut ededler:" + cut);        }
    }
}
