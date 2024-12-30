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
        int localVar = _myPrivateInt; // Accessing the private field directly from within the class
        Console.WriteLine(localVar);
    }
}