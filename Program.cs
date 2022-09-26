using IronPythonTest;

Console.WriteLine("Hello, World!");

var pythonEngine = new PythonEngine("C:/MyPorjects/IronPythonTest/Python/test.py");

object[] parameters = new object[] {
    new List<string>() {"hello", "world"}
};
var result = pythonEngine.InvokeMethodWithParameters("main", parameters);

if (result != null)
{
	foreach (var item in result)
    {
        Console.WriteLine(item);
    }
}