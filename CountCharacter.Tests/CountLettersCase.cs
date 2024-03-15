namespace CountCharacter.Tests
{
    public record CountLettersCase
        {
        public required string Input { get; init; }

        public required Dictionary<char, int> ExpectedDictionary { get; init; }
        }

}
