using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAPI.Entities;
using StockAPI.Services;
using System;
using System.Collections.Generic;

namespace StockAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        // manage company - get, add, update, delete,
        // manage stock exchanges - get, add 
        // manage ipo deatils - update 

        public readonly IStockService stockService;
        public AdminController(IStockService stockService)
        {
            this.stockService = stockService;
        }

        // manage company - get, add, update, delete

        [HttpGet]
        [Route("GetCompanies")]
        public IActionResult GetCompanies()
        {
            try { 
                List<Company> getcompanyResult = stockService.GetAllCompanies();
                return Created("api/created", getcompanyResult);
            }
            
            catch(Exception)
            {
                return NotFound("Nothing to show!");
            }
        }

        [HttpGet]
        [Route("GetCompany/{code}")]
        public IActionResult GetCompanyByCode(string code)
        {
            try
            {
                Company company = stockService.GetCompanyById(code);
                return Created("api/created", company);
            }
            catch (Exception)
            {
                return NotFound("Nothing to show!");
            }
        }


        [HttpPost]
        [Route("AddCompany")]
        public IActionResult AddCompany(Company company)
        {
            try
            {
                string addcompanyResult = stockService.AddCompany(company);
                return Created("api/created", addcompanyResult);
            }
            catch (Exception)
            {
                return BadRequest("Check input");
            }
        }

        [HttpPut]
        [Route("UpdateCompany")]
        public IActionResult UpdateCompany(Company company)
        {
            try
            {
                string updatecompanyResult = stockService.UpdateCompany(company);
                return Created("api/created", updatecompanyResult);
            }
            catch (Exception)
            {
                return BadRequest("Check input");
            }
        }

        [HttpDelete]
        [Route("DeleteCompany/{code}")]
        public IActionResult DeleteCompany(string code)
        {
            try
            {
                string deletecompanyResult = stockService.DeleteCompany(code);
                return Created("api/created", deletecompanyResult);
            }
            catch (Exception)
            {
                return NotFound("Company not found!");
            }
        }


        //manage stock exchanges - get, add

        [HttpGet]
        [Route("GetAllStockExchanges")]
        public IActionResult GetAllStockExchanges()
        {
            try
            {
                List<StockExchanges> getStkExchRes = stockService.GetAllStockExchanges();
                return Created("created/api", getStkExchRes);
            }
            catch (Exception)
            {
                return NotFound("Nothing to show!");
            }
        }

        [HttpGet]
        [Route("GetStockExchange/{name}")]
        public IActionResult GetStockExchangesByName(string name)
        {
            try
            {

                StockExchanges stockExchange = stockService.GetStockExchangesById(name);
                return Created("created/api", stockExchange);
            }
            catch (Exception)
            {
                return NotFound("Nothing to show!");
            }
        }

        [HttpPost]
        [Route("AddStockExchange")]
        public IActionResult AddStockExchange(StockExchanges stockExchange)
        {
            try
            {
                string addStkExchRes = stockService.AddStockExchanges(stockExchange);
                return Created("created/api", addStkExchRes);
            }
            catch (Exception)
            {
                return BadRequest("Check input");
            }
        }

        [HttpPut]
        [Route("UpdateStockExchange")]
        public IActionResult UpdateStockExchange(StockExchanges stockExchange)
        {
            try
            {

                string updateStkExchRes = stockService.UpdateStockExchanges(stockExchange);
                return Created("created/api", updateStkExchRes);
            }
            catch (Exception)
            {
                return BadRequest("Check input");
            }
        }


        //update ipo

        [HttpPut]
        [Route("UpdateIPO")]
        public IActionResult UpdateIPODetails(IPODetails iPODetails)
        {
            try
            {

                string updateIpoRes = stockService.UpdateIPODetails(iPODetails);
                return Created("created/api", updateIpoRes);
            }
            catch (Exception)
            {
                return BadRequest("Check input");
            }
        }

    }
}
