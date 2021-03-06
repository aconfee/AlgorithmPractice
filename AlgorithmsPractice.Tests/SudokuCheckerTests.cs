﻿using Xunit;

namespace AlgorithmsPractice.Tests
{
    public class SudokuCheckerTests
    {
        [Fact]
        public void Test()
        {
            var grid = new[] {
                new [] {".", "4", ".", ".", ".", ".", ".", ".", "." },
                new [] {".", ".", "4", ".", ".", ".", ".", ".", "." },
                new [] {".", ".", ".", "1", ".", ".", "7", ".", "." },
                new [] {".", ".", ".", ".", ".", ".", ".", ".", "." },
                new [] {".", ".", ".", "3", ".", ".", ".", "6", "." },
                new [] {".", ".", ".", ".", ".", "6", ".", "9", "." },
                new [] {".", ".", ".", ".", "1", ".", ".", ".", "." },
                new [] {".", ".", ".", ".", ".", ".", "2", ".", "." },
                new [] {".", ".", ".", "8", ".", ".", ".", ".", "." }};

            SudokuChecker.Run(grid);
        }
    }
}
