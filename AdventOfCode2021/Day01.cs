namespace AdventOfCode2021
{
    internal class Day01
    {
        public async Task<IList<int>> ReadData(string fileName) => (await File.ReadAllLinesAsync(fileName)).Select(int.Parse).ToList();

        public long NumberOfDepthIncreases(IList<int> measurements) => measurements.Where((y, index) => index < measurements.Count - 1 && measurements[index + 1] > y).Count();   
        
        public long NumberOfSumDepthIncreases(IList<int> measurements) => NumberOfDepthIncreases(measurements.Select((x, index) => index < measurements.Count - 2 ? (x + measurements[index + 1] + measurements[index + 2]) : 0).ToList());    
    }
}
