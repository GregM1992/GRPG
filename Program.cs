using GRPG.Models;
using GRPG.Assetts;

int userChoice = 0;
List<CharacterClass> selectedClass = new(); //change this to store the index of the character choice 

void Greeting()
{
    Console.WriteLine($"\t\t\t\tWelcome traveler, you have a long journey ahead of you...\n");
    Console.WriteLine($"\t\t\t\t\t\tPlease choose a class.\n\n");
    ShowClasses();
}

void ShowClasses()
{
    int index = 1; 

    foreach (CharacterClass character in CharacterClasses.characterClasses)
    {
        Console.WriteLine($"\t\t\t\t\t\t\t\b {index++}.{character.Name}\n");
    }
}

void StartGame()
{
    userChoice = Convert.ToInt32(Console.ReadLine());
    
}

Greeting();