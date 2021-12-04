using AdventOfCode2021;

var day01 = new Day01();
var measurements = await day01.ReadData("Day01.txt");
Console.WriteLine("------------ Day 01 -----------");
Console.WriteLine(day01.NumberOfDepthIncreases(measurements));
Console.WriteLine(day01.NumberOfSumDepthIncreases(measurements));
Console.WriteLine("-------------------------------");

var day02 = new Day02();
var commands = await day02.ReadData("Day02.txt");
Console.WriteLine("------------ Day 02 -----------");
Console.WriteLine(day02.PartOne(commands));
Console.WriteLine(day02.PartTwo(commands));
Console.WriteLine("-------------------------------");

var day03 = new Day03();
var diagnostics = await day03.ReadDataAsync("Day03.txt");
Console.WriteLine("------------ Day 03 -----------");
Console.WriteLine(day03.PartOne(diagnostics));
Console.WriteLine(day03.PartTwo(diagnostics));
Console.WriteLine("-------------------------------");