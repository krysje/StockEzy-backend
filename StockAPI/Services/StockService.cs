
using StockAPI.Entities;
using StockAPI.Repositories;
using System;
using System.Collections.Generic;

namespace StockAPI.Services
{
    public class StockService : IStockService
    {
        public readonly IStockRepository stockRepo;

        public StockService(IStockRepository stockRepo)
        {
            this.stockRepo = stockRepo;
        }
        public List<Company> GetAllCompanies()
        {
            try
            {
               return stockRepo.GetAllCompanies();
            }
            catch (Exception) { throw; }
        }
        public Company GetCompanyById(string code)
        {
            try
            {
                return stockRepo.GetCompanyById(code);
            }
            catch (Exception) { throw; }
        }

        public string AddCompany(Company company)
        {
            try
            {
                var addCsuccess = stockRepo.AddCompany(company);
                return (addCsuccess == 1) ? "success" : "failed";
            }
            catch (Exception) { throw; }
        }
        public string DeleteCompany(string code)
        {
            try
            {
                var deleteCsuccess = stockRepo.DeleteCompany(code);

                return (deleteCsuccess == 1) ? "success" : "failed";
            }
            catch (Exception) { throw; }
        }
        public string UpdateCompany(Company company)
        {
            try
            {
                var updateCsuccess = stockRepo.UpdateCompany(company);
                return (updateCsuccess == 1) ? "success" : "failed";
            }
            catch (Exception) { throw; }
        }


        // stock exchanges
        public List<StockExchanges> GetAllStockExchanges()
        {
            try
            {
                return stockRepo.GetAllStockExchanges();
            }
            catch (Exception) { throw; }
        }
        public StockExchanges GetStockExchangesById(string name)
        {
            try
            {
                return stockRepo.GetStockExchangesById(name);
            }
            catch (Exception) { throw; }
        }
        public string AddStockExchanges(StockExchanges stockExchange)
        {
            try
            {
                var addSEsuccess = stockRepo.AddStockExchanges(stockExchange);
                return (addSEsuccess == 1) ? "success" : "failed";
            }
            catch (Exception) { throw; }
        }
        public string UpdateStockExchanges(StockExchanges stockExchange)
        {
            try
            {
                var updateSEsucess = stockRepo.UpdateStockExchanges(stockExchange);
                return (updateSEsucess == 1) ? "success" : "failed";
            }
            catch (Exception) { throw; }
        }


        // ipo details
        public string UpdateIPODetails(IPODetails ipodetails)
        {
            try
            {
                var updateIPOsuccess = stockRepo.UpdateIPODetails(ipodetails);
                return (updateIPOsuccess == 1) ? "success" : "failed";
            }
            catch (Exception) { throw; }
        }
    }
}
