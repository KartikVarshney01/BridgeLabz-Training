class Finding_Index
{
    static void Main(string[] args)
    {
        string hay = Console.ReadLine();
        string needle = Console.ReadLine();

        Console.WriteLine(Fun(hay, needle));
    }

    static int Fun(string hay, string needle)
    {
        return hay.IndexOf(needle);
    }
}