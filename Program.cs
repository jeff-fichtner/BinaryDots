using Console.BinaryProject.Data.Repository;
using Console.BinaryProject.Models;

Run();

void Run()
{
    System.Console.WriteLine("~ Binary Dots ~");

    var repo = new BinaryDotsRepository();

    while (true)
    {
        // prompt enter board or exit
        System.Console.WriteLine("New board? Press 'q' to exit.");
        var response = System.Console.ReadKey();

        // if exit, exit
        if (response.KeyChar == 'q')
        {
            return;
        }

        // provide board size
        System.Console.WriteLine("Board size?");
        int parsedSize;
        var size = System.Console.ReadLine();
        try
        {
            ArgumentNullException.ThrowIfNull(size);
            parsedSize = int.Parse(size);
            if (parsedSize > 26)
            {
                throw new Exception("Too big - max is 26.");
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Something went wrong parsing size: {ex.Message}");
            continue;
        }

        List<bool?[]> rows = new();
        try
        {
            for (int i = 0; i < parsedSize; i++)
            {
                System.Console.WriteLine($"Row {i + 1}");
                var row = System.Console.ReadLine();
                ArgumentNullException.ThrowIfNull(row);
                var parsedRow =
                    row.Select(
                        x =>
                        {
                            if (x == ' ')
                            {
                                return default(bool?);
                            }

                            if (x == 'O')
                            {
                                return false;
                            }

                            if (x == 'X')
                            {
                                return true;
                            }

                            throw new Exception($"Couldn't parse char {x}");
                        })
                        .ToArray();

                rows.Add(parsedRow);
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Something went wrong creating rows: {ex.Message}");
            continue;
        }

        var board = new Board(rows);
        var solutions = repo.Solve(board);

        System.Console.WriteLine($"{solutions.Count()} {nameof(solutions)} found.");
        System.Console.WriteLine();
        foreach (var solution in solutions)
        {

        }
        // (validate)

        // go through each row
        // after last row, solve and display
        // repeat
    }
}