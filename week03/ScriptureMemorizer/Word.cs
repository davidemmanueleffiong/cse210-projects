namespace ScriptureMemorizer;

/// <summary>Stores one scripture word and whether it should be concealed.</summary>
public class Word
{
    private readonly string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden() => _isHidden;

    public void Hide() => _isHidden = true;

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        // Keep punctuation and digits visible; use one underscore per letter.
        return string.Concat(_text.Select(character =>
            char.IsLetter(character) ? '_' : character));
    }
}
