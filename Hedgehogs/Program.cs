using Hedgehogs;

//  Let's try))
try
{
    Console.ForegroundColor = ConsoleColor.Green;

    IEnumerable<Hedgehog> hedgehogs = new List<Hedgehog>
    {
        new Hedgehog(
            new Dictionary<ColorsOfHedgehogs, int>
            (
                new List<KeyValuePair<ColorsOfHedgehogs, int>>()
                {
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Red, 4),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Green, 4),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Blue, 16),
                }
            )
        ),
        new Hedgehog(
            new Dictionary<ColorsOfHedgehogs, int>
            (
                new List<KeyValuePair<ColorsOfHedgehogs, int>>()
                {
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Red, 4),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Green, 4),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Blue, 7),
                }
            )
        ),
        new Hedgehog(
            new Dictionary<ColorsOfHedgehogs, int>
            (
                new List<KeyValuePair<ColorsOfHedgehogs, int>>()
                {
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Red, 4),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Green, 7),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Blue, 4),
                }
            )
        ),
        new Hedgehog(
            new Dictionary<ColorsOfHedgehogs, int>
            (
                new List<KeyValuePair<ColorsOfHedgehogs, int>>()
                {
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Red, 13),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Green, 7),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Blue, 10),
                }
            )
        ),
        new Hedgehog(
            new Dictionary<ColorsOfHedgehogs, int>
            (
                new List<KeyValuePair<ColorsOfHedgehogs, int>>()
                {
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Red, 8),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Green, 6),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Blue, 6),
                }
            )
        ),
        new Hedgehog(
            new Dictionary<ColorsOfHedgehogs, int>
            (
                new List<KeyValuePair<ColorsOfHedgehogs, int>>()
                {
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Red, 8),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Green, 3),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Blue, 9),
                }
            )
        ),
        new Hedgehog(
            new Dictionary<ColorsOfHedgehogs, int>
            (
                new List<KeyValuePair<ColorsOfHedgehogs, int>>()
                {
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Red, 5),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Green, 2),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Blue, 4),
                }
            )
        ),
        new Hedgehog(
            new Dictionary<ColorsOfHedgehogs, int>
            (
                new List<KeyValuePair<ColorsOfHedgehogs, int>>()
                {
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Red, 8),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Green, 1),
                    new KeyValuePair<ColorsOfHedgehogs, int>(ColorsOfHedgehogs.Blue, 9),
                }
            )
        ),
    };

    foreach (Hedgehog hedgehog in hedgehogs)
        Console.WriteLine(hedgehog.MinCountOfMeetingsToChangeColor(ColorsOfHedgehogs.Red));
}
catch (ArgumentException ex)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(ex.Message);
}
catch
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Something went wrong...");
}
finally
{
    Console.ForegroundColor = ConsoleColor.White;
}
