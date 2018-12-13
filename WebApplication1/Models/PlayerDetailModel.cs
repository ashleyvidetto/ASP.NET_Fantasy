using System.Collections.Generic;

namespace WebApplication1.Models {
    public class PlayerDetailModel {
        public int PlayerId { get; set; }
        public string ImageUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<string> RecentNews { get; set; }
    }
}