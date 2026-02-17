using LuckySpin.Models;
using LuckySpin.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace LuckySpin.Services
{
    public class Repository
    {   
        // This repository will eventually be the an interface between the Controller and the database context, but for now it just provides access to the database context
        private LuckySpinContext _dbContext;
        public Repository(LuckySpinContext dbContext)
        {
            _dbContext = dbContext;
        }
        public DbSet<Spin> Spins => _dbContext.Spins;
        public DbSet<Game> Games => _dbContext.Games;
        public DbSet<Player> Players => _dbContext.Players;

        //Methods to get Game, Spins and Player for a given GameId
        public Game getGame(int GameId) {
            return _dbContext.Games.FirstOrDefault(g => g.Id == GameId) ?? new Game();
        }

        public ICollection<Spin> getSpins(int GameId) {
            return _dbContext.Games.FirstOrDefault(g => g.Id == GameId)?.Spins ?? new List<Spin>();
        }   

        public Player getPlayer(int GameId) {
            return _dbContext.Games.FirstOrDefault(g => g.Id == GameId)?.Player ?? new Player();
        }

        public ICollection<Game> getGamesForPlayer(int PlayerId) {
            return _dbContext.Games.Where(g => g.PlayerId == PlayerId).ToList();
        }

        public LeaderBoard leaderBoard()
        {
            var groupedGames = _dbContext.Games 
            .GroupBy(g => g.Player)
            .Select(group => new LeaderboardEntry
             {
                Player = group.Key,
                games = group
             });
            return null; //DONE: Implement the logic to fill a Leaderboard ViewModel based on the Players and their Games and Spins in the database
        }


    }

    //DONE: create Supporting Classes for Leaderboard 
    public class LeaderboardEntry
    {
        public Player Player;
        public IGrouping<Player, Game> games;
    }

}
