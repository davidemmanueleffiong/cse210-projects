        // Creativity beyond the core requirements: this program offers a small library
        // of scriptures, lets the user choose one, and hides only words that are still
        // visible. Each round hides up to three words.

        using ScriptureMemorizer;

        var scriptureLibrary = new List<Scripture>
        {
            new(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, " +
                "that whosoever believeth in him should not perish, but have everlasting life."),
            new(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own " +
                "understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new(
                new Reference("Mosiah", 2, 17),
                "And behold, I tell you these things that ye may learn wisdom; that ye may " +
                "learn that when ye are in the service of your fellow beings ye are only " +
                "in the service of your God.")
        };

        Console.WriteLine("Scripture Memorizer\n");
        for (var index = 0; index < scriptureLibrary.Count; index++)
        {
            Console.WriteLine($"{index + 1}. {scriptureLibrary[index].GetReference()}");
        }

        Console.Write("\nChoose a scripture number, or press Enter for a random one: ");
        var selection = Console.ReadLine();
        var scripture = SelectScripture(scriptureLibrary, selection);
        var wordsToHidePerRound = 3;

        while (!scripture.AllWordsAreHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\nPress Enter to hide up to three words, or type 'quit' to stop: ");

            var response = Console.ReadLine();
            if (response?.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase) == true)
            {
                return;
            }

            scripture.HideRandomWords(wordsToHidePerRound);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        static Scripture SelectScripture(List<Scripture> scriptures, string? selection)
        {
            if (int.TryParse(selection, out var number) && number >= 1 && number <= scriptures.Count)
            {
                return scriptures[number - 1];
            }

            return scriptures[Random.Shared.Next(scriptures.Count)];
        }
