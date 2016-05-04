using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7TeamMigrations.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public RecordLabel RecordLabel { get; set; }
        public int RecordLabelId { get; set; }
    }
}
