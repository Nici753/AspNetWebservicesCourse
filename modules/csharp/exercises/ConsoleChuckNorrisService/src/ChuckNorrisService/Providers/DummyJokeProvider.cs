using ChuckNorrisService.Models;
namespace ChuckNorrisService.Providers;

public class DummyJokeProvider : IJokeProvider
{
    public Task<Joke> GetRandomJokeAsync()
    {
        return Task.FromResult(new Joke() {Id = "Cool Chuck Norris Joke:", Value = "Chuck Norris doesn't do push ups, he pushes the earth away!"});
    }
}