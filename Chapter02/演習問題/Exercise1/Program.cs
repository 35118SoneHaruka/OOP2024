﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    public class Program {
        static void Main(string[] args) {
            var songs = new Song[] {
              new Song("let it be","the Beatles",243),
              new Song("stand by me","Ben E King",320),
              new Song("shake it off","Taylor Swift",242)

           };
            PrintSongs(songs);

        }




        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine(@"{0},{1},{2:mm\:ss}",song.Title,song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
           
        }
    }
}
