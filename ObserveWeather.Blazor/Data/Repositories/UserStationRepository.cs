using Microsoft.EntityFrameworkCore;
using ObserveWeather.Blazor.Core.Interfaces;
using ObserveWeather.Blazor.Core.Models;

namespace ObserveWeather.Blazor.Data.Repositories;

public class UserStationRepository : IUserStationRepository
{
    private readonly ApplicationDbContext _dbContext;

    public UserStationRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<UserStation?> AddAsync(UserStation model)
    {
        await _dbContext.UserStations.AddAsync(model);
        await _dbContext.SaveChangesAsync();

        return model;
    }

    public async Task<UserStation?> DeleteAsync(UserStation model)
    {
        var modelToDelete = await _dbContext.UserStations.FindAsync(model.Id);

        if (modelToDelete == null) return modelToDelete;
        
        _dbContext.UserStations.Remove(modelToDelete);
        await _dbContext.SaveChangesAsync();

        return modelToDelete;
    }

    public async Task<IEnumerable<UserStation>> GetForUserAsync(string userId)
    {
        var stations = await _dbContext.UserStations
            .Where(us => us.UserId == userId)
            .ToListAsync();
        
        return stations;
    }
}