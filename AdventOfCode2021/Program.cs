using AdventOfCode2021;

var day01 = new Day01();
var measurements = await day01.ReadData("Day01.txt");
Console.WriteLine(day01.NumberOfDepthIncreases(measurements));
Console.WriteLine(day01.NumberOfSumDepthIncreases(measurements));