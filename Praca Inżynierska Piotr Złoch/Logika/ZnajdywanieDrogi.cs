using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    class ZnajdywanieDrogi
    {
        private static List<Point> NodeToPoints(List<Node> lista)
        {
            List<Point> lista2 = new List<Point>();
            foreach (var item in lista)
            {
                Point punkt = new Point(item.X, item.Y);
                lista2.Add(punkt);
            }
            return lista2;
        }
        public static List<Point> ZwrocNajkrotszaDroga(object[,] tab, int XStartowy, int YStartowy, int XKoncowy, int Ykoncowy)
        { 
            List<Node> droga = FindShortestPath(tab, (XStartowy, YStartowy), (XKoncowy, Ykoncowy));
            if (droga != null)
            {
                List<Point> droga2 = NodeToPoints(droga);
                Point koncowy = new Point(XKoncowy, Ykoncowy);
                droga2.Add(koncowy);
                return droga2;
            }
            return null;
        }

        /*public static void ZnajdzDroge(object[,] tab, Graphics g,int XStartowy,int YStartowy, int XKoncowy, int Ykoncowy)
        {
            //object[,] tab2 = ZmianaTablicy.Zmien(tab);
            List<Node> shortestPath = FindShortestPath(tab, (XStartowy,YStartowy), (XKoncowy,Ykoncowy));

            if (shortestPath != null)
            {
                Console.WriteLine("Najkrótsza droga:");
                foreach (Node node in shortestPath)
                {

                    if (node.X == XStartowy && node.Y == YStartowy || node.X == XKoncowy && node.Y == Ykoncowy && tab[XKoncowy,Ykoncowy]!= null) 
                    {

                    }
                    else RysujDroge(g, node.Y, node.X);
                    //Console.WriteLine($"({node.X}, {node.Y})");
                }
            }
            else
            {
                //Console.WriteLine("Nie znaleziono drogi.");
            }
            //return shortestPath;
        }*/

        // Klasa reprezentująca węzeł w grafie
        class Node
        {
            public int X { get; set; }
            public int Y { get; set; }
            public List<Node> Neighbors { get; set; } = new List<Node>();
            public Node Parent { get; set; } // Dodane pole Parent
        }

        static bool IsValidCoordinate(int x, int y, int rows, int cols)
        {
            return x >= 0 && x < rows && y >= 0 && y < cols;
        }


        // Znajduje najkrótszą drogę w grafie za pomocą przeszukiwania głębokiego (DFS)
        static List<Node> FindShortestPath(object[,] grid, (int, int) start, (int, int) end)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            Node[,] nodes = new Node[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i, j] == null || (i == start.Item1 && j == start.Item2) || (i == end.Item1 && j == end.Item2))
                    {
                        nodes[i, j] = new Node { X = i, Y = j };
                    }
                }
            }

            Queue<Node> queue = new Queue<Node>();
            HashSet<Node> visited = new HashSet<Node>();

            queue.Enqueue(nodes[start.Item1, start.Item2]);
            visited.Add(nodes[start.Item1, start.Item2]);

            while (queue.Count > 0)
            {
                Node currentNode = queue.Dequeue();

                if (currentNode.X == end.Item1 && currentNode.Y == end.Item2)
                {
                    List<Node> path = new List<Node>();
                    Node traceNode = currentNode;

                    while (traceNode != null)
                    {
                        path.Insert(0, traceNode);
                        traceNode = traceNode.Parent;
                    }

                    return path;
                }

                foreach (int dx in new int[] { -1, 0, 1 })
                {
                    foreach (int dy in new int[] { -1, 0, 1 })
                    {
                        if (dx == 0 && dy == 0)
                            continue;

                        int newX = currentNode.X + dx;
                        int newY = currentNode.Y + dy;

                        if (IsValidCoordinate(newX, newY, rows, cols) && nodes[newX, newY] != null && !visited.Contains(nodes[newX, newY]))
                        {
                            nodes[newX, newY].Parent = currentNode;
                            queue.Enqueue(nodes[newX, newY]);
                            visited.Add(nodes[newX, newY]);
                        }
                    }
                }
            }

            return null; // Nie znaleziono drogi
        }
    }
}
