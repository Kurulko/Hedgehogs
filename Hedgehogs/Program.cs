void CheckInput(int[] hedgehogs, int desiredColor, int countOfColors)
{
    //if not valid inputs
    if (hedgehogs.Length != countOfColors)
        throw new ArgumentException("Incorrect count of colors for hedgehogs");
    if (desiredColor < 0 || desiredColor > countOfColors)
        throw new ArgumentException($"Incorrect value for {nameof(desiredColor)}");
    if (hedgehogs.Any(hedgehog => hedgehog < 0))
        throw new ArgumentException("Count of hedgehogs must be more than zero");
}

(int color2, int color3) GetOtherColors(int color1)
    => ((color1 + 1) % 3, (color1 + 2) % 3);



int MinCountOfMeetingsToChangeColor(int[] hedgehogs, int desiredColor)
{
    const int countOfColors = 3;

    CheckInput(hedgehogs, desiredColor, countOfColors);

    //If all the hedgehogs are initially of the same color
    int sumOfHedgehogs = hedgehogs.Sum();
    if (hedgehogs.Any(hedgehog => sumOfHedgehogs == hedgehog))
        return -1;

    var (color2, color3) = GetOtherColors(desiredColor);
    int[] otherColors = { color2, color3 };
    int minColor = otherColors.Min(), maxColor = otherColors.Max();
    int minCountOfHedgehogs = hedgehogs[minColor], maxCountOfHedgehogs = hedgehogs[maxColor];

#if true
    //first version

    return (maxCountOfHedgehogs - minCountOfHedgehogs) % 3 == 0 ? maxCountOfHedgehogs : -1;

#endif

#if false
    //second version

    int minCountOfMeetings = 0;
    //Count of meetings to count of hedgehogs for color2 equals count of hedgehogs for color3
    int i = minCountOfHedgehogs, j = maxCountOfHedgehogs;
    for (; i != j; i += 2, j--, minCountOfMeetings++)
    {
        if (i > j)
            return -1;
    }

    //If count of hedgehogs for color2 equals count of hedgehogs for color3, so min count of meetings equals their count
    minCountOfMeetings += i;

    return minCountOfMeetings;
#endif
}


//  Let's try))
try
{
    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 4, 4, 16 }, 0));
    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 4, 4, 7 }, 0));
    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 4, 7, 4 }, 0));
    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 13, 7, 10 }, 0));
    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 8, 6, 6 }, 0));
    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 8, 3, 9 }, 0));


    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 5, 2, 4 }, 0));
    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 8, 1, 9 }, 0));
    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 8, 1, 9 }, 1));
    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 8, 1, 9 }, 2));
    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 0, 0, 0 }, 0));
    Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 0, 5, 0 }, 0));

    //It'll be an exception:
    //Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 8, 1, 9 }, 10));
    //Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { }, 1));
    //Console.WriteLine(MinCountOfMeetingsToChangeColor(new int[] { 5, 6, 7, 8 }, 2));
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
