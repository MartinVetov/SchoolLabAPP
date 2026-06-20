using Microsoft.EntityFrameworkCore;
using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Repositories.Interfaces;
using System.Data;

namespace SchoolLabApp.Services;

public class AssetService
{
    private readonly AssetRepository _assetRepository;

    public AssetService(AssetRepository assetRepository)
    { 
        _assetRepository = assetRepository;
    }

    public async Task AddAssets(string name, string status, int categoryId)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Asset name is required.");
        }
        else if (string.IsNullOrEmpty(status))
        {
            throw new ArgumentException("Asset status is required.");
        }

        var asset = new Asset
        {
            Name        = name,
            Status      = status,
            CategoryId  = categoryId,
            CreatedDate = DateTime.Now
        };

        await _assetRepository.AddAsync(asset);
    }

    public async Task UpdateAsset(Asset asset)
    {
        await _assetRepository.UpdateAsync(asset);
    }

    public async Task DeleteAsset(int id)
    {
        var asset = await _assetRepository.GetByIdAsync(id);
        if (asset == null)
        {
            throw new InvalidOperationException("Asset not found.");
        }

        await _assetRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Asset>> GetAll()
    {
        return await _assetRepository.GetAllAsync();
    }

    public async Task<IEnumerable<Asset>> GetByCategory(int categoryId)
    {
        return await _assetRepository.GetByCategoryIdAsync(categoryId);
    }

    public async Task<IEnumerable<Asset>> GetByStatus(string status)
    {
        if (string.IsNullOrWhiteSpace(status))
        {
            throw new ArgumentException("Argument can not be null or empty.");
        }

        return await _assetRepository.GetByStatusAsync(status);
    }

    public async Task<Asset?> GetById(int id)
    {
        return await _assetRepository.GetByIdAsync(id);
    }
    
    public async Task UpdateStatus(int assetId,string status)
    {
        var asset = await _assetRepository.GetByIdAsync(assetId);
        if (asset == null)
        {
            throw new InvalidOperationException("Asset not found.");
        }
        asset.Status = status;

        await _assetRepository.UpdateAsync(asset);
    }
}
