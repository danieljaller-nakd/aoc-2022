var input = File.ReadAllLines("Day4.txt");

var pairs = 0;

foreach (var row in input)
{
    var assignments = row.Split(',');
    var elf1 = Enumerable.Range(int.Parse(assignments.First().Split('-').First()), int.Parse(assignments.First().Split('-').Last()) - int.Parse(assignments.First().Split('-').First()) + 1);
    var elf2 = Enumerable.Range(int.Parse(assignments.Last().Split('-').First()), int.Parse(assignments.Last().Split('-').Last()) - int.Parse(assignments.Last().Split('-').First()) + 1);
    if (elf1.Intersect(elf2).Count() == elf2.Count() || elf2.Intersect(elf1).Count() == elf1.Count())
    {
        pairs++;
    }
}

Console.WriteLine($"Day 4, part 1: {pairs}");

pairs = 0;

foreach (var row in input)
{
    var assignments = row.Split(',');
    var elf1 = Enumerable.Range(int.Parse(assignments.First().Split('-').First()), int.Parse(assignments.First().Split('-').Last()) - int.Parse(assignments.First().Split('-').First()) + 1);
    var elf2 = Enumerable.Range(int.Parse(assignments.Last().Split('-').First()), int.Parse(assignments.Last().Split('-').Last()) - int.Parse(assignments.Last().Split('-').First()) + 1);
    if (elf1.Intersect(elf2).Count() > 0 || elf2.Intersect(elf1).Count() > 0)
    {
        pairs++;
    }
}

Console.WriteLine($"Day 4, part 2: {pairs}");