using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZnajdowanieDrogi
{
    public class ZnajdywanieDrogi
    {
        private Point start;
        private Point end;
        private bool[,] map;
        private int SzerokoscMapy,WysokoscMapy;
        List<Point> punkty = new List<Point>();
        Graphics grafika;

        public ZnajdywanieDrogi(Point start, Point end, bool[,] map, int SzerokoscMapy1, int WysokoscMapy1,Graphics grafika1)
        {
            this.start = start;
            this.end = end;
            this.map = map;
            SzerokoscMapy = SzerokoscMapy1;
            WysokoscMapy = WysokoscMapy1;
            grafika = grafika1;
        }
        private static double Distance(Point p1, Point p2)
        {
            // Oblicz dystans między punktami p1 i p2 
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }
        private Point ZnajdzNajplizszypunkt(Point point, Point koncowy)
        {
            double odleglosc = 0;
            double OdlegloscNajwieksza = Distance(point, koncowy);
            Point tymczasowy = point;
            Point Najblizszypunkt = point;
            tymczasowy.Y -= 1;
            odleglosc = Distance(tymczasowy, koncowy);
            if (point.Y != 0 && odleglosc <= OdlegloscNajwieksza && map[point.X,point.Y-1]== false)
            {
                OdlegloscNajwieksza = odleglosc;
                Najblizszypunkt = tymczasowy;
            }
            tymczasowy = point;
            tymczasowy.Y += 1;
            odleglosc = Distance(tymczasowy, koncowy);
            if (point.Y != WysokoscMapy && odleglosc <= OdlegloscNajwieksza && map[point.X, point.Y + 1] == false)
            {
                OdlegloscNajwieksza = odleglosc;
                Najblizszypunkt = tymczasowy;
            }
            tymczasowy = point;
            tymczasowy.X -= 1;
            odleglosc = Distance(tymczasowy, koncowy);
            if (point.X != 0 && odleglosc <= OdlegloscNajwieksza && map[point.X-1, point.Y] == false)
            {
                OdlegloscNajwieksza = odleglosc;
                Najblizszypunkt = tymczasowy;
            }
            tymczasowy = point;
            tymczasowy.X += 1;
            odleglosc = Distance(tymczasowy, koncowy);
            if (point.X != SzerokoscMapy && odleglosc <= OdlegloscNajwieksza && map[point.X+1, point.Y - 1] == false)
            {
                OdlegloscNajwieksza = odleglosc;
                Najblizszypunkt = tymczasowy;
            }
            return Najblizszypunkt;
        }

        private void RysujDroge(Graphics grafika, int x, int y)
        {
            Image image = Image.FromFile(@"..\..\grafika\Strzalka.png");
            grafika.DrawImage(image, x * 40, y * 40, 40, 40);
        }

        public List<Point> ZnajdzNajkrotszaDroga()
        {
            Point AktualnyPunkt = start;
            while (AktualnyPunkt != end)
            {
                if (AktualnyPunkt == ZnajdzNajplizszypunkt(AktualnyPunkt, end)) { break; }
                AktualnyPunkt = ZnajdzNajplizszypunkt(AktualnyPunkt, end);
                punkty.Add(AktualnyPunkt);
                RysujDroge(grafika,AktualnyPunkt.X,AktualnyPunkt.Y);
            }
            return punkty;
        }


    }
}
