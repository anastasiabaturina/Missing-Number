namespace MissingNumber;

public class Program
{
    public static void Main()
    {
        var missingNumber = MissingNumberSolver.FindMissingNumber([9,6,4,2,3,5,7,0,1]);

        Console.WriteLine(missingNumber);
    }
}