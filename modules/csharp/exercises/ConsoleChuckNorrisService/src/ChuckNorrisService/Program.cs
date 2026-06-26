using ChuckNorrisService.Providers;

Console.WriteLine("Hello, World!");

// Aufgabe 1
Console.WriteLine("Aufgabe 1)");
var dummyJokeProvider = new DummyJokeProvider().GetRandomJokeAsync().Result;
String jokeToPrint = dummyJokeProvider.Id + " " + dummyJokeProvider.Value;
Console.WriteLine(jokeToPrint);
