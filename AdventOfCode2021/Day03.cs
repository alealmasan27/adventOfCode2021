namespace AdventOfCode2021
{
    public class Day03
    {
        public async Task<List<string>> ReadDataAsync(string fileName)
        {
            return (await File.ReadAllLinesAsync(fileName)).ToList();
        }

        public long PartOne(List<string> binaryData)
        {
            var mostCommonBit = "";
            var leastCommonBit = "";
            for (var index = 0; index < binaryData[0].Length; index++)
            {
                var count = binaryData.Count(x => x[index] == '1');
                if (count >= binaryData.Count / 2)
                {
                    mostCommonBit = $"{mostCommonBit}1";
                    leastCommonBit = $"{leastCommonBit}0";
                }
                else
                {
                    mostCommonBit = $"{mostCommonBit}0";
                    leastCommonBit = $"{leastCommonBit}1";
                }
            }
            return Convert.ToInt32(mostCommonBit, 2) * Convert.ToInt32(leastCommonBit, 2);
        }

        public long PartTwo(List<string> binaryData)
        {
            return Convert.ToInt32(GetRating(new List<string>(binaryData), (nr1, nr2) => nr1 >= nr2 / 2.0), 2)
                * Convert.ToInt32(GetRating(new List<string>(binaryData), (nr1, nr2) => nr1 < nr2 / 2.0), 2);
        }

        public string GetRating(List<string> binaryData, Func<int, int, bool> condition)
        {
            for (var index = 0; binaryData.Count > 1 && index < binaryData[0].Length; index++)
            {
                var count = binaryData.Count(x => x[index] == '1');
                binaryData.RemoveAll(x => condition(count, binaryData.Count) == true ? x[index] == '0' : x[index] == '1');
            }
            return binaryData.First();
        }
    }
}