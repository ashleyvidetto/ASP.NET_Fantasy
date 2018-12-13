using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FantasyAppData.Models {
    public class Customer {
        [Required]
        public int CustomerId { get; set; }
        public IEnumerable<Lineup> Lineups { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}