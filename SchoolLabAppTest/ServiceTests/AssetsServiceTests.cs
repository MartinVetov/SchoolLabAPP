using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using SchoolLabApp.Services;

namespace SchoolLabAppTest.ServiceTests
{
    [TestFixture]
    public class AssetServiceTests
    {
        private AssetService _assetService;

        [SetUp]
        public void Setup()
        {
            _assetService = new AssetService(null!);
        }

        [Test]
        public void AddAssets_WithEmptyName_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _assetService.AddAssets("", "Active", 1));
            Assert.That(ex.Message, Is.EqualTo("Asset name is required."));
        }

        [Test]
        public void AddAssets_WithEmptyStatus_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _assetService.AddAssets("Laptop", "", 1));
            Assert.That(ex.Message, Is.EqualTo("Asset status is required."));
        }

        [Test]
        public void GetByStatus_WithEmptyStatus_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _assetService.GetByStatus(""));
            Assert.That(ex.Message, Is.EqualTo("Argument can not be null or empty."));
        }
    }
}
