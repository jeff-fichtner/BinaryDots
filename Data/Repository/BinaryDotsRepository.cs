using System;
using Console.BinaryProject.Models;

namespace Console.BinaryProject.Data.Repository;

public class BinaryDotsRepository
{
    // returns all solutions
    public IEnumerable<Solution> Solve(Board board)
    {
        // add solution options to list
        // return valid solutions
        throw new NotImplementedException();
    }

    // return if more than one solution
    public bool HasMultipleSolutions(Board board)
    {
        return Solve(board).Count() > 1;
    }
}
