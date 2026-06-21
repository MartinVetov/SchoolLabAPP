using NUnit.Framework;
using System;
using System.Threading.Tasks;
using SchoolLabApp.Models;
using SchoolLabApp.Services;

namespace SchoolLabApp.Tests.LoanServiceTests
{
    [TestFixture]
    public class LoanServiceTests
    {
        private LoanService _loanService;

        [SetUp]
        public void Setup()
        {
            var logger = new Logger.Logger();

            _loanService = new LoanService(null!, logger);
        }

        [Test]
        public void AddLoan_NoRepository_ThrowsNullReferenceException()
        {
            Assert.ThrowsAsync<NullReferenceException>(async () =>
                await _loanService.AddLoan(1, 1, 1, "Active"));
        }

        [Test]
        public void ReturnLoan_NoRepository_ThrowsNullReferenceException()
        {
            Assert.ThrowsAsync<NullReferenceException>(async () =>
                await _loanService.ReturnLoan(1));
        }

        [Test]
        public void UpdateLoan_NoRepository_ThrowsNullReferenceException()
        {
            var loan = new Loan { Id = 1, AssetId = 1, PersonId = 1 };

            Assert.ThrowsAsync<NullReferenceException>(async () =>
                await _loanService.UpdateLoan(loan));
        }

        [Test]
        public void DeleteLoan_NoRepository_ThrowsNullReferenceException()
        {
            Assert.ThrowsAsync<NullReferenceException>(async () =>
                await _loanService.DeleteLoan(1));
        }

        [Test]
        public void GetAssetId_NoRepository_ThrowsNullReferenceException()
        {
            Assert.ThrowsAsync<NullReferenceException>(async () =>
                await _loanService.GetAssetId(1));
        }

        [Test]
        public void GetLoansByPerson_NoRepository_ThrowsNullReferenceException()
        {
            Assert.ThrowsAsync<NullReferenceException>(async () =>
                await _loanService.GetLoansByPerson(1));
        }

        [Test]
        public void GetAll_NoRepository_ThrowsNullReferenceException()
        {
            Assert.ThrowsAsync<NullReferenceException>(async () =>
                await _loanService.GetAll());
        }
    }
}
