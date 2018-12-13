using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FantasyAppData;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers {
    public class PlayersController : Controller {
        private IPlayerService _playerService;
        
        public PlayersController(IPlayerService playerService) {
            _playerService = playerService;
        }


        // GET
        public IActionResult Index() {
            var players = _playerService.GetAll();

            var playerView = players
                .Select(player => new PlayerViewModel{
                    Id = player.Id,
                    FirstName = player.FirstName,
                    LastName = player.LastName,
                    ImageUrl = player.ImageUrl,
                    SalaryCost = player.SalaryCost,
                    PlayerType = player.Type
                });

            var model = new PlayerViewIndex(){
                Players = playerView
            };
            return View(model);
        }


        public IActionResult PlayerDetail(int id) {
            var player = _playerService.GetById(id);
            var model = new PlayerDetailModel(){
                PlayerId = player.Id,
                FirstName = player.FirstName,
                LastName = player.LastName,
                ImageUrl = player.ImageUrl
             
            };
            return View(model);
        }

        public IActionResult SearchTwitter(int id) {
            var player = _playerService.GetById(id);
            var model = new PlayerDetailModel(){
                PlayerId = player.Id,
                FirstName = player.FirstName,
                LastName = player.LastName,
                ImageUrl = player.ImageUrl
             
            };
            model.RecentNews = new List<string>{"Twitter Info 1","Twitter Info 2"};
            return View("PlayerDetail", model);
        }
    }
} 