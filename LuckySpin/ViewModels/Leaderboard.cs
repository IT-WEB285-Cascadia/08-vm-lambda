using LuckySpin.Services;

namespace LuckySpin.ViewModels
{
    public class LeaderBoard
    {
        public ICollection<LeaderboardEntry> Leaderboard { get; set; } 
    }
}