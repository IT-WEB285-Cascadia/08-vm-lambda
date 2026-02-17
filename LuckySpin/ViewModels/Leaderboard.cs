using LuckySpin.Services;

namespace LuckySpin.ViewModels
{
    public class LeaderBoard
    {
        public ICollection<LeaderboardEntry> Entries;

        public LeaderBoard(ICollection<LeaderboardEntry> entries)
        {
            Entries = entries;
        }
    }
}