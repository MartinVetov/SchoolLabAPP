using log4net.Repository.Hierarchy;
using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Repositories.Interfaces;
using System.Data;

namespace SchoolLabApp.Services;

public class AssetService
{
    private readonly AssetRepository _assetRepository;
    private readonly Logger.Logger _logger;

    public AssetService(AssetRepository assetRepository, Logger.Logger logger)
    { 
        _assetRepository = assetRepository;
        _logger = logger;
    }

    public async Task AddAssets(string name, string status, int categoryId)
    {
        _logger.Info($"Adding asset: {name}");

        if (string.IsNullOrWhiteSpace(name))
        {
            _logger.Warn("Add asset failed: empty name");
            throw new ArgumentException("Asset name is required.");
        }

        if (string.IsNullOrWhiteSpace(status))
        {
            _logger.Warn($"Add asset failed for {name}: empty status");
            throw new ArgumentException("Asset status is required.");
        }

        var asset = new Asset
        {
            Name = name,
            Status = status,
            CategoryId = categoryId,
            CreatedDate = DateTime.Now
        };

        await _assetRepository.AddAsync(asset);

        _logger.Info($"Asset added successfully: {asset.Name}");
    }

    public async Task UpdateAsset(Asset asset)
    {
        _logger.Info($"Updating asset Id={asset.Id}");

        if (await _assetRepository.GetByIdAsync(asset.Id) == null)
        {
            _logger.Error($"Asset not found: {asset.Id}");
            throw new InvalidOperationException("Asset not found.");
        }

        await _assetRepository.UpdateAsync(asset);

        _logger.Info($"Asset updated successfully: {asset.Id}");
    }

    public async Task DeleteAsset(int id)
    {
        _logger.Info($"Deleting asset Id={id}");

        var asset = await _assetRepository.GetByIdAsync(id);

        if (asset == null)
        {
            _logger.Error($"Asset not found: {id}");
            throw new InvalidOperationException("Asset not found.");
        }

        await _assetRepository.DeleteAsync(id);

        _logger.Info($"Asset deleted successfully: {id}");
    }

    public async Task<IEnumerable<Asset>> GetAll()
    {
        _logger.Info("Getting all assets");
        return await _assetRepository.GetAllAsync();
    }

    public async Task<IEnumerable<Asset>> GetByCategory(int categoryId)
    {
        _logger.Info($"Getting assets from category {categoryId}");
        return await _assetRepository.GetByCategoryIdAsync(categoryId);
    }

    public async Task<IEnumerable<Asset>> GetByStatus(string status)
    {
        _logger.Info($"Getting assets with status {status}");

        if (string.IsNullOrWhiteSpace(status))
        {
            _logger.Warn("GetByStatus failed: status is empty");
            throw new ArgumentException("Argument can not be null or empty.");
        }

        return await _assetRepository.GetByStatusAsync(status);
    }

    public async Task<Asset?> GetById(int id)
    {
        _logger.Info($"Getting asset Id={id}");

        var asset = await _assetRepository.GetByIdAsync(id);

        if (asset == null)
        {
            _logger.Warn($"Asset not found: {id}");
        }

        return await _assetRepository.GetByIdAsync(id);
    }
    
    public async Task UpdateStatus(int assetId,string status)
    {
        _logger.Info($"Changing asset {assetId} status to {status}");

        var asset = await _assetRepository.GetByIdAsync(assetId);

        if (asset == null)
        {
            _logger.Error($"Asset not found: {assetId}");
            throw new InvalidOperationException("Asset not found.");
        }

        asset.Status = status;

        await _assetRepository.UpdateAsync(asset);

        _logger.Info($"Asset {assetId} status changed successfully to {status}");
    }
}
