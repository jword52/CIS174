namespace NFLTeamApp.Models
{
    public class Team
    {
        public string TeamID { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
        public Conference Conference { get; set; } = null!;
        public Division Division { get; set; } = null!;
        public string LogoImage { get; set; } = null!;
    }
}
