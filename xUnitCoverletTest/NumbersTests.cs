using xUnitCoverletLib;

namespace xUnitCoverletTest;
public class NumbersTests
{
    [Fact]
    public void ValidOneNumber()
    {
        // ARRANGE
        string number = "123324324";
        // ACT
        bool isNumer = Numbers.IsValid(number);
        // ASSERT
        Assert.True(isNumer);
    }
    public static readonly object[][] InsertValidNumbers = {
            new object[] { "123456782"},
            new object[] { "1"},
            new object[] { "233"},
    };
    [Theory, MemberData(nameof(InsertValidNumbers))]
    public void ValidMultipleNumber(string number)
    {
        // ACT
        bool isNumer = Numbers.IsValid(number);
        // ASSERT
        Assert.True(isNumer);
    }

    public static readonly object[][] InsertInvalidNumbers = {
            new object[] { "12345678912"},
            new object[] { "Ola"},
            new object[] { "So Sabi"},
            new object[] { "12345q6789"},
    };
    [Theory, MemberData(nameof(InsertInvalidNumbers))]
    public void InvalidNumbers(string number)
    {
        // ACT
        bool isNumer = Numbers.IsValid(number);
        // ASSERT
        Assert.False(isNumer);
    }
}