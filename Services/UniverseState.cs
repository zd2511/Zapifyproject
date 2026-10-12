using VerdantNexus.Models;

namespace VerdantNexus.Services;

public sealed class UniverseState
{
    public WorldPreset[] Presets => WorldPreset.All;
    public WorldPreset ActiveWorld { get; private set; } = WorldPreset.All[0];
    public bool AmbientAudio { get; private set; }
    public bool ReducedMotion { get; private set; }
    public bool GridOverlay { get; private set; } = true;
    public bool Diagnostics { get; private set; }
    public bool SecretUnlocked { get; private set; }
    public int ScanCount { get; private set; }
    public event Action? Changed;

    public void SelectWorld(WorldPreset preset) { ActiveWorld = preset; Changed?.Invoke(); }
    public void ToggleAudio() { AmbientAudio = !AmbientAudio; Changed?.Invoke(); }
    public void ToggleMotion() { ReducedMotion = !ReducedMotion; Changed?.Invoke(); }
    public void ToggleGrid() { GridOverlay = !GridOverlay; Changed?.Invoke(); }
    public void ToggleDiagnostics() { Diagnostics = !Diagnostics; Changed?.Invoke(); }
    public void Scan() { ScanCount++; if (ScanCount >= 7) SecretUnlocked = true; Changed?.Invoke(); }
    public void Notify() => Changed?.Invoke();
}
