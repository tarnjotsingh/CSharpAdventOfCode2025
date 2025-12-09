# C# Advent of Code 2025

This repository contains my solutions for the Advent of Code 2025 challenges, implemented in C#.

## Project Structure

The project is organized with a separate class for each day's challenge within the `AdventOfCode` namespace.

- **Program.cs**: The entry point of the application. It instantiates and runs the solution for the current day.
- **DayOne.cs**: Solution for Day 1 (Dial rotation logic).
- **DayTwo.cs**: Solution for Day 2 (Repeated pattern detection).
- **DayThree.cs**: Solution for Day 3 (Joltage processing).
- **DayFour.cs**: Solution for Day 4 (Paper roll accessibility calculation).
- **inputs/**: Directory containing input files for the challenges.

## Prerequisites

- .NET SDK (The project is configured for .NET 10.0)

## How to Run

1.  Clone the repository.
2.  Navigate to the project directory.
3.  Run the project using the .NET CLI:

```bash
dotnet run
```

To run a specific day's solution, uncomment the corresponding lines in `Program.cs` and comment out the others.

## Solutions

### Day 1
Implements logic for rotating a dial based on input instructions (e.g., "L50", "R20").

### Day 2
Includes logic to detect repeated patterns in numeric values.

### Day 3
Processes string inputs to calculate values based on specific rules (Joltage).

### Day 4
Calculates accessible paper rolls in a stack based on adjacency rules using a 2D grid approach.
