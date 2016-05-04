using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7TeamMigrations.Models
{
    public class Artist
    {
        public virtual int ArtistId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set;}
        public virtual List<Album> Albums { get; set; }
    }
}
