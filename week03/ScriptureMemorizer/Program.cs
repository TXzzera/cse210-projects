using System;

class Program
{
    static Random random = new Random();
    static void Main(string[] args)
    {
        string textMatthew = "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.";
        string textJohn = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string textJohn2 = "If ye love me, keep my commandments.";
        string textMark = "45 For even the Son of man came not to be ministered unto, but to minister, and to give his life a ransom for many.";
        string textMatthew2 = "Then said Jesus unto his disciples, If any man will come after me, let him deny himself, and take up his cross, and follow me. For whosoever will save his life shall lose it: and whosoever will lose his life for my sake shall find it.";

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Matthew",11,28,30),textMatthew),
            new Scripture(new Reference("John",3,16),textJohn),
            new Scripture(new Reference("John",14,15),textJohn2),
            new Scripture(new Reference("Mark",10,45),textMark),
            new Scripture(new Reference("Matthew",16,24,25),textMatthew2)

        };
        int numberHidden = 3;
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Please, press 'enter' to continue or type 'end' to finish:");
        string enterText = Console.ReadLine();

        while(!enterText.ToLower().Equals("end")){
            Console.Clear();
            scripture.HideWords(numberHidden);
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Please, press 'enter' to continue or type 'end' to finish:");
            enterText = Console.ReadLine();

            if(scripture.TotalHidden()){
                break;
            }

    }

    Console.WriteLine("Good luck memorizing these passages. God bless you!");
}}


