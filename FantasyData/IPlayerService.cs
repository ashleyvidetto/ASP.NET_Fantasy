using System.Collections;
using System.Collections.Generic;
using FantasyAppData.Models;

namespace FantasyAppData {
    public interface IPlayerService {

        IEnumerable<Player> GetAll();
        IEnumerable<Player> GetQBs();
        IEnumerable<Player> GetWRs();
        IEnumerable<Player> GetRBs();
        IEnumerable<Player> GetTEs();
        IEnumerable<Player> GetDefenses();
        Player GetById(int id);
   }
}