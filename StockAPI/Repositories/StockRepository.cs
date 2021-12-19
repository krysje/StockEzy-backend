using StockAPI.DBContext;
using StockAPI.Entities;
using StockAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockAPI.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly StockAPIDBContext db;

        public StockRepository(StockAPIDBContext db)
        {
            this.db = db;
        }
        public List<Company> GetAllCompanies()
        {
            try
            {
                return db.companies.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Company GetCompanyById(string code)
        {
            try
            {
                Company company = db.companies.SingleOrDefault(c => c.CompanyCode == code);
                return company;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public int AddCompany(Company company)
        {
            try
            {
                db.companies.Add(company);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int DeleteCompany(string code)
        {
            try
            {
                Company company = db.companies.Where(u => u.CompanyCode == code).FirstOrDefault();
                db.companies.Remove(company);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int UpdateCompany(Company company)
        {
            try
            {
                db.companies.Update(company);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // stock exchanges
        public List<StockExchanges> GetAllStockExchanges()
        {
            try
            {
                return db.stockExchanges.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public StockExchanges GetStockExchangesById(string name)
        {
            try
            {
                StockExchanges stockExchange = db.stockExchanges.SingleOrDefault(u => u.StockExchange == name);
                return stockExchange;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AddStockExchanges(StockExchanges stockExchanges)
        {
            try
            {
                db.stockExchanges.Add(stockExchanges);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int UpdateStockExchanges(StockExchanges stockExchanges)
        {
            try
            {
                db.stockExchanges.Update(stockExchanges);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }


        //ipo details
        public int UpdateIPODetails(IPODetails ipodetails)
        {
            try
            {
                db.ipoDetails.Update(ipodetails);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
