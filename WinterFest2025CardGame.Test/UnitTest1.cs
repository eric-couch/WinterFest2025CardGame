namespace WinterFest2025CardGame.Test;

public class UnitTest1
{
    [Fact]
    public void TestIsStraight_True()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card("♣", 4, "4"),
            new Card("♣", 5, "5"),
            new Card("♦", 6, "6"),
            new Card("♣", 7, "7"),
            new Card("♥", 8, "8")
        };
        // Act
        bool result = FiveCardDraw.IsStraight(cards);

        // Assert 
        Assert.True(result);
    }

    [Fact]
    public void TestIsStraight_False()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card("♣", 4, "4"),
            new Card("♣", 5, "5"),
            new Card("♦", 7, "7"),
            new Card("♣", 7, "7"),
            new Card("♥", 8, "8")
        };
        // Act
        bool result = FiveCardDraw.IsStraight(cards);

        // Assert 
        Assert.False(result);
    }

    [Fact]
    public void TestIsPair_True()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card("♣", 4, "4"),
            new Card("♣", 5, "5"),
            new Card("♦", 7, "7"),
            new Card("♣", 7, "7"),
            new Card("♥", 8, "8")
        };
        // Act
        bool result = FiveCardDraw.HasPair(cards);

        // Assert 
        Assert.True(result);
    }

    [Fact]
    public void TestIsPair_False()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card("♣", 4, "4"),
            new Card("♠", 7, "7"),
            new Card("♦", 7, "7"),
            new Card("♣", 7, "7"),
            new Card("♥", 8, "8")
        };
        // Act
        bool result = FiveCardDraw.HasPair(cards);

        // Assert 
        Assert.False(result);
    }
}
