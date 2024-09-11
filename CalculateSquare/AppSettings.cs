
// Clase estática para configuración global
public static class AppSettings
{
    private static string _themeColor = "White";
    private static int _fontsize = 12;

    public static string ThemeColor
    {
        get => _themeColor;
        set => _themeColor = value;
    }

    public static int Fontsize
    {
        get => _fontsize;
        set
        {
            if (value < 8 || value > 72)
                throw new ArgumentException("" +
                    "Font size must be between 8 " +
                    "and 72.");
            _fontsize = value;
        }
    }
}

