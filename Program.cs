namespace MyFirstCode
{
    class Program
    {
        static void Main (String[] args)
        {
            int[] larr1 = new int[5];
            Console.WriteLine("enter value for 5 integer:");

            for (int i = 0; i < 5; i++)
            {
                larr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            int lintmax = larr1[0];
            for (int i = 1; i < 5; i++)
            {
                if (lintmax < larr1[i])
                {
                    lintmax = larr1[i];
                }
            }
            Console.WriteLine("The Maxi value :" + lintmax);
        }
    }
}



