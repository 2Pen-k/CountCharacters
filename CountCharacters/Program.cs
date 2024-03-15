// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your text string:");

string? input = Console.ReadLine();
CharacterCounter counter = new CharacterCounter(input);
Dictionary<char, int> numberOfLetters = counter.CountLetters();

foreach (var (key, value) in numberOfLetters)
{
    Console.WriteLine($"{key} :{value}");
}
