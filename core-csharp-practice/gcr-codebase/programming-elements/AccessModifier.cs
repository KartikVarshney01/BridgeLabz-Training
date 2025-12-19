class AccessModifier
{
    // public
    public int a = 10;

    // private
    private int b = 15;

    // protected
    protected int c = 20;

    // internal
    internal int d = 25;

    public void ShowPublic()
    {
        Console.WriteLine("Public value: " + a);
    }

    private void ShowPrivate()
    {
        Console.WriteLine("Private value: " + b);
    }

    protected void ShowProtected()
    {
        Console.WriteLine("Protected value: " + c);
    }

    internal void ShowInternal()
    {
        Console.WriteLine("Internal value: " + d); 
    }

    public void CallAll()
    {
        ShowPublic(); // calling the public class - accessible everywhere
        ShowPrivate(); // calling the private class - accessible inside same class only
        ShowProtected(); // calling the protected class - accessible inside class and child
        ShowInternal(); // calling the internal class - accessible only inside/outside class and inside project.
    }

    static void Main()
    {
        AccessModifier obj = new AccessModifier(); // creating new object
        obj.CallAll(); // calling the class
    }
}