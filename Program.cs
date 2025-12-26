Random dice = new Random();

int[] rolls = new int[3];
int score = 0;

// Three dice rolls and score calculation
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("\nPress enter to roll: ");
    Console.ReadLine();
    Console.WriteLine("Rolling...\n");

    int roll = dice.Next(1, 7);

    rolls[i] = roll;
    Console.WriteLine($"Roll: {roll}");
    score += roll;
}

// Check for doubles or triples
if (rolls[0] == rolls[1] && rolls[0] == rolls[2])
{
    score += 6;
    Console.WriteLine("\nYou rolled triples! +6 bonus points!");
}
else if (rolls[0] == rolls[1] || rolls[0] == rolls[2] || rolls[1] == rolls[2])
{
    score += 2;
    Console.WriteLine("\nYou rolled doubles! +2 bonus points!");
}

// Score evaluation
if (score >= 15)
    Console.WriteLine($"\nCongratulations you win!\nYour score is: {score}\n");
else
    Console.WriteLine($"\nYou Lose! Your score: {score}\n");