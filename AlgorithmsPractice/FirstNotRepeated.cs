using System.Collections.Generic;

namespace AlgorithmsPractice.Tests
{
    /// <summary>
    /// Assuming input array is small alpha characters.
    /// </summary>
    public static class FirstNotRepeated
    {
        //O(N) time -- 2N 
        //O(C) memory -- 52 bits plus dictionary overhead. 
        public static char Run(string s)
        {
            var characters = new Dictionary<char, bool>(26);
            foreach (var character in s)
            {
                if (!characters.ContainsKey(character))
                    characters.Add(character, true);
                else characters[character] = false;
            }

            foreach (var character in s)
            {
                if (characters.TryGetValue(character, out var value) && value == true)
                    return character;
            }

            return '_';
        }
    }
}
