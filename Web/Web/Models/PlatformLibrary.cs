using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class PlatformLibrary
    {
        [Key]
        public int Library_Id { get; set; }
        
        public ICollection<Playlists> Playlist_Id { get; set; }

    }
}
