using SchoolLabApp.Models;
using SchoolLabApp.Repositories.Implementations;
using SchoolLabApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolLabApp.Services
{
    public class LoanService
    {
        private readonly LoanRepository _loanRepository;
        private readonly Logger.Logger _logger;

        public LoanService(LoanRepository loanRepository, Logger.Logger logger)
        {
            _loanRepository = loanRepository;
            _logger = logger;
        }

        public async Task AddLoan(int assetId, int personId, int durationDays, string status)
        {
            _logger.Info($"Creating loan: Asset={assetId}, Person={personId}");

            var loan = new Loan
            {
                AssetId = assetId,
                PersonId = personId,
                StartDate = DateTime.Now,
                DurationDays = durationDays,
                Status = status
            };
            await _loanRepository.AddAsync(loan);

            _logger.Info($"Loan created successfully for Asset={assetId}");
        }

        public async Task ReturnLoan(int loanId)
        {
            _logger.Info($"Returning loan Id={loanId}");

            var loan = await _loanRepository.GetByIdAsync(loanId);

            if (loan == null)
            {
                _logger.Error($"Loan not found: {loanId}");
                throw new InvalidOperationException("Loan not found.");
            }

            loan.Status = "Returned";
            loan.ReturnedDate = DateTime.Now;

            await _loanRepository.UpdateAsync(loan);

            _logger.Info($"Loan returned successfully: {loanId}");
        }

        public async Task<IEnumerable<Loan>> GetLoansByPerson(int personId)
        {
            _logger.Info($"Getting loans for person {personId}");

            return await _loanRepository.GetByPersonIdAsync(personId);
        }

        public async Task<IEnumerable<Loan>> GetAll()
        {
            _logger.Info("Getting all loans");

            return await _loanRepository.GetAllAsync();
        }

        public async Task UpdateLoan(Loan loan)
        {
            _logger.Info($"Updating loan Id={loan.Id}");

            var exists = await _loanRepository.ExistsAsync(loan.Id);

            if (!exists)
            {
                _logger.Error($"Loan not found: {loan.Id}");
                throw new InvalidOperationException("Loan not found.");
            }

            await _loanRepository.UpdateAsync(loan);

            _logger.Info($"Loan updated successfully: {loan.Id}");
        }

        public async Task DeleteLoan(int id)
        {
            _logger.Info($"Deleting loan Id={id}");

            if (await _loanRepository.GetByIdAsync(id) == null)
            {
                _logger.Error($"Loan not found: {id}");
                throw new InvalidOperationException("Loan not found.");
            }

            await _loanRepository.DeleteAsync(id);

            _logger.Info($"Loan deleted successfully: {id}");
        }

        public async Task<int> GetAssetId(int loanId)
        {
            _logger.Info($"Getting AssetId from loan {loanId}");

            var loan = await _loanRepository.GetByIdAsync(loanId);

            if (loan == null)
            {
                _logger.Error($"Loan not found: {loanId}");
                throw new InvalidOperationException("Loan not found.");
            }

            _logger.Info($"AssetId {loan.AssetId} returned for loan {loanId}");

            return loan.AssetId;
        }
    }
}