using System;

namespace GetAPet.Data.Models
{
    public class Announcement
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public int CreatorId { get; set; }

        public ApplicationUser Creator { get; set; }
    }
}
