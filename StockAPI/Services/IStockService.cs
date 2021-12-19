using StockAPI.Entities;
using System.Collections.Generic;

namespace StockAPI.Services
{
    public interface IStockService
    {
        //company
        List<Company> GetAllCompanies();
        Company GetCompanyById(string code);
        string AddCompany(Company company);
        string UpdateCompany(Company company);
        string DeleteCompany(string code);

        //stock exchanges 
        List<StockExchanges> GetAllStockExchanges();
        StockExchanges GetStockExchangesById(string name);
        string AddStockExchanges(StockExchanges stockExchange);
        string UpdateStockExchanges(StockExchanges stockExchange);

        //ipo details
        string UpdateIPODetails(IPODetails ipodetails);

    }
}
