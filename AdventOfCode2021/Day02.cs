using AdventOfCode2021.HelperClasses;

namespace AdventOfCode2021
{
    internal class Day02
    {
        public async Task<List<SubmarineCommand>> ReadData(string fileName)
        {
            var list = new List<SubmarineCommand>();
            var fileContent = (await File.ReadAllLinesAsync(fileName));
            foreach (var line in fileContent)
            {
                var lineSplit = line.Split(' ');
                list.Add(new SubmarineCommand
                {
                    Direction = lineSplit[0],
                    NumberOfSteps = int.Parse(lineSplit[1])
                });
            }
            return list;
        }

        public long PartOne(List<SubmarineCommand> commands)
        {
            var position = (0, 0); //(x, y);
            foreach (var command in commands)
            {
                switch (command.Direction)
                {
                    case "forward":
                        position.Item1 += command.NumberOfSteps;
                        break;
                    case "up":
                        position.Item2 -= command.NumberOfSteps;
                        break;
                    case "down":
                        position.Item2 += command.NumberOfSteps;
                        break;
                }
            }
            return position.Item1 * position.Item2;
        }

        public long PartTwo(List<SubmarineCommand> commands)
        {
            var position = (0, 0, 0); //(x, y, aim);
            foreach (var command in commands)
            {
                switch (command.Direction)
                {
                    case "forward":
                        position.Item1 += command.NumberOfSteps;
                        position.Item2 += position.Item3 * command.NumberOfSteps;
                        break;
                    case "up":
                        position.Item3 -= command.NumberOfSteps;
                        break;
                    case "down":
                        position.Item3 += command.NumberOfSteps;
                        break;
                }
            }
            return position.Item1 * position.Item2;
        }
    }
}
