namespace AdventOfCode;

public class DayFour() {

    string[] ReadInput(string filePath) {
        string fileText = File.ReadAllText(filePath);
        string[] linesArray = fileText.Split(
            ["\r\n", "\r", "\n"],
            StringSplitOptions.RemoveEmptyEntries
        );
        return linesArray;
    }

    public void Run() {
        string[] inputs = ReadInput("inputs/daythree/inputs.txt");
        foreach (string s in inputs)
            Console.WriteLine(s);
    }

    static void Main() {
        DayFour dayFour = new DayFour();
        dayFour.Run();
    }
}