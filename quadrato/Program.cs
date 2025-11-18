namespace quadrato
{
    internal class Program
    {
        static bool Quadrato(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if( i > 0 && array[i] < (array[i - 1] * array[i - 1]))
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] array = {5, 9, 10};

            if (Quadrato(array) == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
                
        }
    }
}
