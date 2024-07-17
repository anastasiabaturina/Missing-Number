namespace MissingNumber;

public class MissingNumberSolver
{
    public static int FindMissingNumber(int[] nums)
    {
        var maxNumber = nums.Max();

        var sumSequence = maxNumber * (maxNumber + 1) / 2;

        var sumNums = nums.Sum();

        var missingNumber = sumSequence - sumNums;

        return missingNumber;
    }
}