using IronPythonTest;

Console.WriteLine("Hello, World!");

var pythonEngine = new PythonEngine("C:/MyPorjects/IronPythonTest/Python/test.py");

object[] parameters = new object[] {3, 4};
var result = pythonEngine.InvokeMethodWithParameters("add", parameters);

Console.WriteLine(result);