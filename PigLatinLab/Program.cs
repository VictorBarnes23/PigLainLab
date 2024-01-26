using System.Security.Cryptography.X509Certificates;

bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Welcome to the Pig Latin Conversion System!");
    //Prompt user for a word
    Console.WriteLine("Please provide a word to be converted to Pig Latin.");
    //User inputs a word
    string word = Console.ReadLine().ToLower().Trim();

    //Find the vowel
    int VowelPosition = -1;
    //This is for each char int the word provided by the user
    foreach (char letter in word)
    {
        //Update the count of the Vowel Position by adding 1
        VowelPosition = VowelPosition + 1;
        // Find the Vowel
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            break;
        }
    }

    if (VowelPosition == 0)
    {
        Console.WriteLine((word + "way"));
    }
    else
    {
        Console.WriteLine(word.Substring(VowelPosition ) + word.Substring(0,VowelPosition) + "ay") ;
    }

    Console.WriteLine("Would you like to translate another word? Yes/No:");
    string response = Console.ReadLine().ToLower().Trim();
    if (response != "yes")
    {
        runProgram = false;
    }





}



