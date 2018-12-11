using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class GenerateController : Controller
    {
        public IActionResult Index(string pname)
        {
            Playlists stupidshit = new Playlists();
            stupidshit.songs = new List<Song>();
            stupidshit.songs.Add(new Song
            {
                Song_name = "Savior",
                Creator_band = "Rise Against"

            });
            stupidshit.songs.Add(new Song
            {
                Song_name = "Mr. Brightside",
                Creator_band = "The Killers"

            });
            stupidshit.songs.Add(new Song
            {
                Song_name = "Bohemian Rhapsody",
                Creator_band = "Queen"

            });

            stupidshit.name = "djfatnutz";

            Playlists bingo = new Playlists();
            bingo.name = "washisnameo";
            bingo.songs = new List<Song>();
            bingo.songs.Add(new Song { Song_name = "Fat Lip", Creator_band = "Sum41" });
            bingo.songs.Add(new Song { Song_name = "Ms. Jackson", Creator_band = "OutKast" });
            bingo.songs.Add(new Song { Song_name = "Bring Me To Life", Creator_band = "Evanescence" });

            if (pname == stupidshit.name)
            {
                return View(stupidshit);
            }
            else if (pname == bingo.name)
            {
                return View(bingo);
            }

            return View();
        }
    }
}