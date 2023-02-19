internal class Program
{
    private static void Main(string[] args)
    {

        KeyboardWindow window = KeyboardWindow.Instance;
        window.Width = 10; window.Height = 5;
        Console.WriteLine(window);
        KeyboardWindow window1 = KeyboardWindow.Instance;
        window1.Width = 15; window1.Height = 20;
        Console.WriteLine(window1);
        Console.WriteLine(window);


        Console.ReadLine();
    }
}