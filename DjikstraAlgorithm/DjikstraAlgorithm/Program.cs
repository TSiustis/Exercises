using System;

namespace DjikstraAlgorithm
{
    class Program
    {
        private static int MinDistance(int[] distance, bool[] shortestPath, int vertices)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < vertices; ++i)
            {
                if (shortestPath[i] == false && distance[i] <= min)
                {
                    min = distance[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

    

        public static void Dijkstra(int[,] graph, int source, int vertices)
        {
            int[] distance = new int[vertices];
            bool[] shortestPath = new bool[vertices];

            for (int i = 0; i < vertices; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPath[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < vertices- 1; ++count)
            {
                int u = MinDistance(distance, shortestPath, vertices);
                shortestPath[u] = true;

                for (int i = 0; i < vertices; ++i)
                    if (!shortestPath[i] && Convert.ToBoolean(graph[u, i]) && distance[u] != int.MaxValue && distance[u] + graph[u, i] < distance[i])
                        distance[i] = distance[u] + graph[u, i];
            }

            Console.WriteLine("Vertex    Distance from source");

            for (int i = 0; i < vertices; ++i)
                Console.WriteLine("{0}\t  {1}", i, distance[i]);
        }

        static void Main(string[] args)
        {
            int[,] graph =  {
                         { 0, 2, 0, 3, 0, 0, 0, 0 },//0
                         { 2, 0, 4, 0, 12, 0, 0, 0 },//1
                         { 0, 4, 0, 0, 0, 13, 11, 0 },//2
                         { 3, 0, 0, 0, 5, 0, 0, 0 },//3
                         { 0, 12, 0, 5, 0, 6, 0, 0 },//4
                         { 0, 13, 0, 0, 6, 0, 0, 7 },//5
                         { 0, 0, 11, 0, 0, 0, 0, 7 },//6
                         { 0, 0, 0, 0, 0, 7, 7, 0 }};//7

                            

            Dijkstra(graph, 0, 8);
        }
    }
}
