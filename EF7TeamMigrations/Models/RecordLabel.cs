using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7TeamMigrations.Models
{
    public class RecordLabel
    {
        public int RecordLabelId { get; set; }
        public List<Album> Albums { get; set; }
    }
}
