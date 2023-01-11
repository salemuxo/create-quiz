// create quiz assignment
#nullable disable
double correctAnswers = 0;

// WELCOME
Console.Clear();
Console.WriteLine("Obscure Music Quiz \n");

// QUESTIONS

// question 1
Console.WriteLine("1. Who coined the term 'post-rock'?");
Console.Write("Answer: ");
string answer1 = Console.ReadLine().ToLower();
if (answer1 == "simon reynolds" || answer1 == "reynolds")
{
    Console.WriteLine("Correct");
    correctAnswers++;
}
else
{
    Console.WriteLine("Incorrect");
}

// question 2
Console.WriteLine("\n 2. What was the band Black Midi's first album called?");
Console.Write("Answer: ");
string answer2 = Console.ReadLine().ToLower();
if (answer2 == "schlagenheim")
{
    Console.WriteLine("Correct");
    correctAnswers++;
}
else
{
    Console.WriteLine("Incorrect");
}

// question 3
Console.WriteLine("\n 3. Who started the band 'Dinosaur Jr.'?");
Console.Write("Answer: ");
string answer3 = Console.ReadLine().ToLower();
if (answer3 == "j. mascis" || answer3 == "joseph mascis" || answer3 == "joseph donald mascis jr" || answer3 == "j mascis")
{
    Console.WriteLine("Correct");
    correctAnswers++;
}
else
{
    Console.WriteLine("Incorrect");
}

// question 4
Console.WriteLine("\n 4. What album is the song 'Decks Dark' by Radiohead off of?");
Console.Write("Answer: ");
string answer4 = Console.ReadLine().ToLower();
if (answer4 == "a moon shaped pool" || answer4 == "amsp" || answer4 == "moon shaped pool")
{
    Console.WriteLine("Correct");
    correctAnswers++;
}
else
{
    Console.WriteLine("Incorrect");
}

// POST-TEST PROCESSING
double percentCorrect = Math.Round(correctAnswers / 4 * 100);
Console.WriteLine("\n RESULTS:");
Console.WriteLine($"Your final score is: {correctAnswers} / 4 ({percentCorrect}%).");
if (percentCorrect <= 50)
{
    Console.WriteLine("Keep studying!");
}
else if (percentCorrect <= 75)
{
    Console.WriteLine("Nice one!");
}
else
{
    Console.WriteLine("Amazing job!");
}