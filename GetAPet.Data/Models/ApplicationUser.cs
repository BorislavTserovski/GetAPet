using System.Collections.Generic;

namespace GetAPet.Data.Models
{
    public class ApplicationUser
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public IEnumerable<Announcement> Announcements { get; set; } = new List<Announcement>();
    }
}
