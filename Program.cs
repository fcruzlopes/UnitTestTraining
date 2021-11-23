class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("KCS IT Training \n");

        Console.WriteLine(FindMissingNumber(new int[] {1, 2, 3, 4, 6}, 5));
    }

    /*Find the missing element from a list*/
    public static int FindMissingNumber(int[] args, int length)
    {
        for(int i=1; i <= length+1; i++)
        {
            int index = Array.BinarySearch(args, i);
            if(index < 0)
            {
                Console.WriteLine("Number missing: " + i);
                return i;
            }
        }
        throw new ArgumentException(Messages.InvalideArray);
    }      
}