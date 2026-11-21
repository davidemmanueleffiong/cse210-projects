# Scripture Memorizer

A C# console program for practicing scripture memorization. It shows a scripture
and its reference, then hides up to three visible words each time Enter is
pressed. Type `quit` to stop early.

## Run it

From this directory, run:

```powershell
dotnet run
```

Choose a listed scripture number, or press Enter to choose one at random.

## Design

- `Reference` stores the book, chapter, and verse information. Its two
  constructors support one verse and a verse range.
- `Word` stores one word and its hidden state. When hidden, each letter becomes
  an underscore while punctuation and digits stay visible.
- `Scripture` owns a reference and a list of words. It builds the display,
  checks whether all words are hidden, and hides randomly selected visible
  words.
- `Program` presents the scripture library and runs the user interaction loop.

The additional creativity requirement is met with a scripture library,
user/random scripture selection, and random hiding that chooses only words
that are not already hidden. Each round hides up to three words.
