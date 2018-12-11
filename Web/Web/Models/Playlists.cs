using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Playlists
    {
        public int ID { get; set; }
        public string name { get; set; }
        public List<Song> songs { get; set; }
    }
}
