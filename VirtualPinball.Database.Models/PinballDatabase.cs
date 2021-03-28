using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPinball.Database.Models
{
    public class PinballDatabase
    {
        public PinballDatabase()
        {
            Entries = new List<DatabaseEntry>();
            DatabaseFormatVersion = 1;
        }

        public DateTime LastUpdateDateUtc { get; set; }
        public int DatabaseFormatVersion { get; set; }
        public int? CheckpointLocation { get; set; }

        public List<DatabaseEntry> Entries { get; set; }
    }
}
