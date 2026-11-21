namespace ScriptureMemorizer;

/// <summary>Combines a reference and its words, and controls hiding progress.</summary>
public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word))
            .ToList();
    }

    public string GetReference() => _reference.GetDisplayText();

    public string GetDisplayText()
    {
        var scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool AllWordsAreHidden() => _words.All(word => word.IsHidden());

    public void HideRandomWords(int numberToHide)
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        var wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (var count = 0; count < wordsToHide; count++)
        {
            var randomIndex = Random.Shared.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }
}
