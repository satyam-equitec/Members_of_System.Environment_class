class Program
{
    static void Main()
    {
        ShowEnvironmental();
        Console.ReadLine();
    }
    static void ShowEnvironmental()
    {
        foreach (string drive in Environment.GetLogicalDrives())
        {
            Console.WriteLine("Drive: {0}", drive);
        }
        Console.WriteLine("Os: {0}", Environment.OSVersion);
        Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
        Console.WriteLine(".NET Core Version: {0}", Environment.Version);
        Console.WriteLine("Username: {0}", Environment.UserName);
        Console.WriteLine("Get the Exit Code: {0}", Environment.ExitCode);
        Console.WriteLine("Return bool OS is Cureently Running on 64bit OS: {0}", Environment.Is64BitOperatingSystem);
        Console.WriteLine("Current Machine name: {0}", Environment.MachineName);
        Console.WriteLine("Return the full path of System Directory: {0}", Environment.SystemDirectory);
    }
}