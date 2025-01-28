namespace demo_branching;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    
    [Fact]
    public void FalseIsFalseAndStringIsEmpty()
    {
        // This was stupid
        Assert.False(!true);
        Assert.True(!false);
        Assert.Empty("");
    }
}
