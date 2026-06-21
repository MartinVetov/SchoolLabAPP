using SchoolLabApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLabAppTest.ServiceTests
{
    [TestFixture]
    public class LoanServiceTests
    {
        private LoanService _loanService;

        [SetUp]
        public void Setup()
        {
            _loanService = new LoanService(null!);
        }

        [Test]
        public void AddLoan_WithEmptyStatus_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _loanService.AddLoan(1, 1, 7, ""));
            Assert.That(ex.Message, Is.EqualTo("Status is required."));
        }

        [Test]
        public void AddLoan_WithNullStatus_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _loanService.AddLoan(1, 1, 7, null!));
            Assert.That(ex.Message, Is.EqualTo("Status is required."));
        }

        [Test]
        public void AddLoan_WithZeroOrNegativeDuration_ThrowsArgumentException()
        {
            var ex = Assert.ThrowsAsync<ArgumentException>(async () => await _loanService.AddLoan(1, 1, 0, "Active"));
            Assert.That(ex.Message, Is.EqualTo("Duration days must be greater than zero."));
        }
    }
}
