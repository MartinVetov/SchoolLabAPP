using NUnit.Framework;
using System;
using System.Threading.Tasks;
using SchoolLabApp.Services;

namespace SchoolLabApp.Tests.AssetServiceTests
{
    [TestFixture]
    public class AssetServiceTests
    {
        private AssetService _assetService;

        [SetUp]
        public void Setup()
        {
            var logger = new Logger.Logger();

            _assetService = new AssetService(null!, logger);
        }

        [Test]
        public void AddAssets_NullName_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _assetService.AddAssets(null!, "Active", 1));

            Assert.That(ex.Message, Is.EqualTo("Asset name is required."));
        }

        [Test]
        public void AddAssets_EmptyName_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _assetService.AddAssets("", "Active", 1));

            Assert.That(ex.Message, Is.EqualTo("Asset name is required."));
        }

        [Test]
        public void AddAssets_SpacesName_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _assetService.AddAssets("   ", "Active", 1));

            Assert.That(ex.Message, Is.EqualTo("Asset name is required."));
        }

        [Test]
        public void AddAssets_NullStatus_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _assetService.AddAssets("Laptop", null!, 1));

            Assert.That(ex.Message, Is.EqualTo("Asset status is required."));
        }

        [Test]
        public void AddAssets_EmptyStatus_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _assetService.AddAssets("Laptop", "", 1));

            Assert.That(ex.Message, Is.EqualTo("Asset status is required."));
        }

        [Test]
        public void AddAssets_SpacesStatus_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _assetService.AddAssets("Laptop", "   ", 1));

            Assert.That(ex.Message, Is.EqualTo("Asset status is required."));
        }

        [Test]
        public void GetByStatus_NullStatus_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _assetService.GetByStatus(null!));

            Assert.That(ex.Message, Is.EqualTo("Argument can not be null or empty."));
        }

        [Test]
        public void GetByStatus_EmptyStatus_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _assetService.GetByStatus(""));

            Assert.That(ex.Message, Is.EqualTo("Argument can not be null or empty."));
        }

        [Test]
        public void GetByStatus_SpacesStatus_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () =>
                await _assetService.GetByStatus("   "));

            Assert.That(ex.Message, Is.EqualTo("Argument can not be null or empty."));
        }
    }
}
