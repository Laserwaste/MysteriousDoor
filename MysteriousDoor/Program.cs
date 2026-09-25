// A Character is trying to unlock a Mysterious door in this dungeon
//The door Has a secret code = 1992
//The Cahracter keeps trying different code until the correct one is entered

String SecretCode = "1992";
string attempt = "";

while (attempt != SecretCode)
{
    Console.WriteLine("Enter the secret door its only four number!");
    attempt = Console.ReadLine();
    if (attempt != SecretCode)
    {
        Console.WriteLine("Sorry the door still locked");
    }
}
Console.WriteLine("The door is unlocked");

