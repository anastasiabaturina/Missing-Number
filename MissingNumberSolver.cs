namespace MissingNumber;

public class MissingNumberSolver
{
    public static int FindMissingNumber(int[] nums)
    {
        var maxNumber = nums.Max();
        var minNumber = nums.Min();
        var amount = nums.Length + 1;
        var sumNums = nums.Sum();

        var sumSequence = amount * (minNumber + maxNumber) / 2;
      
        var missingNumber = sumSequence - sumNums;

        return missingNumber;
    }
}