
public class Book
{
    Reference    reference;
    List<Word>   words; 


    private string selectedScripture = "";
    
    private Random random = new Random();


    public Book(Reference _reference, string _text)
    {
        reference = _reference;
        words = new List<Word>();
        // List<string> scriptures = new List<string>();

        List<string> allWords = _text.Split(' ').ToList();
            foreach(string wordString in allWords)
            {
                Word newWord = new Word(wordString);
                words.Add(newWord);
            }

        
       // words.Add("Moses" 1, 39 "For behold, this is my awork and my bglory—to bring to pass the cimmortality and deternal elife of man.");
        //scriptures.Add("Moses 7:18 And the Lord called his people aZion, because they were of bone heart and one mind, and dwelt in righteousness; and there was no poor among them.");
       // scriptures.Add("Abraham 3:22-23 Now the Lord had shown unto me, Abraham, the aintelligences that were organized before the world was; and among all these there were many of the bnoble and great ones; And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast achosen before thou wast born.");

    }

    public void ChooseScripture()
    {
       // selectedScripture = scriptures[random.Next(0, (scriptures.Count))];
        
    }

    public string GetSctripture()
    {
        return selectedScripture;
    }

    public void InputNewScripture()
        {
            Console.WriteLine("What is your reference? ");

            string input = Console.ReadLine();
            selectedScripture += input + " | ";

            Console.WriteLine("Submit the first verse: ");
            input = Console.ReadLine();

            selectedScripture += input;

            Console.WriteLine("Are there any more verses? ");
            input = Console.ReadLine();

            while (input != "no")
            {
                Console.WriteLine("Submit the next verse: ");
                input = Console.ReadLine();
                selectedScripture += "\n" + input;

                Console.WriteLine("Are there any more verses? ");
                input = Console.ReadLine();
            }
        }


}