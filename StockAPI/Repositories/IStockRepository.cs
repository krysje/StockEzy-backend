using StockAPI.Entities;
using System.Collections.Generic;

namespace StockAPI.Repositories
{
    public interface IStockRepository
    {
        //company 
        List<Company> GetAllCompanies();
        Company GetCompanyById(string code);
        int AddCompany(Company company);
        int UpdateCompany(Company company);
        int DeleteCompany(string code);

        //stock exchanges 
        List<StockExchanges> GetAllStockExchanges();
        StockExchanges GetStockExchangesById(string name);
        int AddStockExchanges(StockExchanges stockExchanges);
        int UpdateStockExchanges(StockExchanges stockExchanges);

        //ipo details
        int UpdateIPODetails(IPODetails ipodetails);
    }
}