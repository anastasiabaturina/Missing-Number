namespace MissingNumber;

public class Programm
{
    public static void Main()
    {
        var missingNumber = MissingNumberSolver.FindMissingNumber([0,3,1,2,5,6,7,9,4]);

        Console.WriteLine(missingNumber);
    }
}