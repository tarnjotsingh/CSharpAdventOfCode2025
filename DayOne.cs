namespace AdventOfCode;

using System.Collections;

// Program.cs
// The execution starts here without explicit 'Main' method or 'class' definition.


// Dial with number from 0 to 99
// If number goes below 0, then start at 99 backwards
// If number goes above 99, then start from 0 onwards

public class DayOne {
    int RotateDial(int val, string rotate) {
        string turnDir = rotate.Substring(0, 1);
        int turnVal = int.Parse(rotate.Substring(1));

        return turnDir switch {
            "L" => (val - turnVal) % 100,
            "R" => (val + turnVal) % 100,
            _ => throw new ArgumentException("Invalid turn value."),
        };
    }

    int CountPastZero(int val, string rotate) {
        string turnDir = rotate.Substring(0, 1);
        int turnVal = int.Parse(rotate.Substring(1));

        int countPastZero = 0;

        if (turnDir.Equals("L"))
            for (int i = val; i >= (val - turnVal); i--)
              if (Math.Abs(i%100) == 0) countPastZero++;

        if (turnDir.Equals("R"))
            for (int j = val; j <= (val + turnVal); j++)
              if (Math.Abs(j%100) == 0) countPastZero++;

        if (countPastZero != 0 && val == 0)
            countPastZero--;

        return countPastZero;
    }

    int ProcessRotations(int startVal, string[] rotations) {
        int lastVal = startVal;
        int zeroCount = 0;
        foreach(string r in rotations) {
            zeroCount += CountPastZero(lastVal, r);
            lastVal = RotateDial(lastVal, r);
            // if(lastVal == 0) zeroCount++;
        }
        return zeroCount;
    }


    string[] ReadInput(string filePath) {
        string fileText = File.ReadAllText(filePath);
        string[] linesArray = fileText.Split(
            ["\r\n", "\r", "\n"],
            StringSplitOptions.RemoveEmptyEntries
        );
        return linesArray;
    }

    public void Run() {
        string[] inputs = ReadInput("inputs/dayone/inputs.txt");
        int result = ProcessRotations(50, inputs);
        Console.WriteLine(result);
    }

    static void Main() {
        DayOne dayOne = new DayOne();
        dayOne.Run();
    }
}