using System;
using static CodeToTest.Constants;

namespace CodeToTest;

public class Program
{
    public static void Main(string[] args)
    {
        int ageOfViewer = 10;
        string result = AvailableClassifications(ageOfViewer);
        Console.WriteLine(result);
    }

    public static string AvailableClassifications(int ageOfViewer)
    {
        if (ageOfViewer >= 0 && ageOfViewer < 12)
        {
            return "U & PG films are available.";
        }
        else if (ageOfViewer >= 12 && ageOfViewer < 15)
        {
            return "U, PG & 12 films are available.";
        }
        else if (ageOfViewer >= 15 && ageOfViewer < 18)
        {
            return "U, PG, 12 & 15 films are available.";
        }
        else if (ageOfViewer >= 18 && ageOfViewer <= MAX_HUMAN_AGE)
        {
            return "All films are available.";
        } else
        {
            return "Invalid input.";
        }
    }
}