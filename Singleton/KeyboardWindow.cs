internal class KeyboardWindow
{
    //field
    private static KeyboardWindow instance;
    public static KeyboardWindow Instance
    {
        get
        {
            if (instance == null)
                instance = new KeyboardWindow();
            return instance;
        }
    }
    public double Height { get; set; }
    public double Width { get; set; }

    public override string ToString()
    {
        return $"Keyboard window has height{Height}, width{Width}";
    }

    private KeyboardWindow()
    {
    }
}