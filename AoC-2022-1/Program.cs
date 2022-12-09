// See https://aka.ms/new-console-template for more information

var input = File.ReadAllLines("Day1.txt");
var calorieDictionary = new Dictionary<int, int>();
var index = 0;
foreach(var line in input)
{
    if (!string.IsNullOrEmpty(line))
    {
        if (calorieDictionary.ContainsKey(index))
        {
            calorieDictionary[index] += int.Parse(line);
            continue;
        }
        calorieDictionary.Add(index, int.Parse(line));
        continue;
    }
    index++;
}
Console.Write("Day 1, part 1: ");
Console.Write(calorieDictionary.Values.Max());
Console.WriteLine();
Console.Write("Day 1, part 2: ");
Console.Write(calorieDictionary.Values.OrderByDescending(x => x).Take(3).Sum());