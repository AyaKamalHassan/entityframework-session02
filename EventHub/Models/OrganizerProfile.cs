using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class OrganizerProfile
    {
        public int OrganizerProfileId { get; set; }

        public string Biography { get; set; } = string.Empty;

        public string? Website { get; set; }

        public string? Logo { get; set; }

        public int OrganizerId { get; set; } //fk from oraganizer

        public Organizer Organizer { get; set; } = null!;
    }
}
