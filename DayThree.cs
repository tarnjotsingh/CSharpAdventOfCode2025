namespace AdventOfCode;

public class DayThree() {

    string[] ReadInput(string filePath) {
        string fileText = File.ReadAllText(filePath);
        string[] linesArray = fileText.Split(
            ["\r\n", "\r", "\n"],
            StringSplitOptions.RemoveEmptyEntries
        );
        return linesArray;
    }

    int ProcessString(string input) {
        // Trail through numbers in string, find highest value and split array at largest num.
        // 818181[9] split -> 1111[2]111
        // First number cannot be the last number
        string allJoltages = input, joltage = "";
        int largestNum = 0, numIndex = 0;
        for (int j = 1; j >= 0; j--) {
            for(int i = 0; i < allJoltages.Length; i++) {
                int v = allJoltages[i] - '0';
                if (v > largestNum && i != allJoltages.Length - j) {
                    largestNum = v;
                    numIndex = i;
                }
            }
            joltage += largestNum;
            largestNum = 0;
            allJoltages = allJoltages.Substring(numIndex + j);
        }

        return int.Parse(joltage);
    }

    public void Run() {
        string[] inputs = ReadInput("inputs/daythree/inputs.txt");
        List<int> joltages = [];
        foreach (string s in inputs)
            joltages.Add(ProcessString(s));

        int total = joltages.Sum();
        Console.WriteLine(total);
    }

    static void Main() {
        DayThree dayThree = new DayThree();
        dayThree.Run();
    }
}