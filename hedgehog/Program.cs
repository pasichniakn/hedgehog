int[] arrayOfHedgehog = { 9, 3, 1 };
int favoriteColor = 2;

int[] transformHedgehog(int[] arrayOfHedgehog, int basicColorIndex)
{
    for (int i = 0; i < 3; i++)
    {
        if (i == basicColorIndex)
        {
            arrayOfHedgehog[i] = arrayOfHedgehog[i] + 2;
        }
        else
        {
            arrayOfHedgehog[i] = arrayOfHedgehog[i] - 1;
        }
    }
    return arrayOfHedgehog;
}

int calculationOfSteps(int[] arrayOfHedgehog, int favoriteColor)
{
    int[] arrayOfColor = { 3, 3 };
    int step = 0;
    for (int i = 0; i < 3; i++)
    {
        if ((i != favoriteColor) && (arrayOfColor[0] == 3))
        {
            arrayOfColor[0] = i;
        }
        else if (i != favoriteColor)
        {
            arrayOfColor[1] = i;
        }
    }

    if (arrayOfHedgehog[arrayOfColor[0]] == arrayOfHedgehog[arrayOfColor[1]])
    {
        if (arrayOfHedgehog[arrayOfColor[0]] == 0)
        {
            return -1;
        }
        goto Calcul;
    }

    while (arrayOfHedgehog[arrayOfColor[0]] != arrayOfHedgehog[arrayOfColor[1]])
    {
        if (Math.Abs(arrayOfHedgehog[arrayOfColor[0]] - arrayOfHedgehog[arrayOfColor[1]]) % 3 == 0)
        {
            if (arrayOfHedgehog[favoriteColor] == 0)
            {
                arrayOfHedgehog = transformHedgehog(arrayOfHedgehog, favoriteColor);
                
            }
            else
            {
                arrayOfHedgehog = transformHedgehog(arrayOfHedgehog, arrayOfHedgehog[arrayOfColor[0]] < arrayOfHedgehog[arrayOfColor[1]] ? arrayOfColor[0] : arrayOfColor[1]);

            }
            step++;
        }
        else
        {
            return -1;
            
        }
    }

Calcul:
    if (arrayOfHedgehog[arrayOfColor[0]] == arrayOfHedgehog[arrayOfColor[1]])
    {
        step = step + arrayOfHedgehog[arrayOfColor[0]];
    }
    return step;
}

Console.WriteLine(calculationOfSteps( arrayOfHedgehog, favoriteColor).ToString());




