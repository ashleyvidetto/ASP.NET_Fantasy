using System.Collections.Generic;
using System.Linq;
using FantasyAppData;
using FantasyAppData.Models;

namespace Services {
    public class PlayerService : IPlayerService {

        private FantasyContext _context;

        public PlayerService(FantasyContext context) {
            _context = context;
        }
            
     
        public IEnumerable<Player> GetAll() {
            return _context.Players.ToList();
        }

        public IEnumerable<Player> GetQBs() {
            return _context.Players.Where(p => p.Type == PlayerType.QB);
        }

        public IEnumerable<Player> GetWRs() {
            return _context.Players.Where(p => p.Type == PlayerType.WR);
        }

        public IEnumerable<Player> GetRBs() {
            return _context.Players.Where(p => p.Type == PlayerType.RB);
        }

        public IEnumerable<Player> GetTEs() {
            return _context.Players.Where(p => p.Type == PlayerType.TE);
        }

        public IEnumerable<Player> GetDefenses() {
            return _context.Players.Where(p => p.Type == PlayerType.DEFENSE);
        }

        public Player GetById(int id) {
            return _context.Players.FirstOrDefault(p => p.Id == id);
               
        }
    }
}