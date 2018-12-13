using System.ComponentModel.DataAnnotations;

namespace FantasyAppData.Models
{
    public class Lineup
    {
        [Required]
        public int Id { get; set; }
        public Player QB { get; set; }
        public Player WR1 { get; set; }
        public Player WR2 { get; set; }
        public Player RB1 { get; set; }
        public Player RB2 { get; set; }
        public Player Flex { get; set; }
        public Player TE { get; set; }
        public Player Defense { get; set; }
    }

    public class Player {
        
        [Required]
        public int Id { get; set; }

        [Required] 
        public PlayerType Type { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        [Required]
        public int SalaryCost { get; set; }
        public string ImageUrl { get; set; }
    }
    
    
    public enum PlayerType {
        QB,
        WR,
        RB,
        TE, 
        DEFENSE
    }
}