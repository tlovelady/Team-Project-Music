using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Song
    {
        public string Song_name { get; set; }
        public string Creator_band { get; set; }
        [Key]
        public int Song_Id { get; set; }
    }
}
