using System;
using Console.BinaryProject.Models;

namespace Console.BinaryProject.UserInterface;

public class DisplayBuilder
{
    //private const int _alphabetLength = 26;

    //private static readonly IEnumerable<string> s_alphabet = Enumerable.Range('A', _alphabetLength).Select(asciiCode => ((char)asciiCode).ToString()).ToArray();

    public string DisplayBoard(Board board)
    {
        throw new NotImplementedException();
    }

    public string DisplaySolution(Solution solution)
    {
        throw new NotImplementedException();
    }

    //private static IEnumerable<string> GetRowNames(int numberOfRows)
    //{
    //    return Enumerable.Range(1, numberOfRows).Select(x => x.ToString()).ToList();
    //}

    //private static IEnumerable<string> GetColumnNames(int numberOfColumns)
    //{
    //    if (numberOfColumns > _alphabetLength)
    //    {
    //        throw new Exception($"Max columns: {_alphabetLength}");
    //    }

    //    return Enumerable.Range(1, numberOfColumns).Select(x => x.ToString()).ToList();
    //}
}

/*

void DisplayTable()
{
    // Print column names
    System.Console.Write("   ");
    for (char col = 'A'; col <= 'J'; col++)
    {
        System.Console.Write(col);
        System.Console.Write(" ");
    }
    System.Console.WriteLine();

    // Print table
    for (int row = 1; row <= 10; row++)
    {
        // Print row name
        System.Console.Write(row.ToString().PadLeft(2));
        System.Console.Write(" ");

        for (char col = 'A'; col <= 'J'; col++)
        {
            // Determine the cell value based on some condition
            string cellValue = GetCellValue(row, col);

            // Print the cell value
            System.Console.Write(cellValue);
            System.Console.Write(" ");
        }

        // Move to the next row
        System.Console.WriteLine();
    }
}

string GetCellValue(int row, char col)
{
    // Determine the cell value based on some condition
    return (row + col) % 2 == 0 ? "X" : "O";
}

 */