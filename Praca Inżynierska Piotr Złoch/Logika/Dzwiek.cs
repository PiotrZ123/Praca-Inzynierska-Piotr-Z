using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Praca_Inżynierska_Piotr_Złoch.Logika
{
    public class Dzwiek
    {
        public static void odegraj(string Nazwa)
        {
                var audioFile = new AudioFileReader(@"..\..\dzwieki\" + Nazwa + ".Wav");
                var outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();
        }
    }
}
