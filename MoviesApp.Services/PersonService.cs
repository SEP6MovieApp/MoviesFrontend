using movies_api;
using MoviesApp.Services.Interfaces;

namespace MoviesApp.Services;

public class PersonService : IPersonService
{
    private readonly IPersonsClient _personsClient;

    public PersonService(IPersonsClient personsClient)
    {
        _personsClient = personsClient;
    }
    
    public async Task<PersonDetailsDTO> GetPerson(int personId)
    {
        return await _personsClient.GetPersonAsync(personId);
    }

    public async Task<PersonMovieCreditsDTO> GetPersonMovieCredits(int personId)
    {
        return await _personsClient.GetPersonMoviesAsync(personId);
    }

    public async Task<PersonsResponseDTO> GetPersonsByName(string keyword)
    {
        return await _personsClient.GetPersonsByNameAsync(keyword);
    }

    public async Task<PersonsResponseDTO> GetTrendingPeople()
    {
        return await _personsClient.GetTrendingPeopleAsync();
    }
}