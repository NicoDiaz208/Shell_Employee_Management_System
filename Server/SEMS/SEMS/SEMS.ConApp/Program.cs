public partial class Program
{
    #region Class-Constructors
    static Program()
    {
        ClassConstructing();
        ClassConstructed();
    }
    static partial void ClassConstructing();
    static partial void ClassConstructed();
    #endregion Class-Constructors
    public static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        BeforeRun();

        AfterRun();
        Console.WriteLine(DateTime.Now);
    }
    static partial void BeforeRun();
    static partial void AfterRun();
}