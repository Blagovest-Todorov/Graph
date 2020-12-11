using System;
using System.Collections.Generic;



namespace _24.Graph
{
    public class Graph
    {
        internal const int MaxNode = 1024;
        private int[][] childNodes;
        public Graph(int[][] chilNodes)
        {
            this.childNodes = childNodes;
        }
        public void TraversBFS(int node)
        {
            bool[] visited = new bool[MaxNode];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(node);
            visited[node] = true;
            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();
                Console.Write("{0}", currentNode);
                foreach (int childNode in childNodes[currentNode])
                {
                    if (!visited[childNode])
                    {
                        queue.Enqueue(childNode);
                        visited[childNode] = true;
                    }
                }
            }

        }
        public void TraverseDFS(int node)
        {
            bool[] visited = new bool[MaxNode];
            Stack<int> stack = new Stack<int>();
            stack.Push(node);
            visited[node] = true;
            while (stack.Count > 0)
            {
                int currentNode = stack.Pop();
                Console.Write("{0}", currentNode);
                foreach (int childNode in childNodes[currentNode])
                {
                    if (!visited[node])
                    {
                        stack.Push(childNode);
                        visited[childNode] = true;
                    }

                }
            }// graphs are sets of nodes with many to many relationshosps between them
            // graphs can be-directed, underected, weighted, unweighted, copnnected, not connected, ets
            // Tree/Graph traversing can be done by depth fist  search (DFS), or BFS -breath first searcvh

        }
    }



}
