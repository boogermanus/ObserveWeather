﻿using ObserveWeather.Core.ApiModels;

namespace ObserveWeather.Core.Interfaces;

public interface ILocationService
{
    Task<UserStationModel?> AddAsync(PointModel? point, string? userId);
    Task<UserStationModel?> AddAsync(string stationId, string stationName, string? userId);
    Task<IEnumerable<UserStationModel>> GetForUserAsync(string? userId);
    Task<UserStationModel?> DeleteAsync(UserStationModel model);
    Task<PointModel?> GetPointAsync(double latitude, double longitude);
}