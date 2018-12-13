using FantasyAppData.Models;

namespace WebApplication1.Models {
    public class PlayerViewModel {
        public int Id { get; set; }
        public PlayerType PlayerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SalaryCost { get; set; }
        public string ImageUrl { get; set; }
    }
}