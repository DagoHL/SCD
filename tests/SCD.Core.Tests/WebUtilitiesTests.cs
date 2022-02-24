using SCD.Core.DataModels;
using SCD.Core.Utilities;
using NUnit.Framework;
using System.Threading.Tasks;

namespace SCD.Core.Tests;

public class WebUtilitiesTests
{
    private Album? _album;
    private Release? _release;

    private const string _testUrl = "https://cyberdrop.me/a/jCxmKJOD";

    [Test, Order(0)]
    public async Task FetchAlbumAsync_ReturnsAlbum()
    {
        Album result = await WebUtilities.FetchAlbumAsync(_testUrl);

        Assert.NotNull(result, "Failed to fetch album.");

        _album = result;
    }

    [Test, Order(1)]
    public void FetchAlbumAsync_IsSuccessful()
    {
        Assert.True(_album?.Success, "Album wasn't successful.");
    }

    [Test, Order(2)]
    public void FetchAlbumAsync_GetsCorrectFileCount()
    {
        Assert.IsTrue(_album?.AlbumFiles?.Length == 1);
    }

    [Test, Order(3)]
    public void FetchAlbumAsync_GetsCorrectFileInformation()
    {
        Assert.False(string.IsNullOrEmpty(_album?.AlbumFiles?[0].Filename), "Albumfile didn't have a filename.");
        Assert.False(string.IsNullOrEmpty(_album?.AlbumFiles?[0].Url), "Albumfile didn't have a url.");
    }

    [Test, Order(4)]
    public async Task FetchLatestRelease_ReturnsRelease()
    {
        Release? result = await WebUtilities.FetchLatestRelease();

        Assert.NotNull(result);

        _release = result;
    }

    [Test, Order(5)]
    public void FetchLatestRelease_GetsUrl()
    {
        Assert.False(string.IsNullOrEmpty(_release?.Url));
    }

    [Test, Order(5)]
    public void FetchLatestRelease_GetsVersion()
    {
        Assert.False(string.IsNullOrEmpty(_release?.Url));
    }
}
