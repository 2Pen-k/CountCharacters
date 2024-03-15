// See https://aka.ms/new-console-template for more information


using System.ComponentModel.DataAnnotations;

public class CharacterCounter
{
    public string _rawText;

    public CharacterCounter(string? rawText)
    {
        ArgumentException.ThrowIfNullOrEmpty(rawText);
        _rawText = rawText.ToLower(); 
    }
    public Dictionary<char, int> CountLetters()
    {
        
        Dictionary<char, int> numberOfRepeats = new();
        foreach (char character in _rawText)
        {
            if(!Char.IsLetter(character))
            {
                continue;
            }
            else if (!numberOfRepeats.ContainsKey(character))
            {
                numberOfRepeats.Add(character, 1);
            }
            else
            {
                numberOfRepeats[character] += 1;
            }
        }
        
        numberOfRepeats = SortCounted(numberOfRepeats);
        return numberOfRepeats;

    }

    public Dictionary<char, int> SortCounted(Dictionary<char, int>  numberOfRepeats)
    {

        int max = 0;
        Dictionary<char, int> newNumberOfRepeats = new();
        foreach (var letterRepeat in numberOfRepeats)
        {
            if (letterRepeat.Value>max)
            {
                max = letterRepeat.Value;
            }
        }
        for (int i = max;i>0;i--)
        {
            foreach (var letterRepeat in numberOfRepeats)
            {
                if (letterRepeat.Value==i)
                {
                    newNumberOfRepeats.Add(letterRepeat.Key, i);
                }
            }
        }

        return newNumberOfRepeats; 
    }
}