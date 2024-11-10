using System;
namespace Console.BinaryProject.Models;

public class Board
{
    public IEnumerable<bool?[]> Rows { get; }

    public Board(IEnumerable<bool?[]> rows)
    {
        Rows = rows;
    }
}
