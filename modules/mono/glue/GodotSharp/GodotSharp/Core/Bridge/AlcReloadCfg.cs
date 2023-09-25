namespace Godot.Bridge;

public static class AlcReloadCfg
{
    private static bool _configured = false;

    public static void Configure(bool alcReloadEnabled)
    {
        System.Console.WriteLine("Godot.Bridge custom build (fix generic class reload).");
        System.Console.WriteLine("Source Code: https://github.com/ricaun/godot/tree/4.1.1-stable-custom-bridge");

        if (_configured)
            return;

        _configured = true;

        IsAlcReloadingEnabled = alcReloadEnabled;
    }

    internal static bool IsAlcReloadingEnabled = false;
}
