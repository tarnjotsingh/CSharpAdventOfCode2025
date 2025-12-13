using System.Text.RegularExpressions;

namespace AdventOfCode;

public class DayFive() {

    string[] ReadInput(string filePath) {
        string fileText = File.ReadAllText(filePath);
        string[] linesArray = fileText.Split(
            ["\r\n", "\r", "\n"],
            StringSplitOptions.TrimEntries
        );
        return linesArray;
    }

    bool testInRanges(string testVal, string[] testRanges) {
        long toCheck = Int64.Parse(testVal);

        foreach(string testRange in testRanges) {
            string[] split = testRange.Split('-');
            long lower = Int64.Parse(split[0]);
            long higher = Int64.Parse(split[1]);

            if(toCheck >= lower && toCheck <= higher)
                return true;
        }
        return false;
    }


    // Determine which ingredients are FRESH or SPOILED
    // Top portion of the input are ranges
    // Split by a single blank line
    // Bottom portion are the list of available ingredient IDs
    //
    // Idea is that while processing an ingredient ID, if it falls within one of the ranges
    // the ingredient is considered to be FRESH, otherwise SPOILED.
    public void Run() {
        string[] inputs = ReadInput("inputs/dayfive/inputs.txt");

        // Use regex to cleanly filter out the values from the input.
        var rangesRegex = new Regex(@"^(\d+)-(\d+)$");
        var valueRegex = new Regex(@"^(\d+)$");
        string[] ranges = inputs.Where(s => rangesRegex.IsMatch(s)).ToArray();
        string[] values = inputs.Where(s => valueRegex.IsMatch(s)).ToArray();

        int count = 0;
        foreach(string v in values) {
            bool result = testInRanges(v, ranges);
            count += result ? 1 : 0;
        }

        Console.WriteLine(count);
    }

    static void Main() {
        DayFive dayFive = new DayFive();
        dayFive.Run();
    }
}