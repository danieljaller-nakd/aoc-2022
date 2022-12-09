using System.Security.Cryptography.X509Certificates;

var priorityList = new Dictionary<char, int>
{
    { 'a', 1 },
    { 'b', 2 },
    { 'c', 3 },
    { 'd', 4 },
    { 'e', 5 },
    { 'f', 6 },
    { 'g', 7 },
    { 'h', 8 },
    { 'i', 9 },
    { 'j', 10 },
    { 'k', 11 },
    { 'l', 12 },
    { 'm', 13 },
    { 'n', 14 },
    { 'o', 15 },
    { 'p', 16 },
    { 'q', 17 },
    { 'r', 18 },
    { 's', 19 },
    { 't', 20 },
    { 'u', 21 },
    { 'v', 22 },
    { 'w', 23 },
    { 'x', 24 },
    { 'y', 25 },
    { 'z', 26 },
    { 'A', 27 },
    { 'B', 28 },
    { 'C', 29 },
    { 'D', 30 },
    { 'E', 31 },
    { 'F', 32 },
    { 'G', 33 },
    { 'H', 34 },
    { 'I', 35 },
    { 'J', 36 },
    { 'K', 37 },
    { 'L', 38 },
    { 'M', 39 },
    { 'N', 40 },
    { 'O', 41 },
    { 'P', 42 },
    { 'Q', 43 },
    { 'R', 44 },
    { 'S', 45 },
    { 'T', 46 },
    { 'U', 47 },
    { 'V', 48 },
    { 'W', 49 },
    { 'X', 50 },
    { 'Y', 51 },
    { 'Z', 52 }
};

var input = File.ReadAllLines("Day3.txt");
var totalPriority = 0;

foreach (var line in input)
{
    var compartment1 = line.Substring(0, line.Length / 2).ToCharArray();
    var compartment2 = line.Substring(line.Length / 2, line.Length / 2).ToCharArray();
    totalPriority += compartment1.Where(x => compartment2.Contains(x)).Select(y => priorityList[y]).Distinct().Sum();
}

Console.WriteLine($"Day 3, part 1: {totalPriority}");

totalPriority = 0;

for (int i = 0; i < input.Length; i+=3)
{
    var elfGroup = new List<string> { input[i], input[i + 1], input[i + 2] };
    var common = elfGroup[0].Intersect(elfGroup[1]);
    totalPriority += priorityList[common.Intersect(elfGroup[2]).First()];
}

Console.WriteLine($"Day 3, part 2: {totalPriority}");