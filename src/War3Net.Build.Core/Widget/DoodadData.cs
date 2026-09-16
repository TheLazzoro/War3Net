namespace War3Net.Build.Widget
{
    public sealed partial class DoodadData : WidgetData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoodadData"/> class.
        /// </summary>
        public DoodadData()
        {
        }

        public DoodadState State { get; set; }

        // in %, where 0x64 = 100%
        public byte Life { get; set; }

        public int GroupId { get; set; }

        public uint Unknown1 { get; set; }

        public float Roll { get; set; }

        public float Pitch { get; set; }

        public List<DoodadLightData> DoodadLights { get; set; } = new();
    }
}