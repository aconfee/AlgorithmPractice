using System;
using System.Collections.Generic;

namespace AlgorithmsPractice
{
    public static class SwapLexOrder
    {
        public static string Run(string str, int[][] pairs)
        {
            // Create adjacency list
            // If 1 can swap with 3, and 3 can swap with 4, then 1 can eventually swap with 4. Transitive.
            // For this reason we can build a graph -- connected components that have all the positions of possible
            // would-be swaps. 
            var adjacencyLists = new Dictionary<int, List<int>>();
            foreach (var pair in pairs)
            {
                var A_vertex = pair[0];
                var B_vertex = pair[1];

                if (!adjacencyLists.ContainsKey(A_vertex))
                    adjacencyLists.Add(A_vertex, new List<int>());

                if (!adjacencyLists.ContainsKey(B_vertex))
                    adjacencyLists.Add(B_vertex, new List<int>());

                adjacencyLists[A_vertex].Add(B_vertex);
                adjacencyLists[B_vertex].Add(A_vertex);
            }

            // Find the connected components. i.e. the positions where transitive swaps are connected / can be swapped to.
            var visited = new HashSet<int>();
            var connectedComponents = new HashSet<List<int>>();
            foreach (var vertex in adjacencyLists.Keys)
            {
                if (visited.Contains(vertex)) continue;

                var currentConnectedComponent = new List<int>();
                connectedComponents.Add(currentConnectedComponent);
                var vertexQueue = new Queue<int>();
                vertexQueue.Enqueue(vertex);

                while (vertexQueue.Count != 0)
                {
                    var currentVertex = vertexQueue.Dequeue();

                    if (visited.Contains(currentVertex)) continue;

                    foreach (var adjacentVertex in adjacencyLists[currentVertex])
                        vertexQueue.Enqueue(adjacentVertex);

                    currentConnectedComponent.Add(currentVertex);
                    visited.Add(currentVertex);
                }
            }

            // Get characters from vertex positions, sort them, and insert them back into the original string.
            var newString = str.ToCharArray();
            var vertexCharacters = new List<char>();
            foreach (var connectedComponent in connectedComponents)
            {
                connectedComponent.Sort();
                foreach (var index in connectedComponent)
                    vertexCharacters.Add(newString[index - 1]);

                vertexCharacters.Sort();
                vertexCharacters.Reverse();

                foreach (var index in connectedComponent)
                {
                    newString[index - 1] = vertexCharacters[0];
                    vertexCharacters.RemoveAt(0);
                }
            }

            return new string(newString);
        }
    }
}
