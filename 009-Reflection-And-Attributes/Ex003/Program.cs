using Ex003;

var spy = new Spy();
var className = typeof(Hacker).FullName;
var result = Spy.RevealPrivateMethods(className);
Console.WriteLine(result);