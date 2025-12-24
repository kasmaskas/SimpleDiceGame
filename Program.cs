

using System.Data;

Random dice = new Random();

int[] rolls = new int[3];

int score = 0;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Press enter to roll: ");
    Console.ReadLine();

    int roll = dice.Next(1, 7);

    rolls[i] = roll;
    Console.WriteLine("Zarınız: " + roll);
    score += roll;
}

if (rolls[0] == rolls[1] && rolls[0] == rolls[2])
{
    score += 6;
}

else if (rolls[0] == rolls[1] || rolls[0] == rolls[2] || rolls[1] == rolls[2])
{
    score += 2;
}

if (score >= 15)
{
    Console.WriteLine("Congratulations you win!\nYour score is: " + score);

}

else
{
    Console.WriteLine("You Lose! Your score: " + score);
}