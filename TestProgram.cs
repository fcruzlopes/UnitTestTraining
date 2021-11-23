using Xunit;

public class TestProgram
{
    [Theory]
    [InlineData(new int[] {1,2,3,4,6}, 5, 5)]
    [InlineData(new int[] {1,2,3,4,5,6,7,8,10}, 9, 9)]
    [InlineData(new int[] {1,9,5,3,4,7,8,10,11,15,14,12,13,16,19,6,17,18,20}, 19, 2)]
    public void TestFindMissingNumber(int[] args, int length, int numberMissing)
    {
        int numberFound = Program.FindMissingNumber(args, length);
        Assert.Equal(numberMissing, numberFound);
    }
}