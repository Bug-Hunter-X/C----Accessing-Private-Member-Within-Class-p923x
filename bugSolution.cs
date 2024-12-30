public class ExampleClass
{
    private int _myPrivateInt = 10;

    public int MyProperty
    {
        get { return _myPrivateInt; }
        set { _myPrivateInt = value; }
    }

    public void MyMethod()
    {
        int localVar = this.MyProperty; // Accessing the private field indirectly through the property
        Console.WriteLine(localVar);
    }
}