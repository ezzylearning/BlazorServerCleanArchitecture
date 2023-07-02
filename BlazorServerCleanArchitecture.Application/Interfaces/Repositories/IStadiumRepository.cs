using BlazorServerCleanArchitecture.Domain.Entities;

namespace BlazorServerCleanArchitecture.Application.Interfaces.Repositories
{
    public interface IStadiumRepository
    {
        Task<List<Stadium>> GetStadiumByCityAsync(string cityName);
    }
}
