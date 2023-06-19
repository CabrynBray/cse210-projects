class ThoughtGenerator
{
    List<string> thoughts;

    public ThoughtGenerator ()
    {
        thoughts = new List<string>
        {
            "One day you will see why God made you wait",
            "Some call it missionary work others call it loving others.",
            "It is never too late to strenthen the foundation of faith.",
            "By small means the lord can bring about great things 1 Nephi 16:29",
            "Remember the worth of souls is great in the site of god. D&C 18:10",
            "I will go and do the things which the lord hath commanded. 1 Nephi 3:7",
            "Be still and know that I am God Psalm 46:10",
            "This is my comandment that ye love one another, as I loved you. John 15:12",
            "God has not ceased to be a God of miraces. Mormon 9:15"
        };
    }

    public string GetRandomThought()
    {
        string randomThought = "";
        int randomIndex1 = new Random().Next(thoughts.Count);

        randomThought = thoughts[randomIndex1];

        return randomThought;
    }
}