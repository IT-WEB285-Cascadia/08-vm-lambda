using LuckySpin.Services;

namespace LuckySpin.ViewModels
{
    public class LeaderBoard
    {
        public ICollection<LeaderboardEntry> data { get; set; }
    }
}