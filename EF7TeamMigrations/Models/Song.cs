using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7TeamMigrations.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; }
    }
}
