using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsPractice
{
    public static class FindSubstringsKindOf
    {
        public static string[] Run(string[] words, string[] parts)
        {
            var partLookup = new HashSet<string>(parts);
            for (int w = 0; w < words.Length; ++w)
            {
                for (int length = 5; length > 0; --length)
                {
                    for (int i = 0; i + length < words[w].Length; ++i)
                    {
                        if (partLookup.Contains(words[w].Substring(i, length)))
                        {
                            words[w] = words[w].Substring(0, i) + "[" + words[w].Substring(i, length) + "]" + words[w].Substring(i + length);
                            length = 0; // break out of this word. we have longest substring.
                            break;
                        }
                    }
                }
            }

            return words;
        }
    }
}
