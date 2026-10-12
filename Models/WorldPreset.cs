namespace VerdantNexus.Models;
public sealed record WorldPreset(string Name, string Subtitle, string Climate, string Accent, string Code, int Life, int Stability, int Energy)
{
    public static readonly WorldPreset[] All =
    [
        new("Mosslight Basin", "A bioluminescent valley after rainfall.", "TEMPERATE / WET", "#b8f28b", "MB-07", 92, 86, 74),
        new("Glasswater Expanse", "A mirror-sea beneath a pale twin moon.", "COASTAL / CALM", "#8fe7e1", "GW-12", 78, 94, 68),
        new("Ember Canopy", "Ancient redwoods warmed by a solar bloom.", "WARM / HUMID", "#ffb27a", "EC-03", 87, 73, 91)
    ];
}
