public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize during property declaration

    public ExampleClass() 
    {
        MyProperty = 10; // Initialize within the constructor 
    }

    public void MyMethod()
    {
        // Initialize within the method before access
        MyProperty = 20; 
        Console.WriteLine(MyProperty); // Now this will print 20
    }
}