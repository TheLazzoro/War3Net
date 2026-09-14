namespace War3Net.Build.Widget
{
    public sealed partial class DoodadLightData
    {

        public uint LightIndex { get; set; }

        public uint IsShadowCasting { get; set; }

        public Color Color { get; set; }

        public float Intensity { get; set; }

        public float ShadowCastingStart { get; set; }

        public float ShadowCastingEnd { get; set; }

        public float QuadraticFalloff { get; set; }

        public float LinearFalloff { get; set; }

        public float Damping { get; set; }
    }
}