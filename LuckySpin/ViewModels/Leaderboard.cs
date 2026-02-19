using LuckySpin.Services;

namespace LuckySpin.ViewModels
{
    public class LeaderBoard
    {
        public ICollection<Repository.LeaderboardEntry> Leaderboard { get; set; } = new List<Repository.LeaderboardEntry>();
        
    }

}