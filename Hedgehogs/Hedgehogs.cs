using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hedgehogs;

public class Hedgehog
{
    readonly IDictionary<ColorsOfHedgehogs, int> hedgehogs;
    public Hedgehog(IDictionary<ColorsOfHedgehogs, int> hedgehogs)
        => this.hedgehogs = hedgehogs;

    public int MinCountOfMeetingsToChangeColor(ColorsOfHedgehogs desiredColor)
    {
        CheckInput();

        //If all the hedgehogs are initially of the same color
        int sumOfHedgehogs = hedgehogs.Select(h => h.Value).Sum();
        if (hedgehogs.Any(hedgehog => sumOfHedgehogs == hedgehog.Value))
            return -1;

        var (color2, color3) = GetOtherColors(desiredColor);
        ColorsOfHedgehogs[] otherColors = { color2, color3 };
        ColorsOfHedgehogs minColor = otherColors.Min(), maxColor = otherColors.Max();
        int minCountOfHedgehogs = hedgehogs[minColor], maxCountOfHedgehogs = hedgehogs[maxColor];


        return (maxCountOfHedgehogs - minCountOfHedgehogs) % 3 == 0 ? maxCountOfHedgehogs : -1;
    }


    void CheckInput()
    {
        //if not valid inputs
        if (hedgehogs.Any(hedgehog => hedgehog.Value < 0))
            throw new ArgumentException("Count of hedgehogs must be more than zero");
    }

    (ColorsOfHedgehogs color2, ColorsOfHedgehogs color3) GetOtherColors(ColorsOfHedgehogs color1)
        => ((ColorsOfHedgehogs)(((int)color1 + 1) % 3), (ColorsOfHedgehogs)(((int)color1 + 2) % 3));
}
