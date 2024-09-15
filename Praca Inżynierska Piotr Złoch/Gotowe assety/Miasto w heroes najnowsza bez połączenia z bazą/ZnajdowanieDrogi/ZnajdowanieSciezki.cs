using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Services
{
    public class ZnajdowanieSciezki// Cała testowa trzeba sprawdzić
    {
        //Mapa, na której wyszukujemy najkrótszą drogę
        private readonly bool[,] _map;
        private Graphics grafika;
        //Konstruktor ustawiający mapę
        public ZnajdowanieSciezki(Graphics grafika1,bool[,] map)
        {
            _map = map;
            grafika = grafika1;
        }

        private void RysujDroge(Graphics grafika, int x, int y)
        {
            Image image = Image.FromFile(@"..\..\grafika\Strzalka.png");
            grafika.DrawImage(image, x * 40, y * 40, 40, 40);
        }

        //Metoda zwracająca listę punktów do przejścia
        public List<Point> FindPath(Point start, Point end)
        {
            //Lista do przechowywania punktów do przejścia
            List<Point> path = new List<Point>();

            //Lista otwartych węzłów
            List<Node> openNodes = new List<Node>();

            //Lista zamkniętych węzłów
            List<Node> closedNodes = new List<Node>();

            //Dodanie węzła startowego do listy otwartych
            openNodes.Add(new Node(start, 0, 0, null));

            //Pętla wykonująca się tak długo, jak będą węzły na liście otwartych
            while (openNodes.Count > 0)
            {
                //Wybierz węzeł o najniższym koszcie całkowitym
                Node currentNode = openNodes[0];
                for (int i = 1; i < openNodes.Count; i++)
                {
                    if (openNodes[i].TotalCost < currentNode.TotalCost)
                    {
                        currentNode = openNodes[i];
                    }
                }

                //Jeśli węzeł jest węzłem docelowym, zakończ szukanie
                if (currentNode.Position == end)
                {
                    //Odtwórz ścieżkę wsteczną
                    while (currentNode.Parent != null)
                    {
                        path.Add(currentNode.Position);
                        currentNode = currentNode.Parent;
                    }

                    //Dodanie punktu startowego
                    path.Add(start);

                    //Odwróć ścieżkę aby zaczynała się od punktu startowego
                    path.Reverse();

                    break;
                }

                //Usuń węzeł z listy otwartych i dodaj do listy zamkniętych
                openNodes.Remove(currentNode);
                closedNodes.Add(currentNode);

                //Przejrzyj sąsiadów
                List<Node> neighbours = GetNeighbours(currentNode);
                foreach (Node neighbour in neighbours)
                {
                    //Jeśli sąsiad jest już na liście zamkniętych, pomiń go
                    if (closedNodes.Contains(neighbour))
                    {
                        continue;
                    }

                    //Oblicz wartość kosztu całkowitego
                    int cost = currentNode.CostSoFar + GetDistance(currentNode.Position, neighbour.Position);

                    //Jeśli sąsiad nie jest jeszcze na liście otwartych lub obliczony koszt jest mniejszy niż dotychczasowy,
                    //ustaw nowy koszt i poprzedni węzeł
                    if (!openNodes.Contains(neighbour) || cost < neighbour.CostSoFar)
                    {
                        neighbour.CostSoFar = cost;
                        neighbour.Parent = currentNode;
                        neighbour.TotalCost = neighbour.CostSoFar + GetDistance(neighbour.Position, end);

                        if (!openNodes.Contains(neighbour))
                        {
                            openNodes.Add(neighbour);
                        }
                    }
                }
            }
            foreach (var item in path)
            {
                RysujDroge(grafika,item.X, item.Y);
            }
            return path;
        }

        //Metoda zwracająca sąsiadów danego węzła
        private List<Node> GetNeighbours(Node node)
        {
            List<Node> neighbours = new List<Node>();

            //Dodanie wszystkich możliwych sąsiadów
            Point[] neighbourPoints = new Point[4];
            neighbourPoints[0] = new Point(node.Position.X + 1, node.Position.Y);
            neighbourPoints[1] = new Point(node.Position.X - 1, node.Position.Y);
            neighbourPoints[2] = new Point(node.Position.X, node.Position.Y + 1);
            neighbourPoints[3] = new Point(node.Position.X, node.Position.Y - 1);

            //Sprawdzenie, czy sąsiad może być odwiedzony
            foreach (Point point in neighbourPoints)
            {
                if (CanVisit(point))
                {
                    neighbours.Add(new Node(point, 0, 0, node));
                }
            }

            return neighbours;
        }

        //Metoda sprawdzająca, czy dany punkt może być odwiedzony
        private bool CanVisit(Point point)
        {
            //Sprawdzenie, czy punkt znajduje się na mapie
            if (point.X < 0 || point.X >= _map.GetLength(0) || point.Y < 0 || point.Y >= _map.GetLength(1))
            {
                return false;
            }

            //Sprawdzenie, czy pole jest wolne
            return !_map[point.X, point.Y];
        }

        //Metoda zwracająca odległość pomiędzy dwoma punktami
        private int GetDistance(Point point1, Point point2)
        {
            return Math.Abs(point1.X - point2.X) + Math.Abs(point1.Y - point2.Y);
        }

        //Klasa reprezentująca węzeł
        private class Node
        {
            public Point Position { get; private set; }
            public Node Parent { get; set; }
            public int CostSoFar { get; set; }
            public int TotalCost { get; set; }

            public Node(Point position, int costSoFar, int totalCost, Node parent)
            {
                Position = position;
                CostSoFar = costSoFar;
                TotalCost = totalCost;
                Parent = parent;
            }
        }

    }
}






    /*
    public class Node
    {
        public int x;
        public int y;
        public double waga;
        public double najkrotszaOdleglosc;
        public Node wskaznik;

        public Node(int x, int y, double waga)
        {
            this.x = x;
            this.y = y;
            this.waga = waga;
            najkrotszaOdleglosc = double.MaxValue;
            wskaznik = null;
        }

        public Node[] sasiednieWierzcholki(int[,] mapa, int szerokosc, int wysokosc)
        {
            List<Node> sasiednieWierzcholki = new List<Node>();

            // Sprawdzamy wszystkie punkty pośrednie od punktu początkowego do punktu końcowego
            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if (i >= 0 && i < szerokosc && j >= 0 && j < wysokosc)
                    {
                        sasiednieWierzcholki.Add(new Node(i, j, mapa[i, j]));
                    }
                }
            }
            return sasiednieWierzcholki.ToArray();
        }

        public int[][] drzewoSciezki()
        {
            List<int[]> sciezka = new List<int[]>();
            Node node = this;
            while (node != null)
            {
                sciezka.Insert(0, new int[] { node.x, node.y });
                node = node.wskaznik;
            }
            return sciezka.ToArray();
        }
    }

    public class Mapa1000x1000
    {
        public int[,] mapa;
        public int szerokosc;
        public int wysokosc;

        public Mapa1000x1000(int szerokosc, int wysokosc)
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            mapa = new int[szerokosc, wysokosc];
        }

        private void RysujDroge(Graphics grafika, int x, int y)
        {
            Image image = Image.FromFile(@"..\..\grafika\Strzalka.png");
            grafika.DrawImage(image, x*40, y*40, 40, 40);
        }

        public int[][] AlgorytmDijkstry(Graphics grafika, int xPoczatkowy, int yPoczatkowy, int xKoncowy, int yKoncowy)
        {
            int[][] najkrotszaSciezka = null;

            // Tworzymy kolejkę węzłów i dodajemy startowy węzeł do kolejki
            Queue<Node> kolejka = new Queue<Node>();
            Node poczatkowyNode = new Node(xPoczatkowy, yPoczatkowy, 0);
            kolejka.Enqueue(poczatkowyNode);

            // Tworzymy tablicę odwiedzonych węzłów
            Node[,] odwiedzone = new Node[szerokosc, wysokosc];

            // Dopóki kolejka nie jest pusta,
            // bierzemy pierwszy element z kolejki i sprawdzamy, czy jest to węzeł docelowy
            while (kolejka.Count > 0)
            {
                Node node = kolejka.Dequeue();

                // Jeśli uzyskaliśmy węzeł docelowy, zapisujemy najkrótszą ścieżkę
                if (node.x == xKoncowy && node.y == yKoncowy)
                {
                    najkrotszaSciezka = node.drzewoSciezki();
                    break;
                }

                // Sprawdzamy kolejne węzły sąsiednie do aktualnego węzła
                // i dodajemy je do kolejki, jeśli nie zostały jeszcze odwiedzone
                foreach (Node sasiad in node.sasiednieWierzcholki(mapa, szerokosc, wysokosc))
                {
                    if (odwiedzone[sasiad.x, sasiad.y] == null)
                    {
                        odwiedzone[sasiad.x, sasiad.y] = sasiad;
                        kolejka.Enqueue(sasiad);
                    }
                }
                // dodajemy węzeł do listy węzłów pośrednich
                List<int[]> sciezka = new List<int[]>();
                sciezka.Add(new int[] { node.x, node.y });
            }
            if (najkrotszaSciezka != null)
            {
                for (int i = 0; i < najkrotszaSciezka.Length; i++)
                {
                    RysujDroge(grafika, najkrotszaSciezka[i][0], najkrotszaSciezka[i][1]);
                }
            }
            return najkrotszaSciezka;
        }
    }*/