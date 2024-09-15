using Miasto_w_heroes.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasto_w_heroes.Services
{
    class ZnajdowanieSciezki// Cała testowa trzeba sprawdzić
    {
        Point Poczotkowy;
        Point Koncowy;
        int[,] MapaPrzejezdneCzyNie = new int[1000, 1000];


        /*public ZnajdowanieSciezki(Bohater bohater,Point punkt, Mapa mapa)
        {
            Poczotkowy.X = bohater.PolozenieX;
            Poczotkowy.Y = bohater.PolozenieY;
            Koncowy = punkt;
            int j = 0;
            while (j < 1000)
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (mapa.Przeszkody[i, j] == null) MapaPrzejezdneCzyNie[i, j] = 0;
                    else MapaPrzejezdneCzyNie[i, j] = 1;
                }
                j++;
            }
        }*/


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

                // Sprawdzamy sąsiednie węzły w górę
                if (y > 0)
                {
                    sasiednieWierzcholki.Add(new Node(x, y - 1, mapa[x, y - 1]));
                }

                // Sprawdzamy sąsiednie węzły w dół
                if (y < wysokosc - 1)
                {
                    sasiednieWierzcholki.Add(new Node(x, y + 1, mapa[x, y + 1]));
                }

                // Sprawdzamy sąsiednie węzły w lewo
                if (x > 0)
                {
                    sasiednieWierzcholki.Add(new Node(x - 1, y, mapa[x - 1, y]));
                }

                // Sprawdzamy sąsiednie węzły w prawo
                if (x < szerokosc - 1)
                {
                    sasiednieWierzcholki.Add(new Node(x + 1, y, mapa[x + 1, y]));
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
                grafika.DrawImage(image,x,y,50,50);
            }

            public int[][] AlgorytmDijkstry(Graphics grafika,int xPoczatkowy, int yPoczatkowy, int xKoncowy, int yKoncowy)
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
        }
    }
}
