// See https://aka.ms/new-console-template for more information

using AoC_2022_2;

var input = File.ReadAllLines("Day2.txt");

var rounds = input.Select(x => x.Split(" "));

var score = 0;
var scorePart2 = 0;

foreach(var round in rounds)
{
    score += ScoreCalculator.CalculateRound(round[0], round[1]);
    scorePart2 += ScoreCalculator.CalulateRoundPart2(round[0], round[1]);
}

Console.Write($"Day 2, part 1: {score}");
Console.WriteLine();
Console.Write($"Day 2, part 2: {scorePart2}");