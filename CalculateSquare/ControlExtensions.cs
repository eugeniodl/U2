public static class ControlExtensions
{
    public static void SetFormattedText(this Control control, 
        string format, params object[] args)
    {
        control.Text = string.Format(format, args);
    }
}

