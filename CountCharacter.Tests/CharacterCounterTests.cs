


using System.Diagnostics.Metrics;

namespace CountCharacter.Tests;

public class CharacterCounterTests
{
    [Theory(DisplayName = "Should correctly count letters")]
    [MemberData(nameof(ConterLetterCaseGenerator.GetCases),
        MemberType = typeof(ConterLetterCaseGenerator))]
    public void ShouldCorrectlyCountLetters(CountLettersCase testCase)
    {
        //Arrange 
        CharacterCounter characterCounter = new CharacterCounter(testCase.Input);

        //Act 
        Dictionary<char, int> result = characterCounter.CountLetters();

        //Assert 
        Assert.Equal(testCase.ExpectedDictionary, result);
    }

    [Theory(DisplayName = "Should throw an exception if input is invalid")]
    [InlineData(null)]
    [InlineData("")]
    public void ShouldThrowExceptionIfInputIsInvalid(string input)
    {
        Assert.ThrowsAny<ArgumentException>(() => new CharacterCounter(input));
    }
}