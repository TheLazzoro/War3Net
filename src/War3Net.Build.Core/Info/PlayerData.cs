namespace War3Net.Build.Info
{
    public sealed partial class PlayerData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerData"/> class.
        /// </summary>
        public PlayerData()
        {
            AllyLowPriorityFlags = new Bitmask32(0);
            AllyHighPriorityFlags = new Bitmask32(0);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerData"/> class.
        /// </summary>
        public PlayerData(int id)
            : this()
        {
            Id = id;
            Name = $"Player {id + 1}";
        }

        public int Id { get; set; }

        public PlayerController Controller { get; set; }

        public PlayerRace Race { get; set; }

        /// <summary>
        /// Definitive Edition (3.0.0).
        /// </summary>
        public int RaceHUD { get; set; }

        public PlayerRaceHUD RaceHUDEnum
        {
            get
            {
                var isDefined = Enum.IsDefined(typeof(PlayerRaceHUD), RaceHUD); // Initial data can be junk
                return isDefined ? (PlayerRaceHUD)RaceHUD : PlayerRaceHUD.Selectable;
            }
            set => RaceHUD = (int)RaceHUDEnum;
        }

        public PlayerFlags Flags { get; set; }

        public string Name { get; set; }

        public Vector2 StartPosition { get; set; }

        public Bitmask32 AllyLowPriorityFlags { get; set; }

        public Bitmask32 AllyHighPriorityFlags { get; set; }

        public Bitmask32 EnemyLowPriorityFlags { get; set; }

        public Bitmask32 EnemyHighPriorityFlags { get; set; }

        public override string ToString() => Name;
    }
}