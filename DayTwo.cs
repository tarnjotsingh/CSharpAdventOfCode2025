namespace AdventOfCode;

public class DayTwo()
{
    string[] ReadInput(string filePath)
    {
        string fileText = File.ReadAllText(filePath);
        string[] linesArray = fileText.Split(
            new string[] { "\r\n", "\r", "\n" },
            StringSplitOptions.RemoveEmptyEntries
        );
        return linesArray;
    }

    public void Run()
    {
        string[] inputs = ReadInput("inputs/daytwo/inputs.txt");
        // int result = processRotations(50, inputs);
        Console.WriteLine(inputs);
    }
}