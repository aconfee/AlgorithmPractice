using System.Collections.Generic;

namespace AlgorithmsPractice
{
    // O(N) time -- iterates through grid once.
    // O(C) additional memory -- uses set amount of memory to check duplicates from small character set. 
    public static class SudokuChecker
    {
        public static bool Run(string[][] grid)
        {
            var columnSet = new HashSet<string>(9);
            var rowSet = new HashSet<string>(9);
            var subGridSets = new Dictionary<int, HashSet<string>>(9);
            var ignoredCharacter = ".";

            int length = 9;
            for (int y = 0; y < length; ++y)
            {
                columnSet.Clear();
                rowSet.Clear();

                for (int x = 0; x < length; ++x)
                {
                    var rowValue = grid[y][x];
                    var columnValue = grid[x][y];

                    if (rowSet.Contains(rowValue)) return false;
                    else if (rowValue != ignoredCharacter) rowSet.Add(rowValue);

                    if (columnSet.Contains(columnValue)) return false;
                    else if (columnValue != ignoredCharacter) columnSet.Add(columnValue);

                    // Same len * y + x used for normal 2d array in array representation, but divided by 3 and len of three to represent 3x3 sub grids.
                    var subGridIndex = (3 * (y / 3)) + (x / 3); 
                    if (!subGridSets.ContainsKey(subGridIndex)) subGridSets.Add(subGridIndex, new HashSet<string>(9));

                    if (subGridSets[subGridIndex].Contains(rowValue)) return false;
                    else if (rowValue != ignoredCharacter) subGridSets[subGridIndex].Add(rowValue);
                }
            }

            return true;
        }

        public static bool Improved(string[][] grid)
        {
            var seen = new HashSet<string>(9);
            var ignoredCharacter = ".";

            int length = 9;
            for (int y = 0; y < length; ++y)
            {
                for (int x = 0; x < length; ++x)
                {
                    var value = grid[x][y];
                    if (value == ignoredCharacter) continue;

                    var row = $"row {y}: {value}";
                    var col = $"col {x}: {value}";
                    var sub = $"sub {y / 3}, {x / 3}: {value}";

                    if (seen.Contains(row) || seen.Contains(col) || seen.Contains(sub)) return false;

                    seen.Add(row);
                    seen.Add(col);
                    seen.Add(sub);
                }
            }

            return true;
        }
    }
}
