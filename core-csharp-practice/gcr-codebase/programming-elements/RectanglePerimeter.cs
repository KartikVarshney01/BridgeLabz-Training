class RectanglePerimeter
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        int perimeter = 2 * (length + width);
        Console.WriteLine(perimeter);
    }
}
